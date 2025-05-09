import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MovieService } from '../../movie.service';

@Component({
  selector: 'app-series',
  standalone: false,
  templateUrl: './series.component.html',
  styleUrl: './series.component.sass'
})
export class SeriesComponent {
constructor(private router: Router, public movieService: MovieService){}
}
