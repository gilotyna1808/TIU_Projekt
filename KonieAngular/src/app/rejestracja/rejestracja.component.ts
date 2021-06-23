import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Rejestracja, RejestracjaService } from '../rejestracja.service';

@Component({
  selector: 'app-rejestracja',
  templateUrl: './rejestracja.component.html',
  styleUrls: ['./rejestracja.component.css']
})
export class RejestracjaComponent implements OnInit {
form:FormGroup;


  constructor(private fb:FormBuilder, private rejestracjaService: RejestracjaService, private router: Router) { }

  ngOnInit(): void {
    this.utworzFormularz();
  }

  private utworzFormularz(rejestracja?: Rejestracja){
    this.form=this.fb.group({
      imie:new FormControl(rejestracja?.imie,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      nazwisko: new FormControl(rejestracja?.nazwisko,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      wiek: new FormControl(rejestracja?.wiek,[Validators.required,Validators.min(0), Validators.max(150)]),
      email: new FormControl(rejestracja?.email,[Validators.required,Validators.minLength(2), Validators.maxLength(100),Validators.email]),
      stanKonta: new FormControl(rejestracja?.stanKonta),
      login: new FormControl(rejestracja?.login,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      password:new FormControl(rejestracja?.password,[Validators.required,Validators.minLength(2), Validators.maxLength(100)]),
      rola:new FormControl({value: "user", disabled: true}, Validators.required)
    })
  }
  onSubmit(){
    this.rejestracjaService.zarejestruj(this.form.value).subscribe(res=>this.router.navigateByUrl('logowanie'));
  }
}
