import { Injectable } from '@angular/core';
import { Movie } from './movie';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class MovieService {

  movies: Movie[] = []
  apiBaseUrl = "https://localhost:7194"

  constructor(private http: HttpClient) {
    this.loadApi()
    // this.save();
    console.log("ezek a filmek toltodnek be:");
    console.log(this.movies)
   }

    loadApi(): void {
    this.http.get<Movie[]>(this.apiBaseUrl + "/api/Movie").subscribe(x => {
      this.movies = x
    })
  }

 remove(movie: Movie): void {
    this.http.delete(this.apiBaseUrl + "/api/Movie/", {
      headers: new HttpHeaders({ "Content-Type": "application/json" }),
      body: {
        id: movie.id
      }
    }).subscribe({
      next: (response) => {
        console.log(".:SUCCESS:.")
        console.log("Delete request result:", response)
        this.movies = this.movies.filter(x => x.id !== movie.id)
      },
      error: (error) => {
        console.log(".:ERROR:.")
        console.log("Delete request result:", error)
      }
    })
  }

   create(movie: Movie): void {
    this.http.post(this.apiBaseUrl + "/api/Movie", movie).subscribe({
      next: (response) => {
        console.log(".:SUCCESS:.")
        console.log("Create request result:", response)
        this.movies.push(movie)
      },
      error: (error) => {
        console.log(".:ERROR:.")
        console.log("Create request result:", error)
      }
    })
  }

  update(movie: Movie): void {
    this.http.put(this.apiBaseUrl + "updateDeveloper", movie).subscribe({
      next: (response) => {
        console.log("::SUCCESS::")
        console.log("Update request result:", response)
        let index = this.movies.findIndex(x => x.id === movie.id)
        this.movies[index] = movie
      },
      error: (error) => {
        console.log("::ERROR::")
        console.log("Update request result:", error)
      }
    })
  }

}
