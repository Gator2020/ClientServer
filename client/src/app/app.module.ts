import { NgModule } from '@angular/core';
import{ HttpClientModule }from'@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatCardModule} from '@angular/material/card';


import{BrowserAnimationsModule} from '@angular/platform-browser/animations';
@NgModule({
 declarations: [
    AppComponent
 ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule
    MatCardModule
 ],
  providers: [],
 bootstrap: [AppComponent]
})

export class AppModule { }
