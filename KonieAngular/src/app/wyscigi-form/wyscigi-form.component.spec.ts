import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WyscigiFormComponent } from './wyscigi-form.component';

describe('WyscigiFormComponent', () => {
  let component: WyscigiFormComponent;
  let fixture: ComponentFixture<WyscigiFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WyscigiFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WyscigiFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
