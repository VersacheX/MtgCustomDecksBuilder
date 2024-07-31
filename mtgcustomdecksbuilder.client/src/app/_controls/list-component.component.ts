import { Component, OnInit } from '@angular/core';
import { BaseComponent } from './base-component.component';

@Component({
  selector: 'list-component',
  template: ''
})
export class ListComponent extends BaseComponent implements OnInit {
  constructor() {
      super();
  }

  override ngOnInit() {
    this.Load();
  }

  Load() {
    this.LoadControlsData();

    this.LoadDataGridsData();
  }

  LoadControlsData() {
  }

  LoadDataGridsData() {

  }
}
