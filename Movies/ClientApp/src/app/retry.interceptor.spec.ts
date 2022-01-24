import { TestBed } from '@angular/core/testing';

import { RetryInterceptorService } from './retry.interceptor';

describe('RetryInterceptorService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RetryInterceptorService = TestBed.get(RetryInterceptorService);
    expect(service).toBeTruthy();
  });
});
