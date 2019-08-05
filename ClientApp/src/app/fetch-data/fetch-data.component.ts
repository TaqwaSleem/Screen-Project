import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({    selector: 'app-fetch-data',
    templateUrl: './fetch-data.component.html',
  styleUrls: ['./fetch.component.css']})
export class FetchDataComponent {
  public events: any[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/Event/GetAnnualMonthlyDailyAndOnce').subscribe(result => {
      this.events = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  

}
