import { TestBed } from '@angular/core/testing';

import { WebhookSiteService } from './webhook-site.service';

describe('WebhookSiteService', () => {
  let service: WebhookSiteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WebhookSiteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
