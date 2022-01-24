import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FilmService {

  constructor(private httpClient: HttpClient) { }

  getFilm(id: number) {
    return this.httpClient.get(`/api/movies/${id}`);
  }
}
