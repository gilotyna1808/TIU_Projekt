import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormControlDirective, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AutoryzacjaService } from '../autoryzacja.service';
import { KlientService } from '../klient.service';
import { KonieService } from '../konie.service';
import { WyscigiService } from '../wyscigi.service';

export interface KlientDTO{
  iD_Klienta:	number;
  imie:	string;
  nazwisko:	string;
  wiek:	number;
  email:	string;
  stanKonta:number;
}

@Component({
  selector: 'app-portfel',
  templateUrl: './portfel.component.html',
  styleUrls: ['./portfel.component.css']
})
export class PortfelComponent implements OnInit {
  form:FormGroup;
  id:number=0;

  constructor(private authService:AutoryzacjaService,private formBuilder:FormBuilder, private klientServive:KlientService,private route:ActivatedRoute, private router:Router) { }

  ngOnInit(): void {
    const idTemp = this.authService.pobierzZalogowanegoUzytkownika().id;
    if(idTemp>0){
      this.id=idTemp;
      this.klientServive.pobierzKlienta(idTemp).subscribe(res => this.createForm(res))
    }else{
      this.createForm();
    }
  }

  private createForm(konto?:KlientDTO){
    this.form=this.formBuilder.group(
      {
        stanKonta: new FormControl(konto?.stanKonta),
      }
    )
  }


  onSubmit(){
    let w:KlientDTO;
    w=this.form.value;
    w.iD_Klienta=this.authService.pobierzZalogowanegoUzytkownika().id;
    console.log(w);
    //if(this.id==0)this.wyscigService.dodajWyscig(this.form.value).subscribe(res => console.log(res));
    if(this.id>0)this.klientServive.edytujKlienta(w).subscribe(res=> console.log(res));
    this.router.navigateByUrl('');
  }

}
