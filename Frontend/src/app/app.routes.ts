import { Routes } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { ItemComponent } from './item/item.component';

export const routes: Routes = [{path:'home',component:HomeComponent},
{ path: 'items/:restaurantId', component: ItemComponent } 
];
