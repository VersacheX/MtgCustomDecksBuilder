import { Component, OnInit, Input, Inject, ViewChild, ElementRef, Output, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs/operators';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-card-search-dropdown',
  templateUrl: './card-search-dropdown.component.html',
  styleUrls: ['./card-search-dropdown.component.css']
})
export class CardSearchDropdownComponent implements OnInit {
  @Input() ColorIdentity: string;
  @Input() Homebrew: any;
  @Input() DeckList: any[];
  @Output() cardSelected = new EventEmitter<any>();

  cards: any[] = [];
  searchControl = new FormControl();

  @ViewChild('cardList', { static: false }) cardList: ElementRef;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.searchControl.valueChanges.pipe(
      debounceTime(750),  // Wait for 750ms pause in events
      distinctUntilChanged(),  // Only emit if value is different from previous value
      switchMap(value => value ? this.searchCards(value) : [])  // Switch to new observable on each new value
    ).subscribe(cards => {
      this.cards = cards;
      //this.adjustListWidth();
    });
  }

  onSearch(event: Event) {
    const inputElement = event.target as HTMLInputElement;
    const value = inputElement.value;
    this.searchControl.setValue(value);
    if (!value) {
      this.cards = [];  // Clear the list if the input is empty
    }
  }

  searchCards(query: string) {
    return this.http.post<any[]>(this.baseUrl + 'mtgcard/GetDropdownSuggestions', {
      Homebrew: this.Homebrew,
      IgnoredCardList: this.DeckList,
      ColorIdentity: this.ColorIdentity,
      Query: query
    });
  }

  onCardSelected(card: any) {
    console.log('Selected card:', card);
    this.cardSelected.emit(card);  // Emit the selected card
    this.searchControl.setValue('');  // Clear the input
    this.cards = [];  // Clear the list
  }

  //adjustListWidth() {
  //  if (this.cardList && this.cardList.nativeElement) {
  //    const longestName = this.cards.reduce((max, card) => card.Name.length > max.length ? card.Name : max, '');
  //    this.cardList.nativeElement.style.width = `${longestName.length}ch`;
  //  }
  //}
}
