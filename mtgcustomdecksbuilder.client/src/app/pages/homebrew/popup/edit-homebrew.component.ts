import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { MasterDetailComponent } from '../../../_controls/master-detail-component.component';

@Component({
  selector: 'app-edit-homebrew',
  templateUrl: './edit-homebrew.component.html'
})
export class EditHomebrewComponent extends MasterDetailComponent implements OnInit {
  public mtgSets: any[];
  public mtgSetsSearchResults: any[];

  public searchCriteria: any = {};

  public fromSetData: any[];
  public toSetData: any[];
  public setTypes: any[];
  public gameFormats: any[]; 

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute) {
    super(Route);
  }

  override LoadDataGridsData() {
    this.mtgSetsSearchResults = undefined;

    this.http.post<any[]>(this.baseUrl + 'mtgset/GetMtgSetsByCriteria', this.searchCriteria).subscribe(result => {
      this.mtgSetsSearchResults = result;

      if (this.mtgSetsSearchResults && this.mtgSetsSearchResults.length > 0)
        console.log(this.mtgSetsSearchResults[0]);

    }, error => console.error(error));
  }

  override LoadControlsData() {
    this.GetFormats();
    this.GetSetData();
    this.GetSetTypeData();
  }

  GetFormats() {
    this.http.get<any[]>(this.baseUrl + 'gameformat/GetAllGameFormats').subscribe(result => {
      this.gameFormats = result;
      //.sort((a: any, b: any) => {
      //  return new Date(a.name) > new Date(b.name) ? 1 : -1;
      //});

      //if (this.mtgSets && this.mtgSets.length > 0)
      //  console.log(this.mtgSets[0]);

    }, error => console.error(error));
  }

  GetSetTypeData() {
    this.http.get<any[]>(this.baseUrl + 'mtgset/GetMtgSetTypes').subscribe(result => {
      this.setTypes = result.sort((a: any, b: any) => {
        return new Date(a.name) > new Date(b.name) ? 1 : -1;
      });

      if (this.mtgSets && this.mtgSets.length > 0)
        console.log(this.mtgSets[0]);

    }, error => console.error(error));
  }

  GetSetData() {
    this.http.post<any[]>(this.baseUrl + 'mtgset/GetMtgSetsByCriteria', this.searchCriteria).subscribe(result => {
      this.mtgSets = this.OrderSetsByDate(result);
      this.toSetData = this.mtgSets;
      this.fromSetData = this.mtgSets;
      this.searchCriteria.SetFromDate = this.fromSetData[this.fromSetData.length - 1].releaseDate;
      this.searchCriteria.SetToDate = this.toSetData[0].releaseDate;

      console.log(this.mtgSets[0]);

    }, error => console.error(error));
  }

  OrderSetsByDate(sets: any[]) {
    sets.sort((a: any, b: any) => {
      return new Date(a.releaseDate) < new Date(b.releaseDate) ? 1 : -1;
    });
    return sets;
  }

  SetsFromChanged() {
    this.UpdateToSetData();
  }

  SetsToChanged() {
    this.UpdateFromSetData();
  }

  UpdateToSetData() {
    if (this.searchCriteria.SetFromDate)
      this.toSetData = this.mtgSets.filter(set => new Date(set.releaseDate) >= new Date(this.searchCriteria.SetFromDate));
    else
      this.toSetData = this.mtgSets;
  }

  UpdateFromSetData() {
    if (this.searchCriteria.SetToDate)
      this.fromSetData = this.mtgSets.filter(set => new Date(set.releaseDate) <= new Date(this.searchCriteria.SetToDate));
    else
      this.toSetData = this.mtgSets;
  }

  override SaveData() {
    this.http.post<any[]>(this.baseUrl + 'homebrew/Save', this.searchCriteria).subscribe(result => {
      //this.setTypes = result.sort((a: any, b: any) => {
      //  return new Date(a.name) > new Date(b.name) ? 1 : -1;
      //});

      //if (this.mtgSets && this.mtgSets.length > 0)
      //  console.log(this.mtgSets[0]);

    }, error => console.error(error));
  }

  legalitySelect_Changed() {
    //Get Gametype From gameTypes Gametype.name
    if (this.searchCriteria.Legality) {
      var gameType = this.gameFormats.filter(x => x.name == this.searchCriteria.Legality)[0];
      this.searchCriteria.LibraryCardCount = gameType.maxCardCount;
      this.searchCriteria.CommanderAllowed = gameType.commanderLegal;
      this.searchCriteria.CompanionAllowed = gameType.companionLegal;
      this.searchCriteria.SideboardCount = gameType.sideboardSize;
    }
  }
}
