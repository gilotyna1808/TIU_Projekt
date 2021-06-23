import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Kon } from '../kon/kon.component';
import { KonieService } from '../konie.service';
import { WyscigDTO } from '../wyscig/wyscig.component';
import { WyscigiService } from '../wyscigi.service';

@Component({
  selector: 'app-konie',
  templateUrl: './konie.component.html',
  styleUrls: ['./konie.component.css']
})
export class KonieComponent implements OnInit {

konie:Kon[]=[];
  constructor(private konieService:KonieService, private router: Router) { }

  ngOnInit(): void {
    this.wyswietlKonie();
  }

  wyswietlKonie(){
    this.konieService.pobierzKonie().subscribe(res=>console.log(res));
  }

}
