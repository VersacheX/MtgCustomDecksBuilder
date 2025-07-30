import { ChangeDetectorRef, Component, Inject, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from '../../_controls/detail-component.component';
import { MatTable } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { CardDetailsDialog } from './card-detail-dialog.component';
import { SuggestedCardModalComponent } from './popup/suggested-card-modal.component';
import { ExistingComboModalComponent } from './popup/existing-combo-modal.component';
import { SuggestedComboModalComponent } from './popup/suggested-combo-modal.component';
import { SearchCardsComponent } from '../search-cards/search-cards.component';

@Component({
  selector: 'app-deck-builder',
  templateUrl: './deck-builder.component.html',
  styleUrls: ['./deck-builder.component.css']
})
export class DeckBuilderComponent extends DetailComponent implements OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatTable) table: MatTable<any>;
  @ViewChild(MatSort) sharedSort: MatSort;

  public selectedHomebrew: any = null;
  public selectedCommander: any = null;
  public selectedCommander2: any = null;
  public selectedCompanion: any = null;
  public rawMtgCardData: any[];
  public deckName: string = '';

  public deckImportData: any = {};
  public homebrews: any;
  public dataSources: { [key: string]: MatTableDataSource<any> } = {};
  public orderedGroups: Record<string, any[]>;

  public showImportTable: boolean = false;
  public showExportTable: boolean = false;
  public exportedData: string = '';

  public displayedColumns: string[] = ['name', 'set', 'manaCost', 'value', 'actions'];
  public typeOrder = [
    'battle', 'planeswalker', 'creature', 'sorcery', 'instant',
    'artifact', 'enchantment', 'land'
  ];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute, private changeDetectorRef: ChangeDetectorRef, public dialog: MatDialog) {
    super(Route);
  } 

  override GetData() {
    this.http.get<any>(this.baseUrl + 'decks/GetById/' + this.BusinessObjectId).subscribe(result => {
      console.log(result);
      this.selectedHomebrew = result.Homebrew;
      this.selectedCommander = result.Commander1;
      this.selectedCommander2 = result.Commander2;
      this.selectedCompanion = result.Companion;
      this.deckName = result.Name;
      this.setdeckListData(result.DeckList);
  
    }, error => console.error(error));
  }

  override LoadControlsData() {
    this.http.get<any[]>(this.baseUrl + 'homebrew/GetAllHomebrews').subscribe(result => {
      this.homebrews = result;

    }, error => console.error(error));
  }

  ImportDeck() {
    this.toggleImportTable();

    this.http.post<any[]>(this.baseUrl + 'decks/Import', this.deckImportData).subscribe(result => {
      this.setdeckListData(result);



    }, error => {
      console.error('Error importing deck:', error);
      console.log('Error details:', error);
      alert('An error occurred while importing the deck. Please try again.');
    });
  }

  groupAndOrderCardsByType(cards: any[]): Record<string, any[]> {
    const groups: Record<string, any[]> = {};

    cards.forEach(card => {
      const types = card.Types.split(',').map(type => type.trim().toLowerCase());
      let primaryType = types[0];

      if (types.includes('land')) {
        primaryType = 'land';
      } else if (types.includes('creature')) {
        primaryType = 'creature';
      } else if (types.includes('artifact')) {
        primaryType = 'artifact';
      } else if (types.includes('battle')) {
        primaryType = 'battle';
      } else if (types.includes('planeswalker')) {
        primaryType = 'planeswalker';
      } else if (types.includes('sorcery')) {
        primaryType = 'sorcery';
      } else if (types.includes('instant')) {
        primaryType = 'instant';
      } else if (types.includes('enchantment')) {
        primaryType = 'enchantment';
      }

      if (!groups[primaryType]) {
        groups[primaryType] = [];
      }

      groups[primaryType].push(card);
    });

    // Sort the groups based on the specified order
    const orderedGroups: Record<string, any[]> = {};
    this.typeOrder.forEach(type => {
      if (groups[type]) {
        orderedGroups[type] = groups[type];
      }
    });

    // Add any remaining groups that are not in the specified order
    Object.keys(groups).forEach(type => {
      if (!orderedGroups[type]) {
        orderedGroups[type] = groups[type];
      }
    });

    return orderedGroups;
  }

  GetDeckColorIdentity() {
    let identity: string[] = [];

    if (!this.selectedCommander && !this.selectedCommander2) {
      identity = ['W', 'U', 'B', 'R', 'G'];
    }

    if (this.selectedCommander) {
      identity.push(...this.selectedCommander.ColorIdentity.split(','));
    }

    if (this.selectedCommander2) {
      const commander2Identities = this.selectedCommander2.ColorIdentity.split(',');
      commander2Identities.forEach(id => {
        if (!identity.includes(id)) {
          identity.push(id);
        }
      });
    }

    return identity;
  }

  IsCardLegal(card: any) {
    if (this.selectedCommander || this.selectedCommander2 || !card.ColorIdentity || card.ColorIdentity === '') {
      let identity: string[] = [];

      if (!this.selectedCommander && !this.selectedCommander2) {
        identity = ['W', 'U', 'B', 'R','G'];
      }

      if (this.selectedCommander) {
        identity.push(...this.selectedCommander.ColorIdentity.split(','));
      }

      if (this.selectedCommander2) {
        const commander2Identities = this.selectedCommander2.ColorIdentity.split(',');
        commander2Identities.forEach(id => {
          if (!identity.includes(id)) {
            identity.push(id);
          }
        });
      }

      const cardIdentities = card.ColorIdentity.split(',');
      if (!cardIdentities.every(cardColor => cardColor == '' || identity.includes(cardColor))) {
        return false;
      }
    }


    if (this.selectedHomebrew) {
      const allowedSets = this.selectedHomebrew.AllowedSets;
      const setTypes = this.selectedHomebrew.SetTypes;

      const isLegalInFormat = card.MtgCardLegalities.some(legality => legality.Format === this.selectedHomebrew.GameFormatName && legality.Legality === 'Legal');

      // Condition 2: Set Type
      const hasValidSetType = allowedSets.some(allowedSet => card.MtgCardSets.some(cardSet => cardSet.SetType === allowedSet.Type));

      // Condition 3: Allowed Sets
      const isInAllowedSet = allowedSets.some(allowedSet => card.MtgCardSets.some(cardSet => cardSet.MtgSetFk === allowedSet.Id));


      // Combine conditions using bitwise AND
      if (!(isLegalInFormat && hasValidSetType && isInAllowedSet))
        return false;
    }

    return true;
  }

  RemoveCard(card: any) {
    const index = this.rawMtgCardData.indexOf(card);
    if (index > -1) {
      const updatedData = this.rawMtgCardData.slice();
      updatedData.splice(index, 1);
      this.setdeckListData(updatedData);
    } else {
      console.log('Card not found in mtgCards');
    }
  }

  openCardDetails(card: any): void {
    const dialogRef = this.dialog.open(CardDetailsDialog, {
      width: '600px',
      data: card
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      // handle the result
    });
  }

  handleSelectedCard(card: any) {
    if (!this.rawMtgCardData)
      this.rawMtgCardData = [];
    const updatedData = this.rawMtgCardData.slice();
    updatedData.push(card);
    this.setdeckListData(updatedData);
  }

  setdeckListData(data) {
    this.rawMtgCardData = data;
    this.orderedGroups = this.groupAndOrderCardsByType(this.rawMtgCardData);
    this.updateDataSources();

  }

  updateDataSources() {
    for (let type in this.orderedGroups) {
      this.dataSources[type] = new MatTableDataSource(this.orderedGroups[type]);
      this.dataSources[type].sortingDataAccessor = (item, property) => {
        switch (property) {
          case 'name': return item.Name.toLowerCase();
          case 'manaCost': return item.Cmc;
          default: return item[property];
        }
      };
      this.dataSources[type].sort = this.sharedSort;
    }
  }

  showEdhrecSuggestions() {
    this.GetEdhrecCards().subscribe(result => {
      this.openSuggestedCardModal(result);

    }, error => {
      console.log('Error details:', error);
    });
  }

  GetEdhrecCards() {
    return this.http.post<any[]>(this.baseUrl + 'edhrec/GetSuggestedCardsByCriteria', { "CommanderName": this.selectedCommander.Name, "CommanderName2": this.selectedCommander2?.Name, "Homebrew": this.selectedHomebrew, "MtgCards": this.rawMtgCardData });
  }

  openSuggestedCardModal(cards: any[]) {
    const dialogRef = this.dialog.open(SuggestedCardModalComponent, {
      width: '80vw',
      data: { cards }
    });

    const instance = dialogRef.componentInstance;
    instance.cardSelected.subscribe((selectedCard: any) => {
      this.handleSelectedCard(selectedCard);
    });
  }

  showExistingCombos() {
    this.http.post<any[]>(this.baseUrl + 'spellbook/GetIncludedCombos', { "MtgCards": this.rawMtgCardData }).subscribe(result => {
      if (result)
        this.openExistingComboModal(result);

    }, error => {
      console.log('Error details:', error);
    });
  }

  openExistingComboModal(combos: any[]) {
    const dialogRef = this.dialog.open(ExistingComboModalComponent, {
      width: '40vw',
      data: { combos }
    });

    const instance = dialogRef.componentInstance;
  }

  showComboSuggestions() {
    this.GetSpellbookCards().subscribe(result => {
      if (result)
        this.openSuggestedComboModal(result);

    }, error => {
      console.log('Error details:', error);
    });
  }

  openSuggestedComboModal(combos: any[]) {
    let deckList = this.rawMtgCardData;
    const dialogRef = this.dialog.open(SuggestedComboModalComponent, {
      width: '40vw',
      data: { combos, deckList }
    });

    const instance = dialogRef.componentInstance;
    instance.cardSelected.subscribe((selectedCard: any) => {
      this.handleSelectedCard(selectedCard);
    });
  }

  openAdvancedSearchModal() {
    let deckList = this.rawMtgCardData;
    let homebrew = this.selectedHomebrew;
    let colorIdentity = this.GetDeckColorIdentity();
    const dialogRef = this.dialog.open(SearchCardsComponent, {
      width: '80vw',
      data: { homebrew, deckList, colorIdentity }
    });

    const instance = dialogRef.componentInstance;
    instance.cardSelected.subscribe((selectedCard: any) => {
      this.handleSelectedCard(selectedCard);
    });
  }

  GetSpellbookCards() {
    return this.http.post<any[]>(this.baseUrl + 'spellbook/GetSuggestedCardsByCriteria', { "Homebrew": this.selectedHomebrew, "MtgCards": this.rawMtgCardData });
  }

  SetCardAsCommander(card: any) {
    this.selectedCommander = card;
  }

  SetCardAsPartner(card: any) {
    this.selectedCommander2 = card;
  }

  isLegendaryCreature(card: any): boolean {
    const types = card.Types.toLowerCase().split(',').map(type => type.trim());
    const supertypes = card.SuperTypes.toLowerCase().split(',').map(supertype => supertype.trim());

    return supertypes.includes('legendary') && types.includes('creature');
  }

  canBeCommander(card: any): boolean {
    const types = card.Types.toLowerCase().split(',').map(type => type.trim());
    const supertypes = card.SuperTypes.toLowerCase().split(',').map(supertype => supertype.trim());

    if (supertypes.includes('legendary') && types.includes('creature')) return true;
    if (supertypes.includes('legendary') && types.includes('planeswalker') && card.Text.indexOf("can be your commander") > -1) return true;
    if (supertypes.includes('legendary') && card.Power > 0 && card.Toughness > 0) return true;

    return false;
  }

  toggleImportTable() {
    this.showImportTable = !this.showImportTable;
  }

  toggleExportTable() {
    this.showExportTable = !this.showExportTable;
    if (this.showExportTable) {
      this.exportedData = this.generateExportData();
    }
  }

  generateExportData(): string {
    // Assuming rawMtgCardData is populated
    return this.rawMtgCardData.map(card => this.createOriginalString(card)).join('\n');
  }

  createOriginalString(card: any): string {
    // Assuming you have a way to get the count for each card
    let count = this.getCountForCard(card);
    return `${count} ${card.Name} (${card.Set}) ${card.Number}`;
  }

  getCountForCard(card: any): number {
    // Implement your logic to get the count for the card
    return 1; // Example
  }

  ripDeckImages() {
    this.http.get(this.baseUrl + 'decks/GetDeckImagesZip/' + this.BusinessObjectId, { responseType: 'blob' })
      .subscribe((response: Blob) => {
        const url = window.URL.createObjectURL(response);
        const a = document.createElement('a');
        a.href = url;
        a.download = `deck_${this.BusinessObjectId}.zip`;
        a.click();
        window.URL.revokeObjectURL(url);
      }, error => {
        console.error('Error downloading the zip file', error);
      });
  }

  override ValidateSaveData() {
    return true;
  }

  override SaveData() {
    this.http.post<any[]>(this.baseUrl + 'decks/Save', {
      "Id": this.BusinessObjectId,
      "Name": this.deckName,
      "Homebrew": this.selectedHomebrew,
      "Commander1": this.selectedCommander,
      "Commander2": this.selectedCommander2,
      "Companion": this.selectedCompanion,
      "DeckList": this.rawMtgCardData
    }).subscribe(result => {      

    }, error => {
      console.log('Error details:', error);
    });
  }
}
