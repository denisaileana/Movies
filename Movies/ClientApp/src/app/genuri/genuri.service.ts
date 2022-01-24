import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

export interface Gen {
  numeGen: string;
}

@Injectable({
  providedIn: 'root'
})
export class GenuriService {

  constructor(private httpClient: HttpClient) { }

  getGenuri() {
    return this.httpClient.get<Gen[]>('/api/genres');
  }
}
