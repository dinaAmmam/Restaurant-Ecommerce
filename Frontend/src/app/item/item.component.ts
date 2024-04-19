import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RestaurantService } from '../../services/restaurant.service';
import { CommonModule } from '@angular/common';
import { Item, Restaurant } from '../data';

@Component({
  selector: 'app-item',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {
  restaurantId!: number;
  restaurant: any;
  items: Restaurant[] = [];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private restaurantService: RestaurantService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.restaurantId = +params['restaurantId'];
      if (this.restaurantId) {
        this.fetchRestaurantWithItems();
      } else {
        this.router.navigate(['/default']);
      }
    });
  }
  fetchRestaurantWithItems(): void {
    this.restaurantService.getItemsByRestaurantId(this.restaurantId).subscribe({
      next: (data: any) => {
        console.log("Restaurant:", data.restaurant);
        console.log("Items:", data.items);

        this.restaurant = data.restaurant;
        this.items = data.items;
      },
      error: (error) => {
        console.error('Error fetching restaurant with items:', error);
      }
    });
  }


}
