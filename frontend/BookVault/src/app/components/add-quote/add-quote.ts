import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { QuoteService } from '../../services/QuoteService';


@Component({
  selector: 'app-add-quote',
  imports: [FormsModule],
  templateUrl: './add-quote.html',
  styleUrl: './add-quote.css',
})
export class AddQuote {
  quoteData = {
    text: '',
    author: ''
  };

  constructor(private quoteService: QuoteService, private router: Router) {}

  onSubmit() {
    this.quoteService.addQuote(this.quoteData).subscribe({
      next: () => {
        this.router.navigate(['/dashboard/quotes']); // adjust to your actual route
      },
      error: (error : any) => {
        console.error('Failed to add quote:', error);
      }
    });
  }

  onCancel() {
    this.router.navigate(['/dashboard/quotes']);
  }
}