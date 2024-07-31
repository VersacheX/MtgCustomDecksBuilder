import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { ListComponent } from '../../_controls/list-component.component';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent extends ListComponent implements OnInit {
  public mtgCards: any[];

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
      console.log(this.mtgCards[0]);

    }, error => console.error(error));
  }


}
