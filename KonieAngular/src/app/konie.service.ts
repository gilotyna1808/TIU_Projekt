import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { getLocaleWeekEndRange } from '@angular/common';
import { Observable } from 'rxjs';
import {Kon} from './kon/kon.component';
import { AutoryzacjaService } from './autoryzacja.service';
@Injectable({
  providedIn: 'root'
})
export class KonieService {

  constructor(private http:HttpClient, private autoryzacjaService:AutoryzacjaService) { }

  pobierzKonie():Observable<Kon[]>{
    return this.http.get<Kon[]>('https://localhost:44350/api/Kon',{headers:this.dolaczNaglowki()});
  }

  pobierzKonia(id:number):Observable<Kon>{
    return this.http.get<Kon>('https://localhost:44350/api/Kon/'+id,{headers:this.dolaczNaglowki()});
  }

  dodajKonia(kon:Kon):Observable<Kon>{
    return this.http.post<Kon>('https://localhost:44350/api/Kon',kon,{headers:this.dolaczNaglowki()});
  }
  edytujKonia(kon:Kon):Observable<Kon>{
    return this.http.put<Kon>('https://localhost:44350/api/Kon',kon,{headers:this.dolaczNaglowki()});
  }

  private dolaczNaglowki():HttpHeaders{
    return new HttpHeaders().set("Authorization","Bearer "+this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
  }
}


