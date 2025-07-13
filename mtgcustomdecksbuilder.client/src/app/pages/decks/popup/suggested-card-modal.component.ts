import { Component, Inject, EventEmitter, Output } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-suggested-card-modal',
  templateUrl: './suggested-card-modal.component.html',
  styleUrls: ['./suggested-card-modal.component.css']
})
export class SuggestedCardModalComponent {
  @Output() cardSelected = new EventEmitter<any>();
  public orderedGroups: Record<string, any[]>;

  public typeOrder = [
    'battle', 'planeswalker', 'creature', 'sorcery', 'instant',
    'artifact', 'enchantment', 'land'
  ];

  constructor(
    public dialogRef: MatDialogRef<SuggestedCardModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { cards: any[] }
  ) {
    this.setdeckListData(data.cards);
  }

  selectCard(card: any) {
    const index = this.data.cards.indexOf(card);
    if (index > -1) {
      const updatedData = this.data.cards.slice();
      updatedData.splice(index, 1);
      this.setdeckListData(updatedData);
      this.cardSelected.emit(card);
    }
  }

  setdeckListData(data) {
    this.data.cards = data;
    this.orderedGroups = this.groupAndOrderCardsByType(this.data.cards);
  }

  groupAndOrderCardsByType(cards: any[]): Record<string, any[]> {
    const groups: Record<string, any[]> = {};

    cards.forEach(card => {
      const types = card.Types.split(',').map(type => type.trim().toLowerCase());
      let primaryType = types[0];

      if (types.includes('land')) {
        primaryType = 'land';
      } else if (types.includes('creature')) {
        primaryType = 'creature';
      } else if (types.includes('artifact')) {
        primaryType = 'artifact';
      } else if (types.includes('battle')) {
        primaryType = 'battle';
      } else if (types.includes('planeswalker')) {
        primaryType = 'planeswalker';
      } else if (types.includes('sorcery')) {
        primaryType = 'sorcery';
      } else if (types.includes('instant')) {
        primaryType = 'instant';
      } else if (types.includes('enchantment')) {
        primaryType = 'enchantment';
      }

      if (!groups[primaryType]) {
        groups[primaryType] = [];
      }

      groups[primaryType].push(card);
    });

    // Sort the groups based on the specified order
    const orderedGroups: Record<string, any[]> = {};
    this.typeOrder.forEach(type => {
      if (groups[type]) {
        orderedGroups[type] = groups[type];
      }
    });

    // Add any remaining groups that are not in the specified order
    Object.keys(groups).forEach(type => {
      if (!orderedGroups[type]) {
        orderedGroups[type] = groups[type];
      }
    });

    return orderedGroups;
  }
}
