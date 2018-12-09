import { Component, OnInit } from '@angular/core';
import { OktaAuthService } from '@okta/okta-angular';

import{ AuthService  } from './../auth/auth.service';
import { AuthInterceptor } from '../auth.interceptor';

// ...
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public joggingData: Array<any>;
  public currentJogging: any;
  public isAuthenticated: boolean;

  constructor ( public auth: AuthService) { 
    auth.handleAuthentication();

  }

  ngOnInit() {
    if (localStorage.getItem('isLoggedIn') === 'true') {
      this.auth.renewSession();
  }
}
}