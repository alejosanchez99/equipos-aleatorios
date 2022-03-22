import {SelectionModel} from '@angular/cdk/collections';
import {Component} from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';

import { Jugador } from './../../interfaces/jugador.interface';
import { JugadoresService } from '../../services/jugadores.service';
import { EquipoService } from '../../../equipos/services/equipo.service';

@Component({
  selector: 'app-equipo',
  templateUrl: './equipo.component.html',
  styleUrls: ['./equipo.component.css']
})
export class EquipoComponent {

  jugadores: Jugador[] = [];

  constructor(private jugadoresService: JugadoresService,
              private equipoService: EquipoService,
              private router: Router) { }

  displayedColumns: string[] = ['select','idJugador', 'nombreJugador', 'nombreTipoJugador'];
  jugadoresSeleccionados = new SelectionModel<Jugador>(true, []);
  dataSource: any;

  ngOnInit(): void {
    this.jugadoresService.consultarJugadores()
    .subscribe(jugadores => {
      this.jugadores = jugadores;
      this.dataSource = new MatTableDataSource<Jugador>(this.jugadores);
    })
  }

  isAllSelected() {
    const numSelected = this.jugadoresSeleccionados.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  masterToggle() {
    this.isAllSelected() ?
        this.jugadoresSeleccionados.clear() :
        this.dataSource.data.forEach((row: Jugador) => this.jugadoresSeleccionados.select(row));
  }

  seleccionarEquipos() {
    if (this.jugadoresSeleccionados.selected.length > 0) {
      this.equipoService.escogerEquipos(this.jugadoresSeleccionados.selected)
        .subscribe(seleccionEquipo => {
          this.router.navigate(['./seleccion-equipos'], {
            state: {
              seleccionEquipo: seleccionEquipo
            }
          });
        });
    }
  }
}
