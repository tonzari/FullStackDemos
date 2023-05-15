import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MyArticleComponent } from './my-article/my-article.component';
import { ReadMoreButtonComponent } from './read-more-button/read-more-button.component';

@NgModule({
  declarations: [
    AppComponent,
    MyArticleComponent,
    ReadMoreButtonComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
