import { HttpClient } from '@angular/common/http';
//import { Component } from '@angular/core';
import {Component, OnInit} from '@angular/core';
//import { constructor } from 'jasmine';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'client';
  weatherforecasts:any;


constructor(private http: HttpClient)
{

}
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
ngOnit():void
{
  this.http.get('http://localhost:5223/weatherforecast').subscribe(response => { this.weatherforecasts = response;})
  error => {console.log('Error!')}
  throw new console.error(("Method not Implemented"));
  
}

}