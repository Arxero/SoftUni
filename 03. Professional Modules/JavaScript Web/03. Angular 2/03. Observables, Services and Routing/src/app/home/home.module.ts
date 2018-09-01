import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { HttpClientModule } from '@angular/common/http'
import { HomeComponent } from './home.components';
import { AboutComponent } from './about.component';

@NgModule({
    declarations: [
        HomeComponent,
        AboutComponent
    ],

    imports: [
        CommonModule,
        HttpClientModule,
    ],

    exports: [
        HomeComponent
    ]
})

export class HomeModule { }