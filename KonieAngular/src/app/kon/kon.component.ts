import { Component, Input, OnInit } from '@angular/core';
import { NumberValueAccessor } from '@angular/forms';
import { Router } from '@angular/router';
import { KonieService } from '../konie.service';

export interface Kon{
  iD_Konia:number;
  nazwa: string;
  wiek:number;
  kraj:string;
  kondycja:number;
  predkosc:number;
}


@Component({
  selector: 'app-kon',
  templateUrl: './kon.component.html',
  styleUrls: ['./kon.component.css']
})
export class KonComponent implements OnInit {
  @Input() kon:Kon;
iD_Konia:number;

  constructor( private konieService:KonieService, private router: Router) { }

  ngOnInit(): void {
   
  }

przejdzDoEdycji(kon:Kon){
this.router.navigateByUrl("konie/"+kon.iD_Konia+'/konieEdycja');
}

}
