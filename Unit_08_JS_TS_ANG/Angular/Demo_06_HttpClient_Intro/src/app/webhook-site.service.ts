import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { WebhookResponse } from './webhook-response';

@Injectable({
  providedIn: 'root'
})
export class WebhookSiteService {

  // Inject the HttpClient
  constructor(private http: HttpClient) { }

  // Assign the URL of our API to a property
  url: string = 'https://webhook.site/e4a69c7d-8b4e-4685-816e-258b3ffe6b2f';

  // Create a method that makes an... 
  
  // HTTP GET request
  sendGetRequest() {
    return this.http.get<WebhookResponse>(this.url);
  }

  // HTTP POST request
  sendPostRequest(postData: string): Observable<WebhookResponse> {
    return this.http.post<WebhookResponse>(this.url, { "localMachine": postData } );
  }

  // HTTP DELETE request
  sendDeleteRequest() {
    return this.http.delete<WebhookResponse>(this.url);
  }

}
