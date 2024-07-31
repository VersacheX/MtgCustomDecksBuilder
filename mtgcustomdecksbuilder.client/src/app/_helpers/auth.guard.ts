import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

import { AuthenticationService } from '../_services';
import { User } from '../_dataObjects';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
  constructor(
    private _router: Router,
    private _authenticationService: AuthenticationService
  ) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    let currentUser : User = this._authenticationService.UserValue;
    if (currentUser.authData?.length > 0) {
      // logged in so return true
      return true;
    }

    // not logged in so redirect to login page with the return url
    this._router.navigate(['/login']);//, { queryParams: { returnUrl: state.url } });
    return false;
  }
}
