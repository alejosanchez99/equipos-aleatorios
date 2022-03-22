export interface Jugador {
  idJugador: number;
  nombreJugador: string;
  idTipoJugador: number;
  tipoJugador?: TipoJugador
}

export interface TipoJugador {
  idTipoJugador: number;
  nombreTipoJugador: string;
}
