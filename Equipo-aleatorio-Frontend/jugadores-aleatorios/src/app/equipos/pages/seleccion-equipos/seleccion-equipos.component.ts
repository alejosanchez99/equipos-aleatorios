import { SelectionModel } from '@angular/cdk/collections';
import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Jugador } from '../../../jugadores/interfaces/jugador.interface';
import { SeleccionEquipo, Equipo } from '../../interfaces/equipo.interface';

export interface PeriodicElement {
  name: string;
}

@Component({
  selector: 'app-seleccion-equipos',
  templateUrl: './seleccion-equipos.component.html',
  styleUrls: ['./seleccion-equipos.component.css'],
})
export class SeleccionEquiposComponent {
  seleccionEquipo: SeleccionEquipo = {
    equipoUno: {
      jugadores: [],
    },
    equipoDos: {
      jugadores: [],
    },
  };

  state: any;
  dataSourceEquipoUno: any;
  dataSourceEquipoDos: any;
  displayedColumns: string[] = ['nombreJugador', 'nombreTipoJugador'];

  constructor(private router: Router) {
    this.state = this.router.getCurrentNavigation()?.extras.state;

    if (this.state === null || this.state === undefined) {
      this.Devolver();
    }

    this.seleccionEquipo = this.state.seleccionEquipo;
  }

  ngOnInit(): void {

    this.dataSourceEquipoUno = new MatTableDataSource<Jugador>(
      this.seleccionEquipo.equipoUno.jugadores
    );
    this.dataSourceEquipoDos = new MatTableDataSource<Jugador>(
      this.seleccionEquipo.equipoDos.jugadores
    );
  }

  Devolver() {
    this.router.navigate(['./equipo']);
  }
}
