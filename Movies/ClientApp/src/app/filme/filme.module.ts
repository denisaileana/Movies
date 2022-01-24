import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { FilmeRoutingModule } from './filme-routing.module';
import { FilmeComponent } from './filme.component';
import { FilmComponent } from './film/film.component';
import { FormatAnPipe } from './film/format-an.pipe';
import { MovieRowDirective } from './movie-row.directive';

const routes: Routes = [
  { path: '', component: FilmeComponent }
];

@NgModule({
  declarations: [FilmeComponent, FilmComponent, FormatAnPipe, MovieRowDirective],
  imports: [
    CommonModule,
    FilmeRoutingModule,
    RouterModule.forChild(routes)
  ]
})
export class FilmeModule { }
