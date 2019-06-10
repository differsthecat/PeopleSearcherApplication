import { Interest } from 'src/app/shared/models/Interest';

// Person model
export class Person {
    id: number;
    firstName: string;
    lastName: string;
    address:string;
    age: number;
    picUrl: string;
    interests: Interest[];
}