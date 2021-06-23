import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AutoryzacjaService } from './autoryzacja.service';
import { WyscigDTO } from './wyscig/wyscig.component';

@Injectable({
  providedIn: 'root'
})
export class WyscigiService {

  constructor(private http:HttpClient, private autoryzacjaService:AutoryzacjaService) { }
  
  pobierzWyscigi():Observable<WyscigDTO[]>{
    return this.http.get<WyscigDTO[]>('https://localhost:44350/api/Wyscig',{headers:this.dolaczNaglowki()});
  }

  pobierzWyscig(id:number):Observable<WyscigDTO>{
    return this.http.get<WyscigDTO>('https://localhost:44350/api/Wyscig/'+id,{headers:this.dolaczNaglowki()});
  }

  dodajWyscig(wyscig:WyscigDTO):Observable<boolean>{
    return this.http.post<boolean>('https://localhost:44350/api/Wyscig',wyscig,{headers:this.dolaczNaglowki()});
  }
  edytujWyscig(wyscig:WyscigDTO):Observable<boolean>{
    return this.http.put<boolean>('https://localhost:44350/api/Wyscig',wyscig,{headers:this.dolaczNaglowki()});
  }

  private dolaczNaglowki():HttpHeaders{
    return new HttpHeaders().set("Authorization","Bearer "+this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
  }
}
