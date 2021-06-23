import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Kon } from '../kon/kon.component';
import { KonieService } from '../konie.service';
import { WyscigDTO } from '../wyscig/wyscig.component';
import { WyscigiService } from '../wyscigi.service';

@Component({
  selector: 'app-wyscigi',
  templateUrl: './wyscigi.component.html',
  styleUrls: ['./wyscigi.component.css']
})
export class WyscigiComponent implements OnInit {

  wyscigi:WyscigDTO[]=[]
  konie:Kon[]=[]

  constructor(private wyscigService:WyscigiService,private router: Router, private konieService:KonieService) { }

  ngOnInit(): void {
    this.wyscigService.pobierzWyscigi().subscribe(res=>this.wyscigi=res);
    this.konieService.pobierzKonie().subscribe(res=>this.konie=res);
    //this.wyscigService.pobierzWyscigi().subscribe(res=>console.log((this.wyscigi),res));
    //console.log(this.wyscigi);
  }

}
