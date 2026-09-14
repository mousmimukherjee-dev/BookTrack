import { HttpClient } from '@angular/common/http';
import { Injectable, ɵɵresolveBody } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  private apiURL = 'https://bookvault-api-mousumi-byaaafaee0emh6a2.swedencentral-01.azurewebsites.net/api/Books';

  constructor(private http: HttpClient) {}

  getBooks(): Observable<any> {
    return this.http.get(this.apiURL);
  }

 
  addBook(book : any): Observable<any>{

    return this.http.post(this.apiURL , book);
  }

  updateBook(book : any): Observable<any>{

    return this.http.put(this.apiURL , book);
  }
  deleteBook(book:any) : Observable<any>{

  return  this.http.delete(`${this.apiURL}/${ book.id }`);
  }

   
}
