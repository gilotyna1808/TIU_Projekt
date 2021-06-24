import { Component, OnInit } from '@angular/core';
import { AutoryzacjaService } from '../autoryzacja.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  constructor(private autoryzacjaService:AutoryzacjaService) { }

  ngOnInit(): void {
  }


  wyloguj(){
      this.autoryzacjaService.wyloguj();
  }

}
