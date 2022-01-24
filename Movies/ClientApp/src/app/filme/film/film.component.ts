import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {FilmService} from './film.service';

@Component({
  selector: 'app-film',
  templateUrl: './film.component.html',
  styleUrls: ['./film.component.css']
})
export class FilmComponent implements OnInit {
  movie: null | any = null;

  constructor(private route: ActivatedRoute, private filmService: FilmService) {
  }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.filmService.getFilm(id).subscribe(movie => this.movie = movie);
  }

}
