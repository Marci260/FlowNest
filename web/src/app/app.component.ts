import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MovieNavigationButtonComponent } from "./buttons/movie-navigation-button/movie-navigation-button.component";
import { NgOptimizedImage } from '@angular/common'

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Web';
}
