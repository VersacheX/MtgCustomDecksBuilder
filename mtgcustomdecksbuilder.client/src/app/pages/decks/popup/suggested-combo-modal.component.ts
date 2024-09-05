import { Component, EventEmitter, Inject, Output } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-suggested-combo-modal',
  templateUrl: './suggested-combo-modal.component.html',
  styleUrls: ['./suggested-combo-modal.component.css']
})
export class SuggestedComboModalComponent {
  @Output() cardSelected = new EventEmitter<any>();

  constructor(
    public dialogRef: MatDialogRef<SuggestedComboModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { combos: any[], deckList: any[] }
  ) { }

  selectCard(card: any) {
    this.data.deckList.push(card);
    this.cardSelected.emit(card);
  }

  isCardInDeckList(card: any): boolean {
    return this.data.deckList.some(deckCard => deckCard.Name === card.Name);
  }
}
