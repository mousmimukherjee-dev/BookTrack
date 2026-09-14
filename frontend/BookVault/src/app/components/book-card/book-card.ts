import { Component, Input } from '@angular/core';
import { DatePipe } from '@angular/common';
import { BookService } from '../../services/BookService';


@Component({
  selector: 'app-book-card',
  imports: [DatePipe],
  templateUrl: './book-card.html',
  styleUrl: './book-card.css',
})
export class BookCard {

  @Input() book:any
  
  showBookCard: any = true

  constructor(private bookService : BookService){}

  deleteBookCard(){

    this.bookService.deleteBook(this.book).subscribe({

      next:(data)=>{

        this.showBookCard = false
      },error:(error)=>{

      console.error("An Error Occured:", error)
      }
    })
  }

}
