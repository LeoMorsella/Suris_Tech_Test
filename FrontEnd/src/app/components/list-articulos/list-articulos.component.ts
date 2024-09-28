import { Component } from '@angular/core';
import { ArticuloService } from '../../services/articulo.service';
import { NgFor } from '@angular/common';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-list-articulos',
  standalone: true,
  imports: [NgFor, FormsModule],
  templateUrl: './list-articulos.component.html',
  styleUrl: './list-articulos.component.css'
})
export class ListArticulosComponent {

  constructor(public articuloService: ArticuloService) {

  }
  ngOnInit(): void {
    this.articuloService.obtenerArticulos();
  }
}
