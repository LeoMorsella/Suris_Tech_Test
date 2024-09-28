import { Articulo } from "./articulo";

export class Pedido {
    precio:number;
    articulos:Articulo[];
    estado:string;
    descripcion:string;
}