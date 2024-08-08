import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { ListComponent } from '../../_controls/list-component.component';
import { EditHomebrewComponent } from './popup/edit-homebrew.component';
import { BsModalRef, BsModalService, ModalOptions } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-homebrews',
  templateUrl: './homebrews.component.html'
})
export class HomebrewsComponent extends ListComponent implements OnInit {
  public homebrews: any[];

  public searchCriteria: any = {};

  bsModalRef?: BsModalRef;

  constructor(private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    public Route: ActivatedRoute,
    private bsModalService: BsModalService  ) {
    super();
  }

  public homebrewDtOptions: any =
    {
      language: {
        emptyTable: 'No Results'
      }
    };

  override LoadDataGridsData() {
    this.homebrews = undefined;

    this.http.post<any[]>(this.baseUrl + 'homebrew/GetHomebrewsByCriteria', this.searchCriteria).subscribe(result => {
      this.homebrews = result;

      if (this.homebrews && this.homebrews.length > 0)
        console.log(this.homebrews[0]);

    }, error => console.error(error));
  }

  override LoadControlsData() {
    //this.GetSetData();
    //this.GetSetTypeData();
  }

  openAddHomebrewPopup() {
    const initialState: ModalOptions = {
      initialState: {
        list: [],
        title: 'Modal with component'
        
      },
      class: 'full-size-modal'
    };
    this.bsModalRef = this.bsModalService.show(EditHomebrewComponent, initialState);
    this.bsModalRef.content.closeBtnName = 'Close';
  }
}
