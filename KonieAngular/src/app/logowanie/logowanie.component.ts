import { nullSafeIsEquivalent } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AutoryzacjaService, Login } from '../autoryzacja.service';

@Component({
  selector: 'app-logowanie',
  templateUrl: './logowanie.component.html',
  styleUrls: ['./logowanie.component.css']
})
export class LogowanieComponent implements OnInit {

  login:Login ={
    iD_Autoryzacja:0,
    login:null,
    password:null,
    rola:""

  }

  blad:string;

  constructor(private autoryzacjaService: AutoryzacjaService, private router:Router) { }

  ngOnInit(): void {
  }

onSubmit(){
  this.autoryzacjaService.login(this.login).subscribe(res=>{
    if(res){
      this.router.navigateByUrl('');
      this.autoryzacjaService.pobierzZalogowanegoUzytkownika();
    }else{
      this.blad="Bledny login lub haslo";
    }
  })
}

}
