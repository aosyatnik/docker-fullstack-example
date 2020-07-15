import { Injectable } from '@angular/core';
import { Model } from './model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DataProviderService {

  constructor(private _http: HttpClient) {
   }

   getData(): Promise<Array<Model>> {
    return this._http.get<Array<Model>>(`${environment.baseUri}/values`).toPromise();
   }

   sendData(value: number): Promise<any> {
    const headers = new HttpHeaders().set('Content-Type', 'application/json');
    return this._http.post(`${environment.baseUri}/values`, value, { headers }).toPromise();
   }
}
