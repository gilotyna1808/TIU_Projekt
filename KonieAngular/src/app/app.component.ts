import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AutoryzacjaService } from './autoryzacja.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'KonieAngular';

  constructor(private logSer:AutoryzacjaService,private router:Router){}

  Wyloguj(){
    console.log("wylogowanie");
    this.logSer.wyloguj();
    this.router.navigateByUrl("");
    window.location.reload();
  }
}


