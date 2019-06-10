import { Component, OnInit } from '@angular/core';
import { PeopleService } from 'src/app/shared/api/people.service';
import { Person } from 'src/app/shared/models/Person';
import { Interest } from 'src/app/shared/models/Interest';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { NgxSpinnerService, NgxSpinnerModule } from 'ngx-spinner';

import {BrowserAnimationsModule} from 
'@angular/platform-browser/animations';
import {
  MatFormField,
  MatButtonModule,
  MatCardModule,
  MatInputModule,
  MatListModule,
  MatToolbarModule
} from '@angular/material';

@Component({
  selector: 'app-people-searcher',
  templateUrl: './people-searcher.component.html',
  styleUrls: ['./people-searcher.component.scss']
})
export class PeopleSearcherComponent implements OnInit {
  people: any;
  searchText = '';
  noResults = false;
  noPeople = true;
  placeholderPicUrl = 'https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/user-placeholder.png';
  
  constructor(private peopleService: PeopleService, private spinner: NgxSpinnerService) { }

  ngOnInit() {
      this.spinner.hide();
  }

  searchPeople() {
    console.log(this.spinner);
    this.spinner.show();
    this.peopleService.getAllPeople(this.searchText).subscribe(data => {
      this.people = data;
      if (this.people.length == 0) {
        this.noResults = true;
        this.noPeople = true;
      }
      else {
        this.noResults = false;
        this.noPeople = false;
        // Flatten the array of interests
        for (let p of this.people) {
          p.interests = p.interests.map(function (e) {
            return e.title;
          }).join(', ');
        }
      }
      this.spinner.hide();
    });
  }
}
