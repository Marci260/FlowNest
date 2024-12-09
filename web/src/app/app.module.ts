import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, RouterOutlet } from '@angular/router';  // Importáld a RouterModule-t

import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
//import { AppRoutingModule } from './app-routing.module';  // Ha van saját routing modulod

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent
    // más komponensek
  ],
  imports: [
    BrowserModule,
    RouterModule,
    RouterOutlet  // Add hozzá a RouterModule-t
    //AppRoutingModule,  // Ha van saját routing modulod
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }