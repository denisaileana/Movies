import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GenuriComponent } from './genuri.component';

const routes: Routes = [{ path: '', component: GenuriComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GenuriRoutingModule { }
