import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Quote, QuoteService } from '../../services/QuoteService';


@Component({
  selector: 'app-quotes',
  imports: [RouterLink],
  templateUrl: './quotes.html',
  styleUrl: './quotes.css',
})
export class Quotes implements OnInit {
  quotes: Quote[] = [];

  constructor(private quoteService: QuoteService) {}

  ngOnInit() {
    this.loadQuotes();
  }

  loadQuotes() {
    this.quoteService.getQuotes().subscribe({
      next: (data : any) => {
        this.quotes = data;
      },
      error: (error : any) => {
        console.error('An error occurred:', error);
      }
    });
  }

  deleteQuote(id: number) {
    this.quoteService.deleteQuote(id).subscribe({
      next: () => {
        this.quotes = this.quotes.filter(q => q.id !== id);
      },
      error: (error : any) => {
        console.error('Delete failed:', error);
      }
    });
  }
}