import { Injectable } from '@angular/core';
import { AppUser } from './app-user';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor() { }

   mockUsers: AppUser[] = [
    {
      firstname: 'Juan',
      lastname: 'Dominguez',
      email: 'juan.dominguez@example.com'
    },
    {
      firstname: 'Yuki',
      lastname: 'Tanaka',
      email: 'yuki.tanaka@example.com'
    },
    {
      firstname: 'Amina',
      lastname: 'Kone',
      email: 'amina.kone@example.com'
    },
    {
      firstname: 'Mikhail',
      lastname: 'Ivanov',
      email: 'mikhail.ivanov@example.com'
    },
    {
      firstname: 'Xia',
      lastname: 'Li',
      email: 'xia.li@example.com'
    },
    {
      firstname: 'Isabella',
      lastname: 'Rossi',
      email: 'isabella.rossi@example.com'
    },
    {
      firstname: 'Liam',
      lastname: 'O’Brien',
      email: 'liam.obrien@example.com'
    },
    {
      firstname: 'Aarav',
      lastname: 'Patel',
      email: 'aarav.patel@example.com'
    }
  ];

  getAllUsers(): Observable<AppUser[]> {
    const users = of(this.mockUsers);
    return users;
  }
  
}
