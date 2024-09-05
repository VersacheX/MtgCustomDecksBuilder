import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { ListComponent } from '../../_controls/list-component.component';
import { BsModalRef, BsModalService, ModalOptions } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-deck-list',
  templateUrl: './deck-list.component.html'
})
export class DeckListComponent extends ListComponent implements OnInit {
  public userDecks: any[];

  public searchCriteria: any = {};

  bsModalRef?: BsModalRef;

  constructor(private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    public Route: ActivatedRoute,
    private bsModalService: BsModalService  ) {
    super();
  }

  public userDecksDtOptions: any =
    {
      language: {
        emptyTable: 'No Results'
      }
    };

  override LoadDataGridsData() {
    this.userDecks = undefined;

    this.http.post<any[]>(this.baseUrl + 'decks/GetUserDecks', this.searchCriteria).subscribe(result => {
      this.userDecks = result;

    }, error => console.error(error));
  }

  override LoadControlsData() {
    //this.GetSetData();
    //this.GetSetTypeData();
  }
}
