import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NetflixHomeComponent } from './netflix-home.component';
import { MatGridListModule } from '@angular/material/grid-list';
import { ChartModule } from '../../chart/chart.module';

@NgModule({
  imports: [CommonModule, MatGridListModule, ChartModule],
  declarations: [NetflixHomeComponent],
  exports: [NetflixHomeComponent],
})
export class NetflixModule {}
