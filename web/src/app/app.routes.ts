import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoviesComponent } from './movies/movies.component'; 
import { SeriesComponent } from './series/series.component'; 
import { WatchListComponent } from './watch-list/watch-list.component'; 


export const routes: Routes = [
//   { path: 'movies', component: MoviesComponent }, 
//   { path: 'series', component: SeriesComponent }, 
//   { path: 'watchlist', component: WatchListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }



