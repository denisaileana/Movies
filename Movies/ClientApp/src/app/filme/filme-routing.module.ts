import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { FilmeComponent } from './filme.component';
import {FilmComponent} from './film/film.component';

const routes: Routes = [
  { path: '', component: FilmeComponent },
  { path: ':id', component: FilmComponent },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FilmeRoutingModule { }
