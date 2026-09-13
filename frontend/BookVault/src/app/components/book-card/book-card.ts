import { Component, Input } from '@angular/core';
import { DatePipe } from '@angular/common';


@Component({
  selector: 'app-book-card',
  imports: [DatePipe],
  templateUrl: './book-card.html',
  styleUrl: './book-card.css',
})
export class BookCard {

  @Input() book:any
}
