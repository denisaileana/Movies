import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

export interface Movie {
  id: number;
  title: string;
  year: number;
}

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  constructor(private httpClient: HttpClient) {
  }

  getMovies() {
    return this.httpClient.get<Movie[]>('/api/movies');
  }
}
