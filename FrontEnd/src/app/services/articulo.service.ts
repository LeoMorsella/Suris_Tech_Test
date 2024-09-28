import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Articulo } from '../models/articulo';
import { Pedido } from '../models/pedido';

@Injectable({
  providedIn: 'root'
})
export class ArticuloService {

  myApUrl = 'https://localhost:7136/';
  myApiUrl = 'api/Articulos/';
  myPedidoUrl = 'api/Pedido/';
  list: Articulo[];
  selectedList: Articulo[];
  estado : string = ""
  descripcion: string = ""
  precio:string
  constructor(private http: HttpClient) { }

  obtenerArticulos() {
    this.http.get(this.myApUrl + this.myApiUrl).toPromise().then(data => {
            this.list = data as Articulo[];
    });
  }
  guardarPedido() {
    this.generateJson();
    this.obtenerArticulosTabla();
   }

   generateJson() {
    const selectedItems = this.list.filter(item => item.checked);
    this.http.post<any>(this.myApUrl + this.myPedidoUrl, selectedItems).subscribe();
  }

  obtenerArticulosTabla() {
    this.http.get<Pedido>(this.myApUrl + this.myPedidoUrl).subscribe(
      data => {
        this.precio = data.precio.toString();
        this.estado = data.estado;
        this.descripcion = data.descripcion;
      }
    );
  }
}
