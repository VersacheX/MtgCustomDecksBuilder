
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DataTablesModule } from "angular-datatables";
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { ModalModule, BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ComponentLoaderFactory } from 'ngx-bootstrap/component-loader';

import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatOptionModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { MatSortModule } from '@angular/material/sort';
import { MatMenuModule } from '@angular/material/menu';

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
import { ImportDeckComponent } from './pages/import/import-deck.component';
import { DeckBuilderComponent } from './pages/decks/deck-builder.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { CardDetailsDialog } from './pages/decks/card-detail-dialog.component';
import { SuggestedCardModalComponent } from './pages/decks/popup/suggested-card-modal.component';
import { CardImageHoverPopupDirective } from './_directives/CardImageHoverPopupDirective';
import { CardSearchDropdownComponent } from './_controls/pageControls/card-search-dropdown.component';
import { ManaFontPipe } from './_pipes/mana-font.pipe';





@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    PopupLayoutComponent,
    NavMenuComponent,
    HeaderBarComponent,

    CardImageHoverPopupDirective,
    CardSearchDropdownComponent,
    ManaFontPipe,

    LoginComponent,

    HomeComponent,
    SearchCardsComponent,
    SetSearchComponent,
    DownloadMtgDataComponent,

    HomebrewsComponent,
    EditHomebrewComponent,
    ImportDeckComponent,
    DeckBuilderComponent,
    CardDetailsDialog,
    SuggestedCardModalComponent 
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule, 

    MatTableModule,
    MatDialogModule,
    MatPaginatorModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatOptionModule,
    MatSortModule,
    MatMenuModule,

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

          { path: 'homebrews', component: HomebrewsComponent, canActivate: [AuthGuard] },
          { path: 'import-deck', component: ImportDeckComponent, canActivate: [AuthGuard] },
          { path: 'deck-builder', component: DeckBuilderComponent, canActivate: [AuthGuard] }
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
  exports: [
    ManaFontPipe,
  ],
  providers: [
    provideHttpClient(
      withInterceptorsFromDi()
    ),
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    BsModalRef,
    BsModalService,
    ComponentLoaderFactory,
    provideAnimationsAsync() 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
