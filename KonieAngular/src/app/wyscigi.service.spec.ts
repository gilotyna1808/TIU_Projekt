import { TestBed } from '@angular/core/testing';

import { WyscigiService } from './wyscigi.service';

describe('WyscigiService', () => {
  let service: WyscigiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WyscigiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
