import { Component } from '@angular/core';
import { WebhookSiteService } from './webhook-site.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'HttpDemo';

  requestType?: string;
  imageUrl?: string;

  constructor(private webhookService: WebhookSiteService){}

  sendGetRequest() {

    this.requestType = "request made...";

    this.webhookService.sendGetRequest().subscribe( 
      
      result => {      
        this.requestType = result.requestType;
        console.log(result);

        this.changeImage(this.requestType);
      }

    );
  }

  sendPostRequest(postData: string) {

    this.requestType = "request made...";

    this.webhookService.sendPostRequest(postData).subscribe(  
      
      result => {      
        this.requestType = result.requestType;
        console.log(result);

        this.changeImage(this.requestType);
      }
       
    );
  }

  sendDeleteRequest() {

    this.requestType = "request made...";

    this.webhookService.sendDeleteRequest().subscribe(  
      
      result => {      
        this.requestType = result.requestType;
        console.log(result);

        this.changeImage(this.requestType);
      }
       
     );
  }

  // Extra challenge: display a different image for each request type:
  // - get, post, and delete

  changeImage(requestType: string): void {
    
    if(requestType === "POST") {
      this.imageUrl = "https://static.wixstatic.com/media/fe4a4f_b69dcfe1351c415f8891f2450817680b~mv2.jpg/v1/fit/w_1000%2Ch_620%2Cal_c%2Cq_80,enc_auto/file.jpg";
    }
    else if(requestType === "GET") {
      this.imageUrl = "https://s.hdnux.com/photos/32/10/31/6850147/4/rawImage.jpg";
    }
    else if(requestType === "DELETE") {
      this.imageUrl = "https://pbs.twimg.com/media/EHSAJkXX0AI6d8a.jpg";
    }
  }

}
