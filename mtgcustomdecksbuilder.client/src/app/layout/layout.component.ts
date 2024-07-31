import { Component, ViewChild, OnInit } from '@angular/core';
import { NavMenuComponent } from '../layout/nav-menu/nav-menu.component';
import { AuthenticationService } from '../_services';

@Component({
  selector: 'layout-component',
  templateUrl: './layout.component.html',
  styleUrls: ['../app.component.css']
})
export class LayoutComponent implements OnInit {
  constructor(protected _authenticationService: AuthenticationService) { }

  @ViewChild(NavMenuComponent, { static: false }) protected _navigationMenu: NavMenuComponent;

  ngOnInit() {
  }
}
