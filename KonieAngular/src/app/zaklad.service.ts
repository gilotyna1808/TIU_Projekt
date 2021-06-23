import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AutoryzacjaService } from './autoryzacja.service';
import { ZakladDto } from './zaklad/zaklad.component';

@Injectable({
  providedIn: 'root'
})
export class ZakladService {

  constructor(private http:HttpClient, private autoryzacjaService:AutoryzacjaService) { }
  
  pobierzZaklady():Observable<ZakladDto[]>{
    return this.http.get<ZakladDto[]>('https://localhost:44350/api/Zaklad',{headers:this.dolaczNaglowki()});
  }

  pobierzZaklad(id:number):Observable<ZakladDto[]>{
    return this.http.get<ZakladDto[]>('https://localhost:44350/api/Zaklad/'+id,{headers:this.dolaczNaglowki()});
  }

  dodajZaklad(zaklad:ZakladDto):Observable<boolean>{
    return this.http.post<boolean>('https://localhost:44350/api/Zaklad',zaklad,{headers:this.dolaczNaglowki()});
  }
  edytujZaklad(zaklad:ZakladDto):Observable<boolean>{
    return this.http.put<boolean>('https://localhost:44350/api/Zaklad',zaklad,{headers:this.dolaczNaglowki()});
  }

  private dolaczNaglowki():HttpHeaders{
    return new HttpHeaders().set("Authorization","Bearer "+this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
  }
}
