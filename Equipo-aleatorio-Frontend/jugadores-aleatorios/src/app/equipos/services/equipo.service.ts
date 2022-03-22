import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Equipo, SeleccionEquipo } from '../interfaces/equipo.interface';
import { Jugador } from 'src/app/jugadores/interfaces/jugador.interface';

@Injectable({
  providedIn: 'root'
})
export class EquipoService {

  private baseUrl: string = environment.baseUrl;

  constructor( private http: HttpClient ) { }

  escogerEquipos(Jugadores: Jugador[]): Observable<SeleccionEquipo> {
    return this.http.post<SeleccionEquipo>(`${ this.baseUrl }/equipo`, Jugadores );
  }
}
