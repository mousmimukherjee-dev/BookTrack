import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { BookCard } from '../book-card/book-card';

@Component({
  selector: 'app-dashboard',
  imports: [RouterLink,BookCard,RouterOutlet],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
})
export class Dashboard {

}
