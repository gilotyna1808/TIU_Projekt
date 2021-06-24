import { TestBed } from '@angular/core/testing';

import { KlientService } from './klient.service';

describe('KlientService', () => {
  let service: KlientService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KlientService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
