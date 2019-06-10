import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Person } from 'src/app/shared/models/Person';
import { Interest } from 'src/app/shared/models/Interest';
import { delay } from 'rxjs/operators/delay';

@Injectable()
export class PeopleService {
    public api = 'http://localhost:8080/api';
    public people_api = `${this.api}/people`
    public interest_api = `${this.api}/interests`

    constructor(private http: HttpClient) { }

    getAllPeople(filter: string): Observable<Array<Person>> {
        return this.http.get<Array<Person>>(this.people_api, {
            params: {
                filter: filter
            }
        }).pipe(delay(2500)); // Simulates server delay
    }

    getPerson(id: string) {
        return this.http.get(`${this.people_api}/${id}`);
    }

}