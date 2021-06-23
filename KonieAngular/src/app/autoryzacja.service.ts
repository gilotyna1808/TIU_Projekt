import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import {catchError, map} from 'rxjs/operators';

export interface Login{
  iD_Autoryzacja:number;
  login:string;
  password:string;
  rola:string;
}

export interface LoginRes{
  token:string;
  rola:string;
  id:number
}

@Injectable({
  providedIn: 'root'
})
export class AutoryzacjaService {

  constructor(private http:HttpClient) { }

pobierzZalogowanegoUzytkownika():LoginRes{
  let loginres=JSON.parse(sessionStorage.getItem('uzytkownik')) as LoginRes;
  console.log(loginres);
  return loginres;
}

login(login:Login):Observable<boolean>{
  return this.http.post<LoginRes>('https://localhost:44350/api/Logowanie',login).pipe(map(res=>{
      sessionStorage.setItem('uzytkownik',JSON.stringify(res));
      return true;
  }), catchError(error=>{
    return of(false);
  }));
}



wyloguj(){
  sessionStorage.removeItem('uzytkownik');
}
}
