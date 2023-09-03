import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnDestroy,
  OnInit,
} from '@angular/core';
import { ContentListService } from 'src/app/service/content-list.service';
import { CONTENT_LIST_NETFLIX } from './content-list/content-list-netflix';
import { Subject, catchError, forkJoin, of, takeUntil } from 'rxjs';
import { NetflixService } from 'src/app/service/netflix.service';
import { NetflixChartsResponse } from 'src/app/models/inside/external/netflix/netflix-charts-response';
import { GlobalRevenue } from 'src/app/models/inside/external/netflix/global-revenue';
import { RevenueQuarter } from 'src/app/models/inside/external/netflix/revenue-quarter';
import { StockPrice } from 'src/app/models/inside/external/netflix/stock-price';
import { LegendComponentOption, SeriesOption } from 'echarts';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-netflix-home',
  templateUrl: './netflix-home.component.html',
  styleUrls: ['./netflix-home.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NetflixHomeComponent implements OnInit, OnDestroy {
  private readonly _destroy: Subject<void> = new Subject();

  isReady: boolean = false;

  stockPrices: StockPrice[] = [];
  revenueQuarters: RevenueQuarter[] = [];

  //GLOBAL REVENUE
  globalRevenues: GlobalRevenue[] = [];
  globalRevenuesDates: Date[] = [];
  globalRevenueLegend: LegendComponentOption = {
    data: ['Daty', 'Globalny przychód'],
    align: 'left',
  };
  globalRevenueXAxis: any;
  globalRevenueYAxis: any = {};
  globalRevenueTooltip: any = {};
  globalRevenueSeries!: SeriesOption;

  constructor(
    private readonly _contentListService: ContentListService,
    private readonly _netflixService: NetflixService,
    private readonly _changeDetectorRef: ChangeDetectorRef
  ) {
    this._contentListService.pageContentList.next(CONTENT_LIST_NETFLIX);
  }

  ngOnDestroy(): void {
    this._destroy.complete();
  }
  ngOnInit(): void {
    this.getData();
  }

  private getData(): void {
    forkJoin({
      stockPrices: this._netflixService.getStockPricesFromYear(2022),
      revenueQuarter: this._netflixService.getAllNetflixRevenueQuarter(),
      globalRevenue: this._netflixService.getAllNetflixGlobalRevenueURL(),
    })
      .pipe(
        catchError(() => {
          return of(undefined);
        }),
        takeUntil(this._destroy)
      )
      .subscribe((response) => {
        console.log(response);

        if (response) {
          this.stockPrices = response.stockPrices;
          this.revenueQuarters = response.revenueQuarter;

          //GLOBAL REVENUE
          this.globalRevenues = response.globalRevenue;
          this.globalRevenuesDates = this.globalRevenues.map(
            (globalRevenue) => globalRevenue.date
          );
          this.globalRevenueXAxis = {
            data: this.globalRevenuesDates,
            silent: false,
            splitLine: {
              show: false,
            },
          };
          this.globalRevenueSeries = {
            name: 'Globalny przychód',
            type: 'bar',
            data: this.globalRevenues.map(
              (globalRevenue) => globalRevenue.globalRevenue
            ),
            animationDelay: (idx) => idx * 10 + 100,
          };
          /////////////////////////////////////////////////////////////////
          console.log('to jest początek');
          this.isReady = true;
          this._changeDetectorRef.markForCheck();
        }
      });
  }
}
