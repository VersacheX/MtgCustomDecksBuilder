import { Inject, Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';


import { LoginInformation, User } from '../_dataObjects';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
  private _userSubject: BehaviorSubject<User>;
  public User: Observable<User>;

  constructor(private _router: Router, private http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) {
    var username = localStorage.getItem('user') ?? '';

    this._userSubject = new BehaviorSubject<User>(username.length > 0 ? JSON.parse(username) : new User());
    this.User = this._userSubject.asObservable();    
  }

  public get UserValue() {
    return JSON.parse(JSON.stringify(this._userSubject.value));
  }

  public get IsLoggedIn(): boolean {
    const currentUser = JSON.parse(JSON.stringify(this.UserValue));

    return currentUser != null && currentUser.AuthData?.length > 0;
  }

  public get CurrentUserId(): number {
    const currentUser = JSON.parse(JSON.stringify(this.UserValue));

    return currentUser != null ? currentUser.Id : 0;
  }



  Login(loginInfo: LoginInformation) {
    let reqHeaders = new HttpHeaders().set('Content-Type', 'application/json');
    return this.http.post<User>(this._baseUrl + 'Authorization/Authenticate', JSON.stringify(loginInfo), { headers: reqHeaders })
      .pipe(map(user => {
        // store user details and jwt token in local storage to keep user logged in between page refreshes
        localStorage.setItem('user', JSON.stringify(user));
        this._userSubject.next(user);
        return user;
      }));
  }

  LogOut() {
    // remove user from local storage to log user out
    localStorage.removeItem('user');
    this._userSubject.next(null);
    this._router.navigate(['/login']);
  }
}
