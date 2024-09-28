import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Vendedor } from '../models/vendedor';

@Injectable({
  providedIn: 'root'
})
export class VendedorService {
  myUrl = 'https://localhost:7136/api/Vendor';
  list: Vendedor[];
  constructor(private http: HttpClient) { }

  obtenerVendedores() {
    this.http.get(this.myUrl).toPromise().then(data => {
            this.list = data as Vendedor[];
    });
}
}
