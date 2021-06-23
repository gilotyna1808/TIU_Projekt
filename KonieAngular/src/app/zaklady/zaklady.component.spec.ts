import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZakladyComponent } from './zaklady.component';

describe('ZakladyComponent', () => {
  let component: ZakladyComponent;
  let fixture: ComponentFixture<ZakladyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZakladyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZakladyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
