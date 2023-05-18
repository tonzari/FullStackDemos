import { Injectable } from '@angular/core';

import { Article } from './article';
import { ARTICLES } from './mock-articles';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  // This will not work in a real environment where you need to make HTTP requests to retrieve data
  // NOTE: This method below was created for learning purposes. Please do not do this.

  getArticlesSynchronous(): Article[] {
    
    return ARTICLES;
  }

  // Normally our service will be making HTTP requests to retreive data
  // and that takes TIME!
  // We will use rxjs and Observables to help with making asynchronous requests: https://rxjs.dev/

  getArticles(): Observable<Article[]> {

    // We want to turn our Article[] from the mock file into an Observable of Article[]
    // We can make use of the rxjs method 'of'
    const articles = of(ARTICLES);
    
    console.log(articles);

    return articles;

  }

}
