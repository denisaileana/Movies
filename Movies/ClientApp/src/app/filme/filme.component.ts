import { Component, OnInit } from '@angular/core';
import {Movie, MoviesService} from './movies.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: ['./filme.component.css']
})
export class FilmeComponent implements OnInit {
  movies: Movie[] = [];
  moviesFiltered: Movie[] = [];
  filtru = 'alba';


  constructor(private moviesService: MoviesService, private router: Router) {

  }

  ngOnInit() {
    this.moviesService.getMovies().subscribe(movies => {
       this.movies = movies;
       this.filtreaza();
    });
  }

  doFilter(filtru: string) {
    this.filtru = filtru;
    this.filtreaza();
  }

  private filtreaza() {
    this.moviesFiltered = this.movies.filter(m => m.title.toLowerCase().includes(this.filtru.toLowerCase()));
  }
}
