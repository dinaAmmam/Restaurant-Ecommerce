import { Component, OnInit } from '@angular/core';
import { RestaurantService } from '../../../services/restaurant.service';
import { CommonModule, NgClass } from '@angular/common';
import { Router } from '@angular/router';
import { ItemComponent } from "../../item/item.component";

@Component({
    selector: 'app-home',
    standalone: true,
    templateUrl: './home.component.html',
    styleUrl: './home.component.css',
    imports: [NgClass, CommonModule, ItemComponent]
})
export class HomeComponent implements OnInit {


  restaurants!: any[];
   items: any;
  constructor(private restaurantService: RestaurantService,private router:Router){}

  ngOnInit(): void {
    this.getRestaurants();
  }

  getRestaurants(): void {
    this.restaurantService.getRestaurants()
      .subscribe(restaurants => this.restaurants = restaurants);
  }
  showItems(restaurantId: number): void {
    this.router.navigate(['/items', restaurantId]);
  }
}

