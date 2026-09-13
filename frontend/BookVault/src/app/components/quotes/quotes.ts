import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { BookService } from '../../services/BookService';
import { errorContext } from 'rxjs/internal/util/errorContext';

@Component({
  selector: 'app-quotes',
  imports: [RouterLink],
  templateUrl: './quotes.html',
  styleUrl: './quotes.css',
})
export class Quotes {

  books: any[] = []

  constructor(private bookService : BookService){

  }

  ngOnInit(){

    this.bookService.getBooks().subscribe({

      next:(data)=> {

        this.books = data
      },
      error:(error) => {

        console.error("An Error Occured:", error)
      }
    })
  }

}
