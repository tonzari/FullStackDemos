import { Injectable } from '@angular/core';

import { Article } from './article';
import { ARTICLES } from './mock-articles';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  getArticles(): Observable<Article[]> {
    
    return ARTICLES; // to do! fix it!
  }

}
