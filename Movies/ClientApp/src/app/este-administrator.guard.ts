import {Injectable} from '@angular/core';
import {CanLoad, Route, UrlSegment, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router} from '@angular/router';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {map, tap} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class EsteAdministratorGuard implements CanLoad {
  canLoad(
    route: Route,
    segments: UrlSegment[]): Observable<boolean> | Promise<boolean> | boolean {
    return this.httpClient.get<string[]>('/api/status').pipe(
      map(roluri => roluri.includes('Administrator')),
      tap(esteAdministator => {
        if (!esteAdministator) {
          this.router.navigate(['/']);
        }
      })
    );
  }

  constructor(private httpClient: HttpClient, private router: Router) {
  }
}
