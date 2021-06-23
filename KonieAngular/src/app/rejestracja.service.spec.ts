import { TestBed } from '@angular/core/testing';

import { RejestracjaService } from './rejestracja.service';

describe('RejestracjaService', () => {
  let service: RejestracjaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RejestracjaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
