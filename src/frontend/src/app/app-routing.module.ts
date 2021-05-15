import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UcsListComponent } from './ucs-list/ucs-list.component';

const routes: Routes = [
  { path: 'ucs', component: UcsListComponent },
  { path: '', redirectTo: 'ucs', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
