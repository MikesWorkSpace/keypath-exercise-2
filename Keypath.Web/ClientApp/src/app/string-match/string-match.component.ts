import { Component, OnInit, Inject } from '@angular/core';
import { ExampleItem } from '../models/example-item';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-string-match',
  templateUrl: './string-match.component.html',
  styleUrls: ['./string-match.component.css']

})
export class StringMatchComponent implements OnInit {
  public exampleItems: ExampleItem[];
  public http: HttpClient;
  public restApiBaseUrl: string;
  public error = false;
  public filter: string;
  public filterInfo: string;
  public newWord: string;

  constructor(http: HttpClient, @Inject('REST_API_BASE_URL') restApiBaseUrl: string) {
    this.http = http;
    this.restApiBaseUrl = restApiBaseUrl;
    this.filter = "";
  }

  ngOnInit() {
    this.http.get<ExampleItem[]>(this.restApiBaseUrl + 'ExampleItems')
      .subscribe(
        result => {
          this.loadResults(result);
        },
        error => {
          console.error(error);
          this.error = true;
        });
  }

  applyFilter() {
    this.http.get<ExampleItem[]>(this.restApiBaseUrl + 'ExampleItems?wordContains=' + encodeURIComponent(this.filter))
      .subscribe(
        result => {
          this.loadResults(result);
        },
        error => {
          console.error(error);
          this.error = true;
        });
  }

  clearFilter() {
    this.filter = "";
    this.applyFilter();
  }

  loadResults(exampleItems: ExampleItem[]) {
    this.exampleItems = exampleItems;
    this.filterInfo = "[Filter: ";
    if (this.filter.length > 0) {
      this.filterInfo += "'" + this.filter + "']"
    } else {
      this.filterInfo += "-----]"
    }
    this.filterInfo += " [Word Count: " + this.exampleItems.length.toString() + "]";
    console.log("retrieved ", this.exampleItems.length, " items from the database with filter: '" + this.filter + "'");

  }


  addWord() {

    const payload: any = {
      word: this.newWord,
      sortOrder: 0
    };


    const headers = { 'content-type': 'application/json' }

    this.http.post(
        this.restApiBaseUrl + 'ExampleItems',
        JSON.stringify(payload), { 'headers': headers })
      .subscribe(
        result => {
          console.log("Successfully added row");
          this.newWord = "";
          this.clearFilter();
        },
        error => {
          console.error(error);
          this.error = true;
        });
  }

}
