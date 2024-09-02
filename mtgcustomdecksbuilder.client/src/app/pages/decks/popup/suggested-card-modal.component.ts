import { Component, Inject, EventEmitter, Output } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-suggested-card-modal',
  templateUrl: './suggested-card-modal.component.html',
  styleUrls: ['./suggested-card-modal.component.css']
})
export class SuggestedCardModalComponent {
  @Output() cardSelected = new EventEmitter<any>();

  constructor(
    public dialogRef: MatDialogRef<SuggestedCardModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { cards: any[] }
  ) { }

  selectCard(card: any) {
    const index = this.data.cards.indexOf(card);
    if (index > -1) {
      const updatedData = this.data.cards.slice();
      updatedData.splice(index, 1);
      this.data.cards = updatedData;
      this.cardSelected.emit(card);
    }
  }
}
