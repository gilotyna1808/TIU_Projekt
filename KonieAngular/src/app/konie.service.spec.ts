import { TestBed } from '@angular/core/testing';

import { KonieService } from './konie.service';

describe('KonieService', () => {
  let service: KonieService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KonieService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
