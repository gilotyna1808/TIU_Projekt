import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KonComponent } from './kon.component';

describe('KonComponent', () => {
  let component: KonComponent;
  let fixture: ComponentFixture<KonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
