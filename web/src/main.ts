import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { provideRouter, Routes } from '@angular/router';
import { MoviesComponent } from './app/movies/movies.component';

bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));

// Útvonalak definiálása
// const routes: Routes = [
//   { path: '', component: AppComponent }, // Alapértelmezett útvonal
//   { path: 'movies', component: MoviesComponent }, // /movies útvonal
//   { path: '**', redirectTo: '' } // Wildcard útvonal
// ];

// Alkalmazás indítása standalone módban
// bootstrapApplication(AppComponent, {
//   providers: [
//     provideRouter(routes) // Útvonalak konfigurálása
//   ]
// });
