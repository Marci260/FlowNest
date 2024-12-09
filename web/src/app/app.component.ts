import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'FlowNest';
  readonly APIUrl ="https://localhost:7194/api";

  /**
   *
   */
  constructor(private http:HttpClient) {
   

  }

  // movies:any[];

  // refreshNotes(){
  //   this.http.get(this.APIUrl + "GetNotes").subscribe(data => {this.movies=data;})
  // }

  // ngOnInit(){
  //   this.refreshNotes();
  // }
}
