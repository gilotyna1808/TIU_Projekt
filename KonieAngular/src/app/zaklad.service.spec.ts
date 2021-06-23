import { TestBed } from '@angular/core/testing';

import { ZakladService } from './zaklad.service';

describe('ZakladService', () => {
  let service: ZakladService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ZakladService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
