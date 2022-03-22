import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { MaterialModule } from '../material/material.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';

import { SharedRoutingModule } from "./shared-routing.module";
import { JugadoresModule } from '../jugadores/jugadores.module';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    FlexLayoutModule,
    FormsModule,
    MaterialModule,
    JugadoresModule,
    SharedRoutingModule
  ],
  exports: [
    HomeComponent
  ]
})
export class SharedModule { }
