import { Routes } from '@angular/router';
import { VehiculoComponent } from './vehiculo/vehiculo.component';
import { TipoVehiculoComponent } from './tipo-vehiculo/tipo-vehiculo.component';
import { AsesorComponent } from './asesor/asesor.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    {path: 'app-home', component: HomeComponent},
    {path: 'app-vehiculo', component: VehiculoComponent},
    {path: 'app-tipo-vehiculo', component: TipoVehiculoComponent},
    {path: 'app-asesor', component: AsesorComponent}
];
