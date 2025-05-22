import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { VehiculoComponent } from './vehiculo/vehiculo.component';
import { TipoVehiculoComponent } from './tipo-vehiculo/tipo-vehiculo.component';
import { AsesorComponent } from './asesor/asesor.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { VehiculoService } from './vehiculo/services/vehiculo.service';
import { TipoVehiculoService } from './tipo-vehiculo/services/tipo-vehiculo.service';
import { AsesorService } from './asesor/services/asesor.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ReactiveFormsModule, HttpClientModule, VehiculoComponent, TipoVehiculoComponent, AsesorComponent],
  templateUrl: './app.component.html',
  providers:[VehiculoService, TipoVehiculoService, AsesorService]
})
export class AppComponent {
  title = 'Concesionario';
}
