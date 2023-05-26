import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {

  constructor(private apiService: ApiService){}

  // Angular Component Life Cycle Hook
  ngOnInit(): void {
    this.getUsers();
  }

  getUsers() {
    this.apiService.getAllUsers()
      .subscribe( result => {
        console.log(result);
      });
  }
}
