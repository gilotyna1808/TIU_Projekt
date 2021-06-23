import { Component, Input, OnInit } from '@angular/core';
import { NumberValueAccessor } from '@angular/forms';
import { Router } from '@angular/router';
import { KonieService } from '../konie.service';

export interface Kon{
  id:number;
  nazwa: string;
  wiek:number;
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

  constructor( private konieService:KonieService, private router: Router) { }

  ngOnInit(): void {
  }

przejdzDoEdycji(k:Kon){
this.konieService.edytujKonia(k)
}

}
