import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

import { JugadoresService } from '../../services/jugadores.service';
import { Jugador } from '../../interfaces/jugador.interface';

@Component({
  selector: 'app-agregar',
  templateUrl: './agregar.component.html',
  styleUrls: ['./agregar.component.css'],
})
export class AgregarComponent implements OnInit {
  tipoJugadores = [
    {
      id: 1,
      nombre: 'Arquero',
    },
    {
      id: 2,
      nombre: 'Defensa',
    },
    {
      id: 3,
      nombre: 'Volante',
    },
    {
      id: 4,
      nombre: 'Delantero',
    },
  ];

  jugador: Jugador = {
    idJugador: 0,
    nombreJugador: '',
    idTipoJugador: 0,
  };

  constructor(private jugadorService: JugadoresService,
              private snackBar: MatSnackBar) { }

  ngOnInit(): void {}

  inicializarJugador() {
    this.jugador = {
      idJugador: 0,
      nombreJugador: '',
      idTipoJugador: 0,
    };
  }
  guardarJugador() {
    this.jugadorService.guardarJugador(this.jugador).subscribe(resp => {
      this.mostrarMensaje('Se ha guardado exitosamente')
      this.inicializarJugador();
    },
      error => {
        this.mostrarMensaje('Ya existe un jugador con ese nombre')
    });
  }

  mostrarMensaje(mensaje: string) {
    this.snackBar.open(mensaje, 'Cerrar', {
      duration: 2000
    });
  }
}
