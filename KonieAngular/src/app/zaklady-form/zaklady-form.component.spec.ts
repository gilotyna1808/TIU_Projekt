import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZakladyFormComponent } from './zaklady-form.component';

describe('ZakladyFormComponent', () => {
  let component: ZakladyFormComponent;
  let fixture: ComponentFixture<ZakladyFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZakladyFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZakladyFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
