import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NetflixHomeComponent } from './netflix-home.component';

@NgModule({
  imports: [CommonModule],
  declarations: [NetflixHomeComponent],
  exports: [NetflixHomeComponent],
})
export class NetflixModule {}
