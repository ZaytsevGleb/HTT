import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from "@angular/common/http";
import { AppComponent } from './app.component';

import {HttApiClient, API_BASE_URL} from "./client/htt-api.client";
import {ProductsModule} from "./pages/products/products.module";
import {environment} from "../environments/environment";


@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    ProductsModule,
    HttpClientModule
  ],
  providers: [
    HttApiClient,
    { provide: API_BASE_URL, useValue: environment.apiUrl }],
  bootstrap: [AppComponent]
})
export class AppModule { }
