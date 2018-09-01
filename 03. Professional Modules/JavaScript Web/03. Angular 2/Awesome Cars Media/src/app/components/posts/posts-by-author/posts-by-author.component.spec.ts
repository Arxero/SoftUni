import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PostsByAuthorComponent } from './posts-by-author.component';

describe('PostsByAuthorComponent', () => {
  let component: PostsByAuthorComponent;
  let fixture: ComponentFixture<PostsByAuthorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostsByAuthorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostsByAuthorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
