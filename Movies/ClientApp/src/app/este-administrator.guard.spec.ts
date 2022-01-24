import { TestBed, async, inject } from '@angular/core/testing';

import { EsteAdministratorGuard } from './este-administrator.guard';

describe('EsteAdministratorGuard', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EsteAdministratorGuard]
    });
  });

  it('should ...', inject([EsteAdministratorGuard], (guard: EsteAdministratorGuard) => {
    expect(guard).toBeTruthy();
  }));
});
