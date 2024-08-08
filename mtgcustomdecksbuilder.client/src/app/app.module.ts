import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

import { DataTablesModule } from "angular-datatables";
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { ModalModule, BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ComponentLoaderFactory } from 'ngx-bootstrap/component-loader';

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

import { SearchCardsComponent } from './pages/search-cards/search-cards.component';
import { SetSearchComponent } from './pages/search-sets/search-sets.component';
import { DownloadMtgDataComponent } from './pages/download-mtg-data/download-mtg-data.component';
import { HomebrewsComponent } from './pages/homebrew/homebrews.component';
import { EditHomebrewComponent } from './pages/homebrew/popup/edit-homebrew.component';



@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    PopupLayoutComponent,
    NavMenuComponent,
    HeaderBarComponent,

    LoginComponent,

    HomeComponent,
    SearchCardsComponent,
    SetSearchComponent,
    DownloadMtgDataComponent,

    HomebrewsComponent,
    EditHomebrewComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,

    DataTablesModule,
    BsDatepickerModule,
    ModalModule,

    RouterModule.forRoot([
      {
        path: '', component: LayoutComponent,
        children: [
          { path: 'login', component: LoginComponent },

          { path: '', component: HomeComponent, pathMatch: 'full', canActivate: [AuthGuard] },
          { path: 'search-cards', component: SearchCardsComponent, canActivate: [AuthGuard] },
          { path: 'search-sets', component: SetSearchComponent, canActivate: [AuthGuard] },
          { path: 'download-mtg-data', component: DownloadMtgDataComponent, canActivate: [AuthGuard] },

          { path: 'homebrews', component: HomebrewsComponent, canActivate: [AuthGuard] }
        ]
      },
      {
        path: '', component: PopupLayoutComponent,
        children: [
          { path: 'edit-homebrew/:id', component: EditHomebrewComponent, canActivate: [AuthGuard] }
        ]
      }      
    ])
  ],
  providers: [
    provideHttpClient(
      withInterceptorsFromDi()
    ),
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    BsModalRef,
    BsModalService,
    ComponentLoaderFactory 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
