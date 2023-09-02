import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  Input,
  OnChanges,
  OnInit,
  SimpleChanges,
} from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Subject, catchError, of, takeUntil } from 'rxjs';
import { NetflixSubscriptionFee } from 'src/app/models/inside/external/netflix/netflix-subscription-fee';
import { SubscriptionFeeViewNetflix } from 'src/app/models/inside/external/netflix/subscription-fee-view-netflix';
import { NetflixService } from 'src/app/service/netflix.service';
import { ActivatedRoute } from '@angular/router';
import { LocalizationType } from '../../sidebar/toolbar/model/localization-type';

@Component({
  selector: 'app-country-detail',
  templateUrl: './country-detail.component.html',
  styleUrls: ['./country-detail.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CountryDetailComponent implements OnChanges, OnInit {
  @Input() selectedCountryName?: string;

  private readonly _destroy: Subject<void> = new Subject();

  countryFeeSubscription?: SubscriptionFeeViewNetflix;
  isCountryData: boolean = false;
  digitalAnalystType: LocalizationType = 'brak';

  ngOnInit(): void {
    this.digitalAnalystType = this._activatedRoute.snapshot.queryParamMap.get(
      'type'
    )! as LocalizationType;
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['selectedCountryName']) {
      if (this.selectedCountryName) {
        switch (this.digitalAnalystType) {
          case 'netflix': {
            this.getCountryDetailNetflixSubscriptionFee();
            break;
          }
          case 'hboMax': {
            break;
          }
          case 'amazonPrime': {
            break;
          }
          case 'brak': {
            break;
          }
        }
      }
    }
  }

  constructor(
    private readonly _netflixService: NetflixService,
    private readonly _snackBar: MatSnackBar,
    private readonly _activatedRoute: ActivatedRoute,
    private readonly _changeDetectorRef: ChangeDetectorRef
  ) {}

  getCountryDetailNetflixSubscriptionFee(): void {
    this._netflixService
      .getCountryNetflixSubscriptionFee(this.selectedCountryName!)
      .pipe(
        catchError(() => {
          return of(undefined);
        }),
        takeUntil(this._destroy)
      )
      .subscribe((countryFee: NetflixSubscriptionFee | undefined) => {
        if (countryFee) {
          const { id, countryCode, ...countryFeeSubscription } = countryFee;
          this.countryFeeSubscription =
            countryFeeSubscription as SubscriptionFeeViewNetflix;
          this.isCountryData = true;
        } else {
          this.isCountryData = false;

          this._snackBar.open(
            `Nie znaleziono danych o subskrypcjach dla kraju ${this.selectedCountryName}`,
            'Zamknij'
          );
        }
        this._changeDetectorRef.markForCheck();
      });
  }
}
