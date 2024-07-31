import { Component, Inject, Input, OnInit, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DetailComponent } from '../../_controls';
import { ActivatedRoute, Router } from '@angular/router';
import { Config } from 'datatables.net';
import { AuthenticationService } from '../../_services/authentication-service';

@Component({
  selector: 'app-customers-blacklist-orderdetails',
  templateUrl: './customers-blacklist-orderdetails.component.html'
})
export class CustomersBlackListOrderDetailComponent extends DetailComponent implements OnInit {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute, private router: Router) {
    super(Route);

  }
  public orderDetail: any = null;
  public orderDetailLineItems: any[] = null;
  public orderDetailAccountInfo: any = null;
  public orderDetailsShipInfo: any[] = null;
  public orderDetailBlacklistOrders: any[] = null;
  public orderDetailActionLogs: any[] = null;

  public featurelessTableOptions: Config = {
    paging: false,
    ordering: false,
    searching: false,
    info: false    
  }

  override GetData() {    
    this.http.get<any>(this.baseUrl + 'blacklist/GetOrderDetail/' + this.BusinessObjectId.toString()).subscribe(result => {
      this.orderDetail = result;

      this.http.get<any[]>(this.baseUrl + 'blacklist/GetOrderDetailLineItems/' + this.BusinessObjectId.toString()).subscribe(result => {
        this.orderDetailLineItems = result;
      }, error => console.error(error));
      this.http.get<any>(this.baseUrl + 'blacklist/GetOrderDetailAccountInfo/' + this.BusinessObjectId.toString()).subscribe(result => {
        this.orderDetailAccountInfo = result;
      }, error => console.error(error));
      this.http.get<any[]>(this.baseUrl + 'blacklist/GetOrderDetailShipInfo/' + this.BusinessObjectId.toString()).subscribe(result => {
        this.orderDetailsShipInfo = result;
      }, error => console.error(error));
      this.http.get<any[]>(this.baseUrl + 'blacklist/GetOrderDetailBlacklistOrders/' + this.BusinessObjectId.toString()).subscribe(result => {
        this.orderDetailBlacklistOrders = result;
      }, error => console.error(error));
      this.http.get<any[]>(this.baseUrl + 'blacklist/GetOrderDetailActionsLog/' + this.BusinessObjectId.toString()).subscribe(result => {
        this.orderDetailActionLogs = result;
      }, error => console.error(error));
    }, error => console.error(error));
  }

  public getBoxedText() {
    var result : string = '';

    if (this.orderDetailsShipInfo != null) {
      for (var i = 0; i < this.orderDetailsShipInfo.length; i++) {
        result += this.orderDetailsShipInfo[i].Username + ' ';
      }
    }

    return result;
  }

  public removeFromFraudList() {
    alert('Are you sure you want to remove this order from fraud list?');
  }

  public openOrderDetailsPopup(orderId: number) {
    const url = this.router.serializeUrl(
      this.router.createUrlTree(['/customers-blacklist-orderdetails', orderId])
    );
    window.open(url, "_blank", "config='toolbar=no, menubar=no'");
  }
}
