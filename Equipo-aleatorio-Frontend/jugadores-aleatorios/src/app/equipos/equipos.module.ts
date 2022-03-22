import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MaterialModule } from '../material/material.module';

import { BotonFlotanteComponent } from './components/boton-flotante/boton-flotante.component';
import { SeleccionEquiposComponent } from './../equipos/pages/seleccion-equipos/seleccion-equipos.component';
import { EquipoComponent } from '../jugadores/pages/equipo/equipo.component';


@NgModule({
  declarations: [BotonFlotanteComponent, SeleccionEquiposComponent, EquipoComponent],
  imports: [
    CommonModule,
    FlexLayoutModule,
    MaterialModule,
    FormsModule
  ]
})
export class EquiposModule { }
