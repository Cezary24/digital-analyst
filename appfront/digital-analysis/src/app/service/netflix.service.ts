import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { NetflixSubscriptionFee } from '../models/inside/external/netflix/netflix-subscription-fee';
import { environment } from 'src/environments/environment';
import { GlobalRevenue } from '../models/inside/external/netflix/global-revenue';
import { RevenueQuarter } from '../models/inside/external/netflix/revenue-quarter';
import { StockPrice } from '../models/inside/external/netflix/stock-price';

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

  getStockPricesFromYear(year: number): Observable<StockPrice[]> {
    return this._http.get<StockPrice[]>(
      `${environment.getNetflixStockPricesForYearURL}${year}`
    );
  }

  getAllNetflixRevenueQuarter(): Observable<RevenueQuarter[]> {
    return this._http.get<RevenueQuarter[]>(
      `${environment.getAllNetflixRevenueQuarterURL}`
    );
  }

  getAllNetflixGlobalRevenueURL(): Observable<GlobalRevenue[]> {
    return this._http.get<GlobalRevenue[]>(
      `${environment.getAllNetflixGlobalRevenueURL}`
    );
  }
}
