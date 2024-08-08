import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { ListComponent } from '../../_controls/list-component.component';

@Component({
  selector: 'app-download-mtg-data',
  templateUrl: './download-mtg-data.component.html'
})
export class DownloadMtgDataComponent extends ListComponent implements OnInit {

  public setDownloadCount: number;
  public cardDownloadCount: number;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute) {
    super();
  }

  override LoadDataGridsData() {
  }

  public DownloadMtgSets() {
    this.http.post<number>(this.baseUrl + 'mtgapidata/DownloadMtgSets', null).subscribe(result => {
      this.setDownloadCount = result;
    }, error => console.error(error));
  }

  public DownloadMtgCards() {
    this.http.post<number>(this.baseUrl + 'mtgapidata/DownloadMtgCards', null).subscribe(result => {
      this.cardDownloadCount = result;
    }, error => console.error(error));
  }


}
