import { Component } from '@angular/core';
import { BookService } from '../../services/BookService';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-book',
  imports: [FormsModule],
  templateUrl: './add-book.html',
  styleUrl: './add-book.css',
})
export class AddBook {

  newBook: any = {}
  showForm: boolean = true;
  bookAdded:boolean= false;
  constructor(private addBookService : BookService, private router : Router){

  }

  addBook(){

    this.addBookService.addBook(this.newBook).subscribe({

      next:(book)=>{

        this.newBook = book
        this.router.navigate(['/dashboard'])
        // this.newBook={}
        // this.showForm=false
        // this.bookAdded=true
      },
      error:(error)=>{

        console.log("Error:" , error)
      }
    })
  }

  cancel(){

    this.router.navigate(["/dashboard"])
  }


 
}
