//import { Component } from '@angular/core';

//@Component({
//  selector: 'app-root',
//  templateUrl: './app.component.html',
//  styleUrls: ['./app.component.css']
//})
//export class AppComponent {
//  title = 'app';
//}

import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']})
export class AppComponent {
  public events: any[];
  public interval = 1000000;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.GetEvents(http, baseUrl);
    this.Reload(http, baseUrl);

  }

  GetEvents(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/Event/GetAnnualMonthlyDailyAndOnce').subscribe(result => {
      this.events = result;
    }, error => console.error(error));
  }


  Reload(http: HttpClient, @Inject('BASE_URL') baseUrl: string): void {
    setInterval(() => {
      this.GetEvents(http, baseUrl);
    }, this.interval);

  }


}

