import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

import { DataTablesModule } from "angular-datatables";
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { AuthGuard, JwtInterceptor } from './_helpers';

import { AppComponent } from './app.component';
import {
  LayoutComponent,
  PopupLayoutComponent,
  NavMenuComponent,
  HeaderBarComponent} from './layout';

import {
  LoginComponent
} from './user-account';

import { HomeComponent } from './pages/home/home.component';
import { CounterComponent } from './pages/counter/counter.component';
import { FetchDataComponent } from './pages/fetch-data/fetch-data.component';

import { CustomersFraudListComponent, CustomersBlackListOrderDetailComponent } from './pages/customers';
import { OrdersComponent } from './pages/orders';



@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    PopupLayoutComponent,
    NavMenuComponent,
    HeaderBarComponent,

    LoginComponent,

    HomeComponent,
    CounterComponent,
    FetchDataComponent,

    CustomersFraudListComponent,
    CustomersBlackListOrderDetailComponent,
    OrdersComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,

    DataTablesModule,
    BsDatepickerModule,

    RouterModule.forRoot([
      {
        path: '', component: LayoutComponent,
        children: [
          { path: 'login', component: LoginComponent },

          { path: '', component: HomeComponent, pathMatch: 'full', canActivate: [AuthGuard] },
          { path: 'counter', component: CounterComponent, canActivate: [AuthGuard] },
          { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthGuard] },

          { path: 'customers-fraud-list', component: CustomersFraudListComponent, canActivate: [AuthGuard] },

          { path: 'orders', component: OrdersComponent, canActivate: [AuthGuard] },
        ]
      },
      {
        path: '', component: PopupLayoutComponent,
        children: [
          { path: 'customers-blacklist-orderdetails/:id', component: CustomersBlackListOrderDetailComponent, canActivate: [AuthGuard] }
        ]
      }      
    ])
  ],
  providers: [
    provideHttpClient(
      withInterceptorsFromDi()
    ),
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
