import { Component, OnInit, Type } from '@angular/core';
import { AuthenticationService } from './_services';
import { ModalService } from './_controls';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(protected _authenticationService: AuthenticationService,
    private modalService: ModalService) { }

  ngOnInit() {
  }

  openPopup(type: Type<unknown>) {
    this.modalService.open(type, null);
  }

  close() {
    this.modalService.close();
  }
}
