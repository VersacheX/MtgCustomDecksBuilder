import { AfterViewInit, ChangeDetectorRef, Component, Inject, OnInit, QueryList, ViewChild, ViewChildren } from '@angular/core';
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

@Component({
  selector: 'app-deck-builder',
  templateUrl: './deck-builder.component.html',
  styleUrls: ['./deck-builder.component.css']
})
export class DeckBuilderComponent extends DetailComponent implements OnInit, AfterViewInit {
  public deckImportData: any = {};
  //public mtgCards = new MatTableDataSource<any>([]);
  public rawMtgCardData: any[];
  public deckName: string = '';
  //public dataTable: any;
  public showImportTable: boolean = false;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatTable) table: MatTable<any>;
  @ViewChildren(MatSort) sorts: QueryList<MatSort>;
  public dataSources: { [key: string]: MatTableDataSource<any> } = {};
  public orderedGroups: Record<string, any[]>;

  public selectedHomebrew: any = null;
  public selectedCommander: any = null;
  public selectedCommander2: any = null;

  public homebrews: any;

  public displayedColumns: string[] = ['name', 'set', 'manaCost', 'actions'];
  public typeOrder = [
    'battle', 'planeswalker', 'creature', 'sorcery', 'instant',
    'artifact', 'enchantment', 'land'
  ];
  //public displayedColumns: string[] = ['name', 'image', 'actions'];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute, private changeDetectorRef: ChangeDetectorRef, public dialog: MatDialog) {
    super(Route);
  }

  ngAfterViewInit() {
    this.sorts.changes.subscribe(() => {
      this.sorts.forEach((sort, index) => {
        const type = this.typeOrder[index];
        if (this.dataSources[type]) {
          this.dataSources[type].sort = sort;
          this.dataSources[type].sortData(this.dataSources[type].data, sort);
        }
      });
    });
  }

  override LoadControlsData() {
    //this.mtgCards.paginator = this.paginator;
    //this.mtgCards.sort = this.sort;

    this.http.get<any[]>(this.baseUrl + 'homebrew/GetAllHomebrews').subscribe(result => {
      this.homebrews = result;

    }, error => console.error(error));
  }

  ImportDeck() {
    this.toggleImportTable();

    this.http.post<any[]>(this.baseUrl + 'decks/Import', this.deckImportData).subscribe(result => {


      this.rawMtgCardData = result;
      this.orderedGroups = this.groupAndOrderCardsByType(this.rawMtgCardData);
      this.updateDataSources();



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

  IsCardLegal(card: any) {
    if (this.selectedCommander || this.selectedCommander2 || !card.ColorIdentity || card.ColorIdentity === '') {
      let identity: string[] = [];

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
      if (cardIdentities.some(cardColor => !identity.includes(cardColor))) {
        return false;
      }
    }


    if (this.selectedHomebrew != null) {
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
      this.rawMtgCardData = updatedData;
      this.orderedGroups = this.groupAndOrderCardsByType(this.rawMtgCardData);
      this.updateDataSources();
      console.log('Updated mtgCards:', this.rawMtgCardData);
    } else {
      console.log('Card not found in mtgCards');
    }
  }

  //applyFilter(filterValue: string) {
  //  this.mtgCards.filter = filterValue.trim().toLowerCase();
  //}

  //openCardDetails(card: any) {
  //  const dialogRef = this.dialog.open(CardDetailsDialog, {
  //    width: '250px',
  //    data: card
  //  });
  //}

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

  handleSelectedCard(card: any) {
    const updatedData = this.rawMtgCardData.slice();
    updatedData.push(card);
    this.rawMtgCardData = updatedData;
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

  showComboSuggestions() {
    this.GetSpellbookCards().subscribe(result => {
      if (result)
        console.log(result);

    }, error => {
      //console.error('Error importing deck:', error);
      console.log('Error details:', error);
      //alert('An error occurred while importing the deck. Please try again.');
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

  toggleImportTable() {
    this.showImportTable = !this.showImportTable;
  }
}
