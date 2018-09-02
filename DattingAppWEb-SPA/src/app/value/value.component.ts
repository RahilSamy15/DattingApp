import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { error } from 'util';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  Values: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.GetValues();
  }
  GetValues() {
    this.http.get('http://localhost:5000/api/values').subscribe(Response => {
      this.Values = Response;
    // tslint:disable-next-line:no-shadowed-variable
    }, error => {
      console.log(error);
    }
    );
  }
}

