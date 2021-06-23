import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { KonComponent } from './kon/kon.component';
import { KonieComponent } from './konie/konie.component';
import { LogowanieComponent } from './logowanie/logowanie.component';
import { MenuComponent } from './menu/menu.component';
import { KonEdycjaComponent } from './kon-edycja/kon-edycja.component';
import { WyscigComponent } from './wyscig/wyscig.component';
import { WyscigiComponent } from './wyscigi/wyscigi.component';
import { WyscigiFormComponent } from './wyscigi-form/wyscigi-form.component';

@NgModule({
  declarations: [
    AppComponent,
    KonComponent,
    LogowanieComponent,
    KonieComponent,
    MenuComponent,
    KonEdycjaComponent,
    WyscigComponent,
    WyscigiComponent,
    WyscigiFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
