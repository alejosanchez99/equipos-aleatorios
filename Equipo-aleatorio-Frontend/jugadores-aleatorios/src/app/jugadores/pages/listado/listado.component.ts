import { AfterViewInit, ChangeDetectorRef, Component, ViewChild, OnInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Jugador } from '../../interfaces/jugador.interface';
import { JugadoresService } from '../../services/jugadores.service';

@Component({
  selector: 'app-listado',
  templateUrl: './listado.component.html',
  styleUrls: ['./listado.component.css'],
})

export class ListadoComponent implements OnInit {

  jugadores: Jugador[] = [];

  constructor(private jugadoresService: JugadoresService){}

  ngOnInit(): void {
    this.jugadoresService.consultarJugadores()
    .subscribe(jugadores => {
      this.jugadores = jugadores;
      this.dataSource = new MatTableDataSource<Jugador>(this.jugadores);
    })
  }
  displayedColumns: string[] = ['idJugador', 'nombreJugador', 'nombreTipoJugador'];
  dataSource: any;

  @ViewChild('paginator') set paginator(pager:MatPaginator) {
    if (pager) this.dataSource.paginator = pager;
  }
}
