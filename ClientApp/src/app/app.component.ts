import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public events: any[];
  public interval = 3600000;


  SwappingTime = 2000;        //swapp



  selectedEventIndex = 0;
  selectedEvent: any;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.GetEvents(http, baseUrl);
    this.Reload(http, baseUrl);

  }

  GetEvents(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/Event/GetAnnualMonthlyDailyAndOnce').subscribe(result => {
      this.events = result;

      this.selectedEvent = this.events[this.selectedEventIndex];
      this.Swap();

    }, error => console.error(error));
  }

  Reload(http: HttpClient, @Inject('BASE_URL') baseUrl: string): void {
    setInterval(() => {
      this.GetEvents(http, baseUrl);
    }, this.interval);

  }


  Swap(): void {

    setInterval(() => {
      this.selectedEventIndex = (this.selectedEventIndex + 1) % this.events.length;
      this.selectedEvent = this.events[this.selectedEventIndex];
    }, this.SwappingTime);


  }


  }




