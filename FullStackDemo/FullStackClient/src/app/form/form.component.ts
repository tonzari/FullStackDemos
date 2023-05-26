import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { User } from '../user';


@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit{

  constructor(private apiService: ApiService){}

  ngOnInit(): void {
    this.addUser()
  }

  addUser(){

    const testUser: User = {
      firstName: "ANGULAR!!!",
      lastName: "ANGULAR!!!",
      email: "ANGULAR!!!"
    };

    this.apiService.addUser(testUser)
      .subscribe( result => {
        console.log("form component", result);
      } );
  }
}
