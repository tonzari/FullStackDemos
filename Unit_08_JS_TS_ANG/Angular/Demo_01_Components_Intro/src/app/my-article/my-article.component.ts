import { Component } from '@angular/core';

@Component({
  selector: 'my-article',
  templateUrl: './my-article.component.html',
  styleUrls: ['./my-article.component.css']
})
export class MyArticleComponent {
  
  articleTitle: string = "Paragraphs stolen from the Angular Docs Page";
  
  testBool: boolean = false;

  articleContent: string[] = [
    "asdadasd",
    "joasjd iadi jaisdji ajsd ",
    "Angular is an application-design framework and development platform for creating efficient and sophisticated single-page apps.",
    "These Angular docs help you learn and use the Angular framework and development platform, from your first application to optimizing complex single-page applications for enterprises. Tutorials and guides include downloadable examples to help you start your projects."
  ];

}
