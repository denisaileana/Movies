import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { GenuriRoutingModule } from './genuri-routing.module';
import { GenuriComponent } from './genuri.component';

const routes: Routes = [
  { path: '', component: GenuriComponent }
];

@NgModule({
  declarations: [GenuriComponent],
  imports: [
    CommonModule,
    GenuriRoutingModule,
    RouterModule.forChild(routes)
  ]
})
export class GenuriModule { }
