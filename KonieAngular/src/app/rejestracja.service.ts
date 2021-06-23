import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface Rejestracja{
  imie:string;
  nazwisko:string;
  wiek:number;
  email:string;
  stanKonta:number;
  login:string;
  password:string;
  rola:string;
}

@Injectable({
  providedIn: 'root'
})
export class RejestracjaService {

  constructor(private http:HttpClient) { }

  zarejestruj(rejestracja:Rejestracja):Observable<boolean>{
    return this.http.post<boolean>('https://localhost:44350/api/Rejestracja',rejestracja);
  }

}
