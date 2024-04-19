import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Item, Restaurant } from '../app/data';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  private apiUrl = 'http://localhost:5287/api/Restaurant';

  constructor(private http: HttpClient) { }

  getRestaurants(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
  getItemsByRestaurantId(restaurantId: number): Observable<{ restaurant: Restaurant, items: Item[] }> {
    return this.http.get<{ restaurant: Restaurant, items: Item[] }>(`${this.apiUrl}/${restaurantId}`);
  }
}
