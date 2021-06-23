import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Kon } from '../kon/kon.component';
import { KonieService } from '../konie.service';

export interface ZakladDto{
  iD_Zakladu:	number;
  klientID:	number;
  wyscigID:	number;
  konWybranyID:	number;
  kwotaZakladu:	number;
  kurs:	number;
  wygrany?:	boolean;
  wyplacony:	boolean;
}

@Component({
  selector: 'app-zaklad',
  templateUrl: './zaklad.component.html',
  styleUrls: ['./zaklad.component.css']
})
export class ZakladComponent implements OnInit {
  @Input() zaklad:ZakladDto;
  @Input() kon:Kon[];
  constructor( private konieService:KonieService, private router: Router) { }

  ngOnInit(): void {
  }

  pobierzNazweKonia(i:number): string{
    return this.kon[this.kon.findIndex(x=>x.iD_Konia == i)].nazwa;
  }


}
