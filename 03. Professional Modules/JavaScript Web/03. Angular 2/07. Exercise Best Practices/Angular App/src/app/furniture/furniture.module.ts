import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms';
import { furnitureComponents } from '.';
import { FurnitureService } from './furniture.service';
import { BrowserModule } from '@angular/platform-browser';
import { FurnitureRoutingModule } from './furniture-routing.module';
import { CommonModule } from '@angular/common';
import { NgxPaginationModule } from 'ngx-pagination';

@NgModule({
    declarations: [
        ...furnitureComponents,
    ],
    imports: [
        // BrowserModule,
        CommonModule,
        FormsModule,
        FurnitureRoutingModule,
        NgxPaginationModule
    ],
    providers: [
        FurnitureService
    ],
    // exports: [
    //     // BrowserModule
    //     CommonModule
    // ]
})

export class FurnitureModule { }