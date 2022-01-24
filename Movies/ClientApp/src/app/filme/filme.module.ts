import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { FilmeRoutingModule } from './filme-routing.module';
import { FilmeComponent } from './filme.component';
import { FilmComponent } from './film/film.component';
import { FormatAnPipe } from './film/format-an.pipe';
import { MovieRowDirective } from './movie-row.directive';
import { FilmeFiltruComponent } from './filme-filtru/filme-filtru.component';
import {FormsModule} from '@angular/forms';

const routes: Routes = [
  { path: '', component: FilmeComponent }
];

@NgModule({
  declarations: [FilmeComponent, FilmComponent, FormatAnPipe, MovieRowDirective, FilmeFiltruComponent],
  imports: [
    CommonModule,
    FilmeRoutingModule,
    RouterModule.forChild(routes),
    FormsModule
  ]
})
export class FilmeModule { }
