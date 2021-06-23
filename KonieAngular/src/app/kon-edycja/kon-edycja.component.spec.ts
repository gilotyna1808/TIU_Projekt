import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KonEdycjaComponent } from './kon-edycja.component';

describe('KonEdycjaComponent', () => {
  let component: KonEdycjaComponent;
  let fixture: ComponentFixture<KonEdycjaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KonEdycjaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KonEdycjaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
