import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../_services';

@Component({
  selector: 'popup-layout-component',
  templateUrl: './popup-layout.component.html',
  styleUrls: ['../app.component.css']
})
export class PopupLayoutComponent implements OnInit {
  constructor(protected _authenticationService: AuthenticationService) { }

  ngOnInit() {
  }
}
