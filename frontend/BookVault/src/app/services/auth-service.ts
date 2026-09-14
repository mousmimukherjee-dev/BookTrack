import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {

  apiURL= "http://localhost:5082/api/UserAuth/register"
  apiURLLogin="http://localhost:5082/api/UserAuth/login"

  constructor(private http : HttpClient){}

  register(registerData:any){

  return this.http.post( this.apiURL , registerData)
  }
  
  login(loginData:any){

  return  this.http.post(this.apiURLLogin, loginData)
  }
}
