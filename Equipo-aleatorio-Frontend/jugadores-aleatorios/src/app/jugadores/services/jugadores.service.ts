import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '../../../environments/environment';
import { Jugador } from '../interfaces/jugador.interface';

@Injectable({
  providedIn: 'root'
})
export class JugadoresService {

  private baseUrl: string = environment.baseUrl;

  constructor( private http: HttpClient ) { }

  consultarJugadores(): Observable<Jugador[]> {
    return this.http.get<Jugador[]>(`${ this.baseUrl }/jugador`);
  }

  guardarJugador( jugador: Jugador ): Observable<Jugador> {
    return this.http.post<Jugador>(`${ this.baseUrl }/jugador`, jugador );
  }
}
