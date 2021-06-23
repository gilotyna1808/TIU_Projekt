import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WyscigComponent } from './wyscig.component';

describe('WyscigComponent', () => {
  let component: WyscigComponent;
  let fixture: ComponentFixture<WyscigComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WyscigComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WyscigComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
