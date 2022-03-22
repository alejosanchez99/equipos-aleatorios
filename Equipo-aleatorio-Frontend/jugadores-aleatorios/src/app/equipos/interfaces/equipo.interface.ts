import { Jugador } from 'src/app/jugadores/interfaces/jugador.interface';

export interface Equipo {
  jugadores: Jugador[];
}

export interface SeleccionEquipo {
  equipoUno: Equipo,
  equipoDos: Equipo
}
