import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NetflixHomeComponent } from './netflix-home.component';

describe('NetflixHomeComponent', () => {
  let component: NetflixHomeComponent;
  let fixture: ComponentFixture<NetflixHomeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NetflixHomeComponent]
    });
    fixture = TestBed.createComponent(NetflixHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
