import { Component } from '@angular/core';
import { Movie } from '../movie';
import { Router } from '@angular/router';

@Component({
  selector: 'app-movies',
  standalone: false,
  templateUrl: './movies.component.html',
  styleUrl: './movies.component.sass'
})
export class MoviesComponent {
movies: Movie[] = []

constructor(private router: Router){
  this.load();
}

  delete(movie: Movie): void {
    this.movies = this.movies.filter(x => x.id != movie.id)
    this.save()
  }

  edit(movie: Movie): void {
    this.router.navigate(["/edit/" + movie.id])
  }

  save(): void {
    localStorage.setItem("movies", JSON.stringify(this.movies))
  }

  load(): void {
    let data = JSON.parse(localStorage.getItem("bprof_devs") ?? "[]")
    Object.values(data).map(x => this.movies.push(Object.assign(new Movie(), x)))

    // data.map((element: any) => {
    //   this.developers.push(Object.assign(new Developer(), element))
    // })
  }

  seed(): void {
    let d1 = new Movie()
    d1.title = "Iron man"
    d1.director="Mittom Én"
    d1.rating = 4.1
    d1.release = 20000404

    this.movies.push(d1)

    let d2 = new Movie()
  
    this.movies.push(d2)

    let d3 = new Movie()
    d3.id = "d255b2e3-9fde-c833-1cda-fa9ee62e851c"
   
    this.movies.push(d3)

    let d4 = new Movie()
    d4.id = "20ef4e13-94db-8a96-ca02-4f65a2a545d2"
   
    this.movies.push(d4)
  }
}
