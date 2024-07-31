import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ListComponent } from '../../_controls';
import { Router } from "@angular/router";

@Component({
  selector: 'app-customers-fraud-list',
  templateUrl: './customers-fraud-list.component.html'
})
export class CustomersFraudListComponent extends ListComponent implements OnInit {
  public blacklists: BlacklistCustomer[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router) {
      super();
  }

  override LoadDataGridsData() {

    this.http.get<BlacklistCustomer[]>(this.baseUrl + 'blacklist/GetBlackListOrders').subscribe(result => {
      this.blacklists = result;
    }, error => console.error(error));
  }

  public openOrderDetailsPopup(orderId: number) {
    const url = this.router.serializeUrl(
      this.router.createUrlTree(['/customers-blacklist-orderdetails', orderId])
    );
    window.open(url, "_blank", "config='toolbar=no, menubar=no'");
  }
}

interface BlacklistCustomer {
  BlacklistID: number;
  ProviderOrderID: number;
  DateTimeOrderPlaced: string;
  BillToFName: string;
  BillToLName: string;
  BillToAddress: string;
  BillToZip: string;
  ShipToFName: string;
  ShipToLName: string;
  ShipToAddress: string;
  ShipToZip: string;
  Comments: string;
  CartID: string;
}
