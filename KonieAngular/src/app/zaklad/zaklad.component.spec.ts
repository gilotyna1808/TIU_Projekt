import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZakladComponent } from './zaklad.component';

describe('ZakladComponent', () => {
  let component: ZakladComponent;
  let fixture: ComponentFixture<ZakladComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZakladComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZakladComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
