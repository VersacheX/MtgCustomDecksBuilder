import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ListComponent } from '../../_controls';
import { Router } from "@angular/router";

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html'
})
export class OrdersComponent extends ListComponent implements OnInit {
  public storefrontInfo: any = null;
  public carriers: any = null;
  public orders: any = null;

  public searchCriteria: any = {};
  public orderTotal: number = 0; 
  public invoiceTotal: number = 0;
  public prodTotal: number = 0;
  public taxTotal: number = 0;
  public shippingTotal: number = 0;


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router) {
      super();
  }

  override Load() {
    this.LoadControlsData();
    this.LoadData();
  }

  LoadData() {
    this.http.get<any>(this.baseUrl + 'storefrontinfo/GetStorefrontInfo').subscribe(result => {
      this.storefrontInfo = result;



    }, error => console.error(error));
  }

  clickButton() {
    console.log(this.searchCriteria);
  }

  search() {
    if (this.validateSearchData())
    {
      this.correctSearchData();
      this.searchData();
    }
  }

  validateSearchData() {
    return true;
  }

  correctSearchData() {
    if (this.searchCriteria.DateFrom == undefined)
      this.searchCriteria.DateFrom = new Date(1900, 0, 1);

    if (this.searchCriteria.DateTo == undefined)
      this.searchCriteria.DateTo = new Date();
  }

  searchData() {
    console.log(this.searchCriteria);
    this.http.post<any>(this.baseUrl + 'orders/GetOrdersByCriteria', this.searchCriteria).subscribe(result => {
      this.orders = result;
      this.calculateTotals();


    }, error => console.error(error));
  }

  override LoadControlsData() {
    this.http.get<any>(this.baseUrl + 'carriers/GetCarrierList').subscribe(result => {
      this.carriers = result;



    }, error => console.error(error));

  }



  calculateTotals() {
    this.orderTotal = this.orders.length;
    this.invoiceTotal = 0;
    this.prodTotal = 0;
    this.taxTotal = 0;
    this.shippingTotal = 0;

    for (let i = 0; i < this.orderTotal; i++) {
      let order = this.orders[i];
      this.invoiceTotal += order.OrderGrandTotal;
      this.prodTotal += order.PubPriceTot;
      this.taxTotal += order.SalesTaxAmount;
      this.shippingTotal += order.ShipAmount;
    }
  }

  public openOrderDetailsPopup(orderId: number) {
    const url = this.router.serializeUrl(
      this.router.createUrlTree(['/customers-blacklist-orderdetails', orderId])
    );
    window.open(url, "_blank", "config='toolbar=no, menubar=no'");
  }

  public displayWholesaleMarker(processingType: string) {
    let retVal = processingType;

    if (retVal == "1")
      retVal = "X";
    else
      retVal = "";

    return retVal;
  }

  public writeIfIsDate(date: any, output: string) {
    let retVal = "";
    if (date instanceof Date) {
      retVal = output;
    }
    return retVal;
  }
}
