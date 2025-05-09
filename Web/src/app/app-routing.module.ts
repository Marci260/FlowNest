import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { EditmovieComponent } from './components/editmovie/editmovie.component';
import { MoviesComponent } from './pages/movies/movies.component';
import { SeriesComponent } from './pages/series/series.component';
import { WishlistComponent } from './pages/wishlist/wishlist.component';
import { CreatemovieComponent } from './components/createmovie/createmovie.component';
import { LoginComponent } from './components/login/login.component';
import { ProfileComponent } from './pages/profile/profile.component';

const routes: Routes = [
  { path: "", redirectTo: "home", pathMatch: "full" },
  { path: 'profile', component: ProfileComponent },
  { path: "editmovie/:id", component: EditmovieComponent },
  { path: "createmovie", component: CreatemovieComponent },
  { path: "movies", component: MoviesComponent },
  { path: "series", component: SeriesComponent },
  { path: "wishlist", component: WishlistComponent },
  { path: "home", component: HomeComponent },
  { path: "**", redirectTo: "home", pathMatch: "full" },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
