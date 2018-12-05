import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CarDetailComponent } from './car-detail/car-detail.component';
import { BrowseCarsComponent } from './browse-cars/browse-cars.component';
import { CarService } from './car.service';

import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterceptor } from './auth.interceptor';

import {
  OktaAuthModule,
  OktaCallbackComponent,
} from '@okta/okta-angular';





const config = {
  issuer: 'https://dev-990736.oktapreview.com/oauth2/default',
  redirectUri: 'http://localhost:44328/implicit/callback',
  clientId: '0oai38cztqPpRVAIH0h7',
  scope: 'openid profile email'
};

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CarDetailComponent,
    BrowseCarsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'Home', component: HomeComponent }, 
      { path: 'BrowseCarInfo', component: BrowseCarsComponent },
      { path: 'CustomCarList', component: FetchDataComponent },
      { path: 'Account', component: FetchDataComponent },
      { path: 'detail/:id', component: CarDetailComponent },
      { path: 'implicit/callback', component: OktaCallbackComponent }
      
    ]),

    OktaAuthModule.initAuth(config)
  ],
  
  providers: [CarService, 
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true }
  ],
  bootstrap: [AppComponent],
})


export class AppModule { }
