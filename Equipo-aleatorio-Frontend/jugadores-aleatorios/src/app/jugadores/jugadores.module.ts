import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { MaterialModule } from '../material/material.module';
import { AgregarComponent } from './pages/agregar/agregar.component';
import { ListadoComponent } from './pages/listado/listado.component';

@NgModule({
  declarations: [AgregarComponent, ListadoComponent],
  imports: [
    CommonModule,
    FlexLayoutModule,
    MaterialModule,
    FormsModule
  ]
})
export class JugadoresModule { }
