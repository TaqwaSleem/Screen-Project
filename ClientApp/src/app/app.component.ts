import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public events: any[];  public interval = 100000;  swappingTime;  selectedEventIndex = 0;  selectedEvent: any;  selectedbackground;  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {    this.GetEventt(http, baseUrl);    this.Reload(http, baseUrl);    this.GetDefulatImg(http, baseUrl);    this.GetSwappingTime(http, baseUrl)  }  GetEventt(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {    http.get<any[]>(baseUrl + 'api/Event/GetAnnualMonthlyDailyAndOnce').subscribe(result => {      this.events = result;      if (this.events.length == 0) {        this.GetDefulatImg(http, baseUrl);        console.log("oooooooooooo");        console.log(this.selectedbackground);      } else {        this.selectedEvent = this.events[this.selectedEventIndex];        this.selectedbackground = this.selectedEvent.myTemplate.backGroundImg;        console.log(this.events);        this.Swap();      }    }, error => console.error(error)    );  }  GetSwappingTime(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {    http.get<object[]>(baseUrl + 'api/AppSetting/SwappingTime').subscribe(result => {      this.swappingTime = result;      console.log(result);    }, error => console.error(error)    );  }  GetDefulatImg(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {    http.get(baseUrl + 'api/AppSetting/DefulatImg', { responseType: 'text' }).subscribe(result => {      this.selectedbackground = result;      console.log("hhhhhhhhhhhhhhhhhhhhhhhhh");      console.log(result);    }, error => console.error(error)    );  }  Reload(http: HttpClient, @Inject('BASE_URL') baseUrl: string): void {    setInterval(() => {      this.GetEventt(http, baseUrl);    }, this.interval);  }  Swap(): void {    setInterval(() => {      this.selectedEventIndex = (this.selectedEventIndex + 1) % this.events.length;      this.selectedEvent = this.events[this.selectedEventIndex];    }, this.swappingTime);  }}

