import { Component, NgModule } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListArticulosComponent } from "./components/list-articulos/list-articulos.component";
import { CommonModule, NgFor } from '@angular/common';
import { VendedoresComponent } from "./components/vendedores/vendedores.component";
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ListArticulosComponent, NgFor, VendedoresComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'FrontEnd_Suris';
}
