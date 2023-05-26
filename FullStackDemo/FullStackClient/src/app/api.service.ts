import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  // define the API URL
  private readonly url = 'https://localhost:7174/api/';

  // make Http web requests to our API: GetAllUsers, AddUser

  getAllUsers() {
    return this.http.get<User[]>(this.url + "Users");
  }

  addUser(userToAdd: User) {
    return this.http.post(this.url + "Users", userToAdd);
  }

}
