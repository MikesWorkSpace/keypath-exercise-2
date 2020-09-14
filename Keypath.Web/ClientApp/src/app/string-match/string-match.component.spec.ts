import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { StringMatchComponent } from './string-match.component';
import { HttpClient } from '@angular/common/http';

describe('StringMatchComponent', () => {
  let http: HttpClient;
  let component: StringMatchComponent;
  let fixture: ComponentFixture<StringMatchComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [StringMatchComponent],
      imports: [FormsModule, HttpClientTestingModule],
      providers: [{ provide: 'REST_API_BASE_URL', useValue: "https://localhost:44303/api/", deps: [] }]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    http = TestBed.get(HttpClient);
    fixture = TestBed.createComponent(StringMatchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
