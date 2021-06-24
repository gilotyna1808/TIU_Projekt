import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AutoryzacjaService } from './autoryzacja.service';

@Injectable({
  providedIn: 'root'
})
export class AutoryzacjaGuard implements CanActivate {

  constructor(private logowanieService:AutoryzacjaService, private router:Router){}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean
    {
        const user = this.logowanieService.pobierzZalogowanegoUzytkownika();
        if(user == null)this.router.navigateByUrl("logowanie");
        else
        {
          if(route.data?.dozwolonaRola != null){
            if(user.rola=="user")this.router.navigateByUrl("");
            return route.data.dozwolonaRola == user.rola;
          }
        }
        return user !=null;
    }
}

