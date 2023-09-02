import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { NetflixSubscriptionFee } from '../models/inside/external/netflix/netflix-subscription-fee';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class NetflixService {
  constructor(private readonly _http: HttpClient) {}

  getNetflixSubscriptionFee(): Observable<NetflixSubscriptionFee[]> {
    return this._http.get<NetflixSubscriptionFee[]>(
      environment.getNetflixSubscriptionFeeURL
    );
  }

  getCountryNetflixSubscriptionFee(
    country: string
  ): Observable<NetflixSubscriptionFee> {
    return this._http.get<NetflixSubscriptionFee>(
      `${environment.getCountryNetflixSubscriptionFeeURL}${country}`
    );
  }
}
