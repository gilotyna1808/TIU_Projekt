import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { KonComponent } from './kon/kon.component';
import { KonieComponent } from './konie/konie.component';
import { LogowanieComponent } from './logowanie/logowanie.component';
import { WyscigiFormComponent } from './wyscigi-form/wyscigi-form.component';
import { WyscigiComponent } from './wyscigi/wyscigi.component';

const routes: Routes = [
  {path:'',component:KonieComponent},
  {path:'logowanie',component:LogowanieComponent},
  {path:'wyscigi', children:[
    {path: '', component:WyscigiComponent},
    {path: 'dodaj', component:WyscigiFormComponent},
    {path: 'dodaj/:id', component:WyscigiFormComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
