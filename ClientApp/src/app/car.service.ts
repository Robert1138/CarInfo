import { Injectable } from '@angular/core';
import { Observable} from 'rxjs';
import { of } from 'rxjs/observable/of';
import { Car } from './car'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, tap } from 'rxjs/operators';

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
};


@Injectable()
export class CarService {

  // change for deployment
private baseUrl = 'https://webapplication320181208101119.azurewebsites.net/';


// 'https://localhost:44328/';

private apiUrl = 'api/car';
private browseApiUrl = 'api/Browse';

carDefault: Car[];

  constructor(private http: HttpClient) { }

  //gets car from an id
  getCarFromId(id: number): Observable<Car[]> {

    return this.http.get<Car[]>(this.baseUrl + this.apiUrl + "/" + id,
    {
      headers:
        new HttpHeaders(
          {
            'Content-Type': 'application/json',
            'X-Requested-With': 'XMLHttpRequest',
            'MyClientCert': '',        // This is empty
            'MyToken': ''              // This is empty
          }
        )
    }).pipe(
      tap(_=> console.log(`sent a get request with an carId ${id}`)),
      catchError(this.handleError<Car[]>(`getCarFromId if = ${id}`))
    )

  }

  getCarsOfMake(make: string): Observable<Car[]> {

    return this.http.get<Car[]>(this.baseUrl + this.browseApiUrl + "/" + make).pipe(
      tap(_=> console.log(`sent a get request with a car make ${make}`)),
      catchError(this.handleError<Car[]>(`getCarsOfMake if = ${make}`))
    )

  }

  



private handleError<T> (operation = 'operation', result?: T) {
  return (error: any): Observable<T> => {

    // TODO: send the error to remote logging infrastructure
    console.log("looks like you got an error");
    console.error(error + " this is additional"); // log to console instead
    
    // TODO: better job of transforming error for user consumption
//   this.log(`${operation} failed: ${error.message}`);

    // Let the app keep running by returning an empty result.
    return of(result as T);
  };
}




}
