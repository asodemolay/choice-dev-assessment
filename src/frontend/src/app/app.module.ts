import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UcsListComponent } from './ucs-list/ucs-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';

//import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { DxDataGridModule } from 'devextreme-angular';

@NgModule({
  declarations: [
    AppComponent,
    UcsListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatToolbarModule,
    MatListModule,
    DxDataGridModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
