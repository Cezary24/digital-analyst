import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
} from '@angular/core';
import { ContentListService } from 'src/app/service/content-list.service';
import { CONTENT_LIST_NETFLIX } from './content-list/content-list-netflix';

@Component({
  selector: 'app-netflix-home',
  templateUrl: './netflix-home.component.html',
  styleUrls: ['./netflix-home.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NetflixHomeComponent {
  constructor(private readonly _contentListService: ContentListService) {
    this._contentListService.pageContentList.next(CONTENT_LIST_NETFLIX);
  }
}
