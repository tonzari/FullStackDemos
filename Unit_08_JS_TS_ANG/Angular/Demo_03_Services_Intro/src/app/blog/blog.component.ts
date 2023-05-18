import { Component, OnInit, AfterViewInit} from '@angular/core';
import { Article } from '../article';
import { BlogService } from '../blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css'],
})
export class BlogComponent implements OnInit, AfterViewInit {
  constructor(private blogService: BlogService) {
    console.log('CONSTRUCTOR CALLED');
  }

  // Code directly below is an example of a synchronous method retreiving data. please do not do this.
  // articles: Article[] = this.blogService.getArticlesSynchronous();

  /* - - - - - - - - Properties - - - - - - - -  */

  articles: Article[] = [];
  results: Article[] = [];



  /* - - - - - - - - Life Cycle Hooks - - - - - - - -  */

  ngOnInit(): void {
    console.log('LIFE CYCLE HOOK: Blog component OnInit!');
    this.getArticles();

    this.results = this.articles;
  }

  // Just for demonstration. Life cycle hooks: https://angular.io/guide/lifecycle-hooks
  ngAfterViewInit(): void {
    console.log('LIFE CYCLE HOOK: after view init.');
  }

  /* - - - - - - - - Methods - - - - - - - -  */

  getArticles(): void {
    this.blogService.getArticles().subscribe(
      // In Subscribe, you can define a function
      // that will store the result of the subscription.
      // Below, we have an arrow function. ex: x => console.log(x)
      // ...where 'result' is the name of the parameter we've defined,
      // and it will be passed an Artilce[]

      (result: Article[]) => {
        this.articles = result;
        console.log(result);
      }
    );
  }

  testClick(): void {
    console.log('clicked button!!');
  }

  filterArticles(searchString: string): void {
    this.results = this.articles.filter(article => 
        article.excerpt.toLowerCase().includes(searchString.toLowerCase()) ||
        article.title.toLowerCase().includes(searchString.toLowerCase())
    );
  }

}
