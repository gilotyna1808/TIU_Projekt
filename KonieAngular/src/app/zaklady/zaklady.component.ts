import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Kon } from '../kon/kon.component';
import { KonieService } from '../konie.service';
import { ZakladService } from '../zaklad.service';
import { ZakladDto } from '../zaklad/zaklad.component';

@Component({
  selector: 'app-zaklady',
  templateUrl: './zaklady.component.html',
  styleUrls: ['./zaklady.component.css']
})
export class ZakladyComponent implements OnInit {
  zaklady:ZakladDto[]=[];
  konie:Kon[]=[]

  constructor(private router: Router, private zakladyService:ZakladService, private konieService:KonieService) { }

  ngOnInit(): void {
    this.konieService.pobierzKonie().subscribe(res=>this.konie=res);
    this.zakladyService.pobierzZaklady().subscribe(res=>this.zaklady=res);
    console.log(this.zaklady);
  }



}
