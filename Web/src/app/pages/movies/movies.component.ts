import { Component } from '@angular/core';
import { Movie } from '../../movie';
import { Router } from '@angular/router';
import { MovieService } from '../../movie.service';

@Component({
  selector: 'app-movies',
  standalone: false,
  templateUrl: './movies.component.html',
  styleUrl: './movies.component.sass'
})
export class MoviesComponent {
  constructor(private router: Router, public movieService: MovieService){}
  remove(movie: Movie): void{
    this.movieService.remove(movie)
  }

  edit(movie: Movie): void{
    this.router.navigate(["/editmovie/" + movie.id])
  }

 rating(movie: Movie){
  //To-Do
 }

 create(movie: Movie){
   this.router.navigate(["/createmovie/"])
 }
}
