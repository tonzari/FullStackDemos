import { Component } from '@angular/core';
import { Article } from '../article';
import { BlogService } from '../blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent {
    
    constructor(private blogService: BlogService){}

    articles: Article[] = [];

    searchArticles(substring: string): Article[] {
        return this.articles.filter(article => 
            article.title.toLowerCase().includes(substring.toLowerCase()) || 
            article.excerpt.toLowerCase().includes(substring.toLowerCase())
        );
    }

}
