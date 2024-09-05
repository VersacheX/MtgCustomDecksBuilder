import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-existing-combo-modal',
  templateUrl: './existing-combo-modal.component.html',
  styleUrls: ['./existing-combo-modal.component.css']
})
export class ExistingComboModalComponent {
  constructor(
    public dialogRef: MatDialogRef<ExistingComboModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { combos: any[] }
  ) { }
}
