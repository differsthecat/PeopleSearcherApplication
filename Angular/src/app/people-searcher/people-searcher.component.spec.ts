import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { PeopleSearcherComponent } from './people-searcher.component';
import { NgxSpinnerService, NgxSpinnerModule } from 'ngx-spinner';
import { PeopleService } from 'src/app/shared/api/people.service';
import { HttpClientModule, HttpClient, HttpHandler } from '@angular/common/http';

describe('PeopleSearcherComponent', () => {
  let component: PeopleSearcherComponent;
  let fixture: ComponentFixture<PeopleSearcherComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PeopleSearcherComponent ],
      imports: [ NgxSpinnerModule, FormsModule ],
      providers: [PeopleService, HttpClient, HttpHandler]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PeopleSearcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
