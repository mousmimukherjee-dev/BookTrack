import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {

  apiURL= "https://bookvault-api-mousumi-byaaafaee0emh6a2.swedencentral-01.azurewebsites.net/api/UserAuth/register"
  apiURLLogin="https://bookvault-api-mousumi-byaaafaee0emh6a2.swedencentral-01.azurewebsites.net/api/UserAuth/login"

  constructor(private http : HttpClient){}

  register(registerData:any){

  return this.http.post( this.apiURL , registerData)
  }
  
  login(loginData:any){

  return  this.http.post(this.apiURLLogin, loginData)
  }
}
