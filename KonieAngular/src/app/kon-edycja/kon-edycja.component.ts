import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup,Validators,FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Kon } from '../kon/kon.component';
import { KonieService } from '../konie.service';

@Component({
  selector: 'app-kon-edycja',
  templateUrl: './kon-edycja.component.html',
  styleUrls: ['./kon-edycja.component.css']
})
export class KonEdycjaComponent implements OnInit {
form:FormGroup;
iD_Konia:number;

  constructor(private route:ActivatedRoute,private fb:FormBuilder,private konieService:KonieService,private router:Router) { }

  ngOnInit(): void {
    
const iD_Konia=Number.parseInt(this.route.snapshot.paramMap.get('iD_Konia'));
if(iD_Konia>0){
  this.iD_Konia=iD_Konia;
  this.konieService.pobierzKonia(iD_Konia).subscribe(res=>this.utworzFormularz(res));
 
}
else{
  this.utworzFormularz(null);
}
  }

  private utworzFormularz(kon?: Kon){
    this.form=this.fb.group({
      iD_Konia:new FormControl(kon?.iD_Konia,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      nazwa: new FormControl(kon?.nazwa,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      wiek: new FormControl(kon?.wiek,[Validators.required,Validators.min(0), Validators.max(30)]),
      kraj: new FormControl(kon?.kraj,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      kondycja: new FormControl(kon?.kondycja,[Validators.max(100),Validators.min(0)]),
      predkosc: new FormControl(kon?.predkosc,[Validators.max(100),Validators.min(0)]),
    })
  }

  onSubmit(){
    if(this.iD_Konia>0){
      this.konieService.edytujKonia(this.form.value).subscribe(res=>this.router.navigateByUrl('konie'));
    }else{
      this.konieService.dodajKonia(this.form.value).subscribe(res=>this.router.navigateByUrl('konie'));
    }
  }

}
