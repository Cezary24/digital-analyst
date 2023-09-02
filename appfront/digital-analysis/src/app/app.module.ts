import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgxEchartsModule } from 'ngx-echarts';
import { SidebarModule } from './components/sidebar/sidebar.module';
import { ChartComponent } from './components/chart/chart.component';
import { LeafletModule } from '@asymmetrik/ngx-leaflet';
import { MapsModule } from './components/maps/maps.module';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './components/home/home.component';
import { NetflixModule } from './components/netflix/netflix-home/netflix.module';
import { AmazonPrimeModule } from './components/amazon-prime/amazon-prime-home/amazon-prime-home.module';
import { HboMaxModule } from './components/hbo-max/hbo-max-home/hbo-max.module';

@NgModule({
  declarations: [AppComponent, ChartComponent, HomeComponent],
  imports: [
    BrowserModule,
    SidebarModule,
    BrowserAnimationsModule,
    LeafletModule,
    HttpClientModule,
    MapsModule,
    NetflixModule,
    AmazonPrimeModule,
    HboMaxModule,
    NgxEchartsModule.forRoot({
      echarts: () => import('echarts'),
    }),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
