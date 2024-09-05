import { Component, EventEmitter, Inject, OnInit, Output } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ListComponent } from '../../_controls/list-component.component';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-search-cards',
  templateUrl: './search-cards.component.html',
  styleUrls: ['./search-cards.component.css']
})
export class SearchCardsComponent extends ListComponent implements OnInit {
  @Output() cardSelected = new EventEmitter<any>();
  public mtgCards: any[];
  public mtgSets: any[];

  public fromSetData: any[];
  public toSetData: any[];
  public setTypes: any[];

  public searchCriteria: any = {
    CmcTo: '1,2,3,4,5,6,7,8,9,10'
  };

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
      this.mtgCards = result;

      console.log(this.mtgCards);
    }, error => console.error(error));
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
    this.searchCriteria.IgnoredCardList.push(card);
    const index = this.mtgCards.indexOf(card);
    if (index > -1) {
      const updatedData = this.mtgCards.slice();
      updatedData.splice(index, 1);
      this.mtgCards = updatedData;
      this.cardSelected.emit(card);
    }
  }
}
