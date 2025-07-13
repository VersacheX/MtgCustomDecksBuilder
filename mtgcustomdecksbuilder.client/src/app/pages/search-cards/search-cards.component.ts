import { Component, EventEmitter, Inject, OnInit, Output } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ListComponent } from '../../_controls/list-component.component';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-search-cards',
  templateUrl: './search-cards.component.html',
  styleUrls: ['./search-cards.component.css']
})
export class SearchCardsComponent extends ListComponent implements OnInit {
  @Output() cardSelected = new EventEmitter<any>();
  public orderedGroups: Record<string, any[]>;

  public mtgCards: any[];
  public mtgSets: any[];

  public fromSetData: any[];
  public toSetData: any[];
  public setTypes: any[];

  public searchCriteria: any = {  };
  public typeOrder = [
    'battle', 'planeswalker', 'creature', 'sorcery', 'instant',
    'artifact', 'enchantment', 'land'
  ];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string,
              public dialogRef: MatDialogRef<SearchCardsComponent>,
              @Inject(MAT_DIALOG_DATA) public data: { homebrew: any, deckList: any[], colorIdentity: string[] }) {
    super();

    this.searchCriteria.Homebrew = data.homebrew;
    this.searchCriteria.IgnoredCardList = data.deckList;
    this.searchCriteria.ColorIdentity = data.colorIdentity;
  }

  override LoadDataGridsData() {

  }

  SearchData() {
    this.http.post<any[]>(this.baseUrl + 'mtgcard/GetMtgCardsByCriteria', this.searchCriteria).subscribe(result => {
      this.setdeckListData(result);

    }, error => console.error(error));
  }

  setdeckListData(data) {
    this.mtgCards = data;
    this.orderedGroups = this.groupAndOrderCardsByType(this.mtgCards);

  }

  override LoadControlsData() {
    this.GetSetData();
    this.GetSetTypeData();
  }

  GetSetTypeData() {
    this.http.get<any[]>(this.baseUrl + 'mtgset/GetMtgSetTypes').subscribe(result => {
      this.setTypes = result.sort((a: any, b: any) => {
        return new Date(a.Name) > new Date(b.Name) ? 1 : -1;
      });

    }, error => console.error(error));
  }


  GetSetData() {
    this.http.post<any[]>(this.baseUrl + 'mtgset/GetMtgSetsByCriteria', this.searchCriteria).subscribe(result => {
      this.mtgSets = this.OrderSetsByDate(result);
      this.toSetData = this.mtgSets;
      this.fromSetData = this.mtgSets;
      this.searchCriteria.SetFromDate = this.fromSetData[this.fromSetData.length - 1].ReleaseDate;
      this.searchCriteria.SetToDate = this.toSetData[0].ReleaseDate;

    }, error => console.error(error));
  }

  OrderSetsByDate(sets: any[]) {
    sets.sort((a: any, b: any) => {
      return new Date(a.ReleaseDate) < new Date(b.ReleaseDate) ? 1 : -1;
    });
    return sets;
  }

  SetsFromChanged() {
    this.UpdateToSetData();
  }

  SetsToChanged() {
    this.UpdateFromSetData();
  }

  UpdateToSetData() {
    if (this.searchCriteria.SetFromDate)
      this.toSetData = this.mtgSets.filter(set => new Date(set.ReleaseDate) >= new Date(this.searchCriteria.SetFromDate));
    else
      this.toSetData = this.mtgSets;
  }

  UpdateFromSetData() {
    if (this.searchCriteria.SetToDate)
      this.fromSetData = this.mtgSets.filter(set => new Date(set.ReleaseDate) <= new Date(this.searchCriteria.SetToDate));
    else
      this.toSetData = this.mtgSets;
  }

  selectCard(card: any) {
    if (this.searchCriteria.IgnoredCardList)
      this.searchCriteria.IgnoredCardList.push(card);
    const index = this.mtgCards.indexOf(card);
    if (index > -1) {
      const updatedData = this.mtgCards.slice();
      updatedData.splice(index, 1);
      this.setdeckListData(updatedData);
      this.cardSelected.emit(card);
    }
  }

  groupAndOrderCardsByType(cards: any[]): Record<string, any[]> {
    const groups: Record<string, any[]> = {};

    // Sort cards by Cmc in descending order
    cards.sort((a, b) => a.Cmc - b.Cmc);

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
}
