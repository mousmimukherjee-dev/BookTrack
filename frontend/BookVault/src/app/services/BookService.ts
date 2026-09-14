import { HttpClient } from '@angular/common/http';
import { Injectable, ɵɵresolveBody } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  private apiURL = 'http://localhost:5082/api/Books';

  constructor(private http: HttpClient) {}

  getBooks(): Observable<any> {
    return this.http.get(this.apiURL);
  }

 
  addBook(book : any): Observable<any>{

    return this.http.post(this.apiURL , book);
  }

  deleteBook(book:any) : Observable<any>{

  return  this.http.delete(`${this.apiURL}/${ book.id }`);
  }

   
}
