import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { VendedorService } from '../../services/vendedor.service';

@Component({
  selector: 'app-vendedores',
  standalone: true,
  imports: [NgFor],
  templateUrl: './vendedores.component.html',
  styleUrl: './vendedores.component.css'
})
export class VendedoresComponent {
  constructor(public vendedorService: VendedorService) {

  }
  ngOnInit(): void {
    this.vendedorService.obtenerVendedores();
  }
}
