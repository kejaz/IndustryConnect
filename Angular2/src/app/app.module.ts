import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { EmplistComponent } from './employee/emplist.Component';

@NgModule({
    imports: [BrowserModule],
    declarations: [AppComponent, EmplistComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
