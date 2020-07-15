import { Injectable } from '@angular/core';
import { Model } from './model';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DataProviderService {

  constructor(private _http: HttpClient) {
   }

   getData(): Promise<Array<Model>> {
    return this._http.get<Array<Model>>(`${environment.baseUri}/values`)
    /*.pipe((x: Array<any>) => {
      const result = new Array<Model>();
      for (let i = 0; i < x.length; i++) {
        const temp = new Model();
        temp.id = x[i].id;
        temp.value = x[i].value;
        result.push(temp);
      }
      return result;
    })*/
    .toPromise();
   }
}
