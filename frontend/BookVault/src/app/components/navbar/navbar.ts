import { Component } from '@angular/core';
import { Router, RouterLink, RouterOutlet, Routes } from '@angular/router';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-navbar',
  imports: [RouterLink],
  templateUrl: './navbar.html',
  styleUrl: './navbar.css',
})
export class Navbar {

   constructor(public themeService: ThemeService , private router : Router) {}

  
  toggleTheme() {
    this.themeService.toggleTheme();
  }

  signOut(){

     this.router.navigate(['']);
  }
}
