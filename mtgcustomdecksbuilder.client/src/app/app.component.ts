import { Component, OnInit, Type } from '@angular/core';
import { AuthenticationService } from './_services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(protected _authenticationService: AuthenticationService) { }

  ngOnInit() {
  }
}
