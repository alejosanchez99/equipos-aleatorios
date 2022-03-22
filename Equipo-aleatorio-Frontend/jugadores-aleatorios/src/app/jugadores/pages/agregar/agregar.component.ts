import { Component, OnInit } from '@angular/core';

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

  constructor(private jugadorService: JugadoresService) {}

  ngOnInit(): void {}

  guardarJugador() {
     console.log(this.jugador)
    this.jugadorService.guardarJugador(this.jugador).subscribe(resp => {
       console.log('respuesta', resp);
     });
  }
}
