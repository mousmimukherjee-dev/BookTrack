import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { BookCard } from '../book-card/book-card';
import { BookService } from '../../services/BookService';

@Component({
  selector: 'app-dashboard',
  imports: [RouterLink,BookCard,RouterOutlet],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
})
export class Dashboard {

  books:any[] = []

  constructor(private booksservice : BookService){

  }

  ngOnInit(){

    this.booksservice.getBooks().subscribe({

      next:(data) => {

        this.books = data
      },

      error:(error) =>{

        console.error("Error loading books:",  error)
      }
    })
  }

}
