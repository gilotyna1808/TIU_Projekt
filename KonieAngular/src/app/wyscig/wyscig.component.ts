import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { element } from 'protractor';
import { Kon } from '../kon/kon.component';
import { KonieService } from '../konie.service';

export class WyscigDTO{
  iD_Wyscigu:	number;
  dateTime:	string;
  zakonczony:	boolean;
  wygrany:	number;
  kon1:	number;
  kon2:	number;
  kon3:	number;
  kon4:	number;
  kon5:	number;
  kursKon1:	number;
  kursKon2:	number;
  kursKon3:	number;
  kursKon4:	number;
  kursKon5:	number;
}

@Component({
  selector: 'app-wyscig',
  templateUrl: './wyscig.component.html',
  styleUrls: ['./wyscig.component.css']
})

export class WyscigComponent implements OnInit {
  @Input() wyscig:WyscigDTO;
  @Input() kon:Kon[];
  constructor( private konieService:KonieService, private router: Router) { 
  }

  ngOnInit(): void {
  }

  pobierzNazweKonia(i:number): string{
    //this.konieService.pobierzKonia(1).subscribe();
    //console.log(this.kon);
    //console.log(this.kon.findIndex(x=>x.iD_Konia = 1));
    return this.kon[this.kon.findIndex(x=>x.iD_Konia == i)].nazwa;
  }


}
