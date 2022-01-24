import { TestBed } from '@angular/core/testing';

import { GenuriService } from './genuri.service';

describe('GenuriService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GenuriService = TestBed.get(GenuriService);
    expect(service).toBeTruthy();
  });
});
