import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GenuriComponent } from './genuri.component';

describe('GenuriComponent', () => {
  let component: GenuriComponent;
  let fixture: ComponentFixture<GenuriComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GenuriComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GenuriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
