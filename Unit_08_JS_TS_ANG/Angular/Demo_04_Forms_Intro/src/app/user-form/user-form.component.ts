import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AppUser } from '../app-user';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent {
  userForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private userService: UsersService) {
    this.userForm = this.formBuilder.group({
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
    });
  }

  onSubmit() {
    if (this.userForm.valid) {
      const user: AppUser = this.userForm.value;
      console.log(user);
      
      // handle your user data here...
      this.userService.mockUsers.push(user);

      this.userForm.reset();

    }
  }
}
