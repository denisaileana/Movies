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

  constructor(private moviesService: MoviesService, private router: Router) {

  }

  ngOnInit() {
    this.moviesService.getMovies().subscribe(movies => this.movies = movies);
  }
}
