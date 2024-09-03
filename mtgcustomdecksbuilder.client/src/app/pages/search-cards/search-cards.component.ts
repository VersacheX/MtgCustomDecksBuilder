import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { ListComponent } from '../../_controls/list-component.component';

@Component({
  selector: 'app-search-cards',
  templateUrl: './search-cards.component.html'
})
export class SearchCardsComponent extends ListComponent implements OnInit {
  public mtgCards: any[];
  public mtgSets: any[];

  public fromSetData: any[];
  public toSetData: any[];
  public setTypes: any[];

  public searchCriteria: any = {
    CmcTo: '1,2,3,4,5,6,7,8,9,10'
  };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute) {
    super();
  }

  override LoadDataGridsData() {
    this.mtgCards = undefined;

    this.http.post<any[]>(this.baseUrl + 'mtgcard/GetMtgCardsByCriteria', this.searchCriteria).subscribe(result => {
      this.mtgCards = result;

    }, error => console.error(error));
  }

  override LoadControlsData() {
    this.GetSetData();
    this.GetSetTypeData();
  }

  GetSetTypeData() {
    this.http.get<any[]>(this.baseUrl + 'mtgset/GetMtgSetTypes').subscribe(result => {
      this.setTypes = result.sort((a: any, b: any) => {
        return new Date(a.name) > new Date(b.name) ? 1 : -1;
      });
      console.log(this.mtgSets[0]);

    }, error => console.error(error));
  }


  GetSetData() {
    this.http.post<any[]>(this.baseUrl + 'mtgset/GetMtgSetsByCriteria', this.searchCriteria).subscribe(result => {
      this.mtgSets = this.OrderSetsByDate(result);
      this.toSetData = this.mtgSets;
      this.fromSetData = this.mtgSets;
      this.searchCriteria.SetFromDate = this.fromSetData[this.fromSetData.length - 1].releaseDate;
      this.searchCriteria.SetToDate = this.toSetData[0].releaseDate;

    }, error => console.error(error));
  }

  OrderSetsByDate(sets: any[]) {
    sets.sort((a: any, b: any) => {
      return new Date(a.releaseDate) < new Date(b.releaseDate) ? 1 : -1;
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
      this.toSetData = this.mtgSets.filter(set => new Date(set.releaseDate) >= new Date(this.searchCriteria.SetFromDate));
    else
      this.toSetData = this.mtgSets;
  }

  UpdateFromSetData() {
    if (this.searchCriteria.SetToDate)
      this.fromSetData = this.mtgSets.filter(set => new Date(set.releaseDate) <= new Date(this.searchCriteria.SetToDate));
    else
      this.toSetData = this.mtgSets;
  }
}
