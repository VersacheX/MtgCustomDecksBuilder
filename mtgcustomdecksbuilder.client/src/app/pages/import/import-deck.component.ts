import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { DetailComponent } from '../../_controls/detail-component.component';

@Component({
  selector: 'app-import-deck',
  templateUrl: './import-deck.component.html'
})
export class ImportDeckComponent extends DetailComponent implements OnInit {
  public deckImportData: any = {};
  public mtgCards: any;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, public Route: ActivatedRoute) {
    super(Route);
  }

  ImportDeck() {
    this.http.post<any[]>(this.baseUrl + 'decks/Import', this.deckImportData).subscribe(result => {
      this.mtgCards = result;

      if (this.mtgCards && this.mtgCards.length > 0)
        console.log(this.mtgCards[0]);

    }, error => console.error(error));
  }
}
