import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KonieComponent } from './konie.component';

describe('KonieComponent', () => {
  let component: KonieComponent;
  let fixture: ComponentFixture<KonieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KonieComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KonieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
