import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WyscigiComponent } from './wyscigi.component';

describe('WyscigiComponent', () => {
  let component: WyscigiComponent;
  let fixture: ComponentFixture<WyscigiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WyscigiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WyscigiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
