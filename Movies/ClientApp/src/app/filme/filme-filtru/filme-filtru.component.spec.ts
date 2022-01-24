import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FilmeFiltruComponent } from './filme-filtru.component';

describe('FilmeFiltruComponent', () => {
  let component: FilmeFiltruComponent;
  let fixture: ComponentFixture<FilmeFiltruComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FilmeFiltruComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FilmeFiltruComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
