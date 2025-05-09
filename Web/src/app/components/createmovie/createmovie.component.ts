import { Component } from '@angular/core';
import { Movie } from '../../movie';
import { ActivatedRoute, Router } from '@angular/router';
import { MovieService } from '../../movie.service';

@Component({
  selector: 'app-createmovie',
  standalone: false,
  templateUrl: './createmovie.component.html',
  styleUrl: './createmovie.component.sass'
})
export class CreatemovieComponent {

movie: Movie = new Movie();
  
  constructor(private route: ActivatedRoute, private router: Router, private movieService: MovieService) {
    route.params.subscribe(param => {
      this.movie = movieService.movies.filter(x => x.id == param["id"])[0]
    })

  }

  save(): void {
   
    this.movieService.create(this.movie)
    this.router.navigate(["/home"])
  }

}
