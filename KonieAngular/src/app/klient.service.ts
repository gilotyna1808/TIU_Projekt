import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AutoryzacjaService } from './autoryzacja.service';
import { KlientDTO } from './portfel/portfel.component';

@Injectable({
  providedIn: 'root'
})
export class KlientService {
  constructor(private http:HttpClient, private autoryzacjaService:AutoryzacjaService) { }

  pobierzKlientow():Observable<KlientDTO[]>{
    return this.http.get<KlientDTO[]>('https://localhost:44350/api/Klient',{headers:this.dolaczNaglowki()});
  }

  pobierzKlienta(id:number):Observable<KlientDTO>{
    return this.http.get<KlientDTO>('https://localhost:44350/api/Klient/'+id,{headers:this.dolaczNaglowki()});
  }

  dodajKlienta(kon:KlientDTO):Observable<KlientDTO>{
    return this.http.post<KlientDTO>('https://localhost:44350/api/Klient',kon,{headers:this.dolaczNaglowki()});
  }
  edytujKlienta(kon:KlientDTO):Observable<KlientDTO>{
    return this.http.put<KlientDTO>('https://localhost:44350/api/Klient',kon,{headers:this.dolaczNaglowki()});
  }

  private dolaczNaglowki():HttpHeaders{
    return new HttpHeaders().set("Authorization","Bearer "+this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
  }
}
