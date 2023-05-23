import { Component, OnInit } from '@angular/core';
import { AppUser } from '../app-user';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-email-list',
  templateUrl: './email-list.component.html',
  styleUrls: ['./email-list.component.css']
})
export class EmailListComponent implements OnInit {
  
  emailList: AppUser[] = [];

  constructor(private userService: UsersService){}
  
  ngOnInit(): void {
    this.userService.getAllUsers()
      .subscribe(
        result => this.emailList = result
      ); 
  }
}
