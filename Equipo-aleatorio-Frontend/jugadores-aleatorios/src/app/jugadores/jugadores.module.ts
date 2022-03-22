import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { MaterialModule } from '../material/material.module';
import { AgregarComponent } from './pages/agregar/agregar.component';
import { ListadoComponent } from './pages/listado/listado.component';
import { EquipoComponent } from './pages/equipo/equipo.component';
import { SeleccionEquiposComponent } from './pages/seleccion-equipos/seleccion-equipos.component';
import { BotonFlotanteComponent } from './components/boton-flotante/boton-flotante.component';


@NgModule({
  declarations: [AgregarComponent, ListadoComponent, EquipoComponent, SeleccionEquiposComponent, BotonFlotanteComponent],
  imports: [
    CommonModule,
    FlexLayoutModule,
    MaterialModule,
    FormsModule
  ]
})
export class JugadoresModule { }
