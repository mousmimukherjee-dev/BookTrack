import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Header } from '../header/header';

@Component({
  selector: 'app-home',
  imports: [FormsModule,Header],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {

  activeButton = signal<"Sign In" | "Register">("Sign In")

  showLogin(){

    this.activeButton.set("Sign In")
  }

  showRegister(){

    this.activeButton.set("Register")
  }
}
