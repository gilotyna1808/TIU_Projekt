import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { combineAll } from 'rxjs/operators';
import { AppComponent } from './app.component';
import { KonEdycjaComponent } from './kon-edycja/kon-edycja.component';
import { KonComponent } from './kon/kon.component';
import { KonieComponent } from './konie/konie.component';
import { LogowanieComponent } from './logowanie/logowanie.component';
import { MenuComponent } from './menu/menu.component';
import { WyscigComponent } from './wyscig/wyscig.component';
import { WyscigiFormComponent } from './wyscigi-form/wyscigi-form.component';
import { WyscigiComponent } from './wyscigi/wyscigi.component';
import { ZakladyFormComponent } from './zaklady-form/zaklady-form.component';
import { ZakladyComponent } from './zaklady/zaklady.component';

const routes: Routes = [
  {path:'',component:MenuComponent},
  {path:'logowanie',component:LogowanieComponent},
  {path:'konie',children:[
    {path:'',component:KonieComponent},
    {path:':iD_Konia/konieEdycja',component:KonEdycjaComponent}
  ]},
  {path:'wyscigi',children:[
    {path:'', component:WyscigiComponent},
    {path:'dodaj',component:WyscigiFormComponent},
    {path:'dodaj/:id',component:WyscigiFormComponent}
  ]},
  {path:'zaklady',children:[
    {path: '', component:ZakladyComponent},
    {path: 'dodaj', component:ZakladyFormComponent},
    {path: 'dodaj/:id',component:ZakladyFormComponent}
  ]}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
