import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { combineAll } from 'rxjs/operators';
import { AppComponent } from './app.component';
import { AutoryzacjaGuard } from './autoryzacja.guard';
import { KonEdycjaComponent } from './kon-edycja/kon-edycja.component';
import { KonComponent } from './kon/kon.component';
import { KonieComponent } from './konie/konie.component';
import { LogowanieComponent } from './logowanie/logowanie.component';
import { MenuComponent } from './menu/menu.component';
import { RejestracjaComponent } from './rejestracja/rejestracja.component';
import { WyscigComponent } from './wyscig/wyscig.component';
import { WyscigiFormComponent } from './wyscigi-form/wyscigi-form.component';
import { WyscigiComponent } from './wyscigi/wyscigi.component';
import { ZakladyFormComponent } from './zaklady-form/zaklady-form.component';
import { ZakladyComponent } from './zaklady/zaklady.component';

const routes: Routes = [
  {path:'',component:MenuComponent,canActivate:[AutoryzacjaGuard]},
  {path:'logowanie',component:LogowanieComponent},
  {path:'konie',children:[
    {path:'',component:KonieComponent,canActivate:[AutoryzacjaGuard]},
    {path:':iD_Konia/konieEdycja',component:KonEdycjaComponent,canActivate:[AutoryzacjaGuard]}
  ]},
  {path:'wyscigi',children:[
    {path:'', component:WyscigiComponent,canActivate:[AutoryzacjaGuard]},
    {path:'dodaj',component:WyscigiFormComponent,canActivate:[AutoryzacjaGuard]},
    {path:'dodaj/:id',component:WyscigiFormComponent,canActivate:[AutoryzacjaGuard]}
  ]},
  {path:'zaklady',children:[
    {path: '', component:ZakladyComponent,canActivate:[AutoryzacjaGuard]},
    {path: 'dodaj', component:ZakladyFormComponent,canActivate:[AutoryzacjaGuard]},
    {path: 'dodaj/:id',component:ZakladyFormComponent,canActivate:[AutoryzacjaGuard]}
  ]},
  {path:'rejestracja',component:RejestracjaComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
