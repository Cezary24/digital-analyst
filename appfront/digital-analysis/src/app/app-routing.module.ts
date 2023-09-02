import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChartComponent } from './components/chart/chart.component';
import { MapComponent } from './components/maps/map.component';
import { HomeComponent } from './components/home/home.component';
import { NetflixHomeComponent } from './components/netflix/netflix-home/netflix-home.component';
import { HboMaxHomeComponent } from './components/hbo-max/hbo-max-home/hbo-max-home.component';
import { AmazonPrimeHomeComponent } from './components/amazon-prime/amazon-prime-home/amazon-prime-home.component';

const routes: Routes = [
  { path: 'netflix', component: NetflixHomeComponent },
  { path: 'hbo-max', component: HboMaxHomeComponent },
  { path: 'amazon-prime', component: AmazonPrimeHomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'chart', component: ChartComponent },
  { path: 'map', component: MapComponent },
  { path: '', component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
