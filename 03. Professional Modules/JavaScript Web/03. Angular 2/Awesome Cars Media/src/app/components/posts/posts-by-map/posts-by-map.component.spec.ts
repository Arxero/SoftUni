import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PostsByMapComponent } from './posts-by-map.component';

describe('PostsByMapComponent', () => {
  let component: PostsByMapComponent;
  let fixture: ComponentFixture<PostsByMapComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostsByMapComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostsByMapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
