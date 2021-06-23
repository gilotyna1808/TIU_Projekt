import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AutoryzacjaService } from '../autoryzacja.service';
import { WyscigDTO } from '../wyscig/wyscig.component';
import { WyscigiService } from '../wyscigi.service';
import { ZakladService } from '../zaklad.service';
import { ZakladDto } from '../zaklad/zaklad.component';

@Component({
  selector: 'app-zaklady-form',
  templateUrl: './zaklady-form.component.html',
  styleUrls: ['./zaklady-form.component.css']
})
export class ZakladyFormComponent implements OnInit {
  form:FormGroup;
  id:number=0;

  constructor(private formBuilder:FormBuilder,private route:ActivatedRoute, private router:Router,
     private zakladyService:ZakladService, private wyscigService:WyscigiService, private autoryzacjaS:AutoryzacjaService) { }

  ngOnInit(): void {
      this.createForm();
  }

  private createForm(zaklad?:ZakladDto){
    this.form=this.formBuilder.group(
      {
        wyscigID: new FormControl(zaklad?.wyscigID),
        konWybranyID: new FormControl(zaklad?.konWybranyID),
        kwotaZakladu: new FormControl(zaklad?.kwotaZakladu),
      }
    )
  }


  onSubmit(){
    let z : ZakladDto;
    z=this.form.value;
    z.wyplacony=false;
    z.klientID=this.autoryzacjaS.pobierzZalogowanegoUzytkownika().id;
    console.log(z);
    if(this.id==0)this.zakladyService.dodajZaklad(z).subscribe(res => console.log(res));
    if(this.id>0)this.zakladyService.edytujZaklad(z).subscribe(res=> console.log(res));
    //this.router.navigateByUrl('wyscigi');
  }

}