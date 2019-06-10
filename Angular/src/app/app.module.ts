import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { HttpClientModule } from '@angular/common/http';
import { NgxSpinnerModule } from 'ngx-spinner';
import {BrowserAnimationsModule} from 
'@angular/platform-browser/animations';
import {
  MatButtonModule,
  MatCardModule,
  MatInputModule,
  MatListModule,
  MatToolbarModule
} from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PeopleSearcherComponent } from './people-searcher/people-searcher.component';
import { PeopleService } from './shared/api/people.service';
import { Routes, RouterModule } from '@angular/router';
import { FooterComponent } from './footer/footer.component';

const appRoutes: Routes = [
  { path: '', component: PeopleSearcherComponent, pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent,
    PeopleSearcherComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFontAwesomeModule,
    FormsModule,
    HttpClientModule,
    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatListModule,
    MatToolbarModule,
    NgxSpinnerModule,
    RouterModule.forRoot(appRoutes),
  ],
  providers: [PeopleService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
