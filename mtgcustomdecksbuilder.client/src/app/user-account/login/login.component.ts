import { Component, Inject, OnInit } from '@angular/core';
import { LoginInformation } from '../../_dataObjects/login-information';
import { first } from 'rxjs/operators';

import { AuthenticationService } from '../../_services';
import { DataService } from '../../_services/data-service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit  {
  public LoginInformation: LoginInformation;

  constructor(private _router: Router,
              @Inject(AuthenticationService) private _authenticationService: AuthenticationService) {
  }

  ngOnInit() {
    this.CreateData();
  }

  private CreateData() {
    this.LoginInformation = new LoginInformation();
  }

  Login() {
    this._authenticationService.Login(this.LoginInformation)
      .pipe(first())
      .subscribe(
        data => {
          this._router.navigate(['/']);
        },
        error => {

        });
  }
}
