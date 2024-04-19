export interface Restaurant {
price: any;
description: any;
title: any;
  restaurantId: number;
  restaurantName: string;
  restaurantDescription: string;
  image: string;
  items: Item[];
}

export interface Item {
  itemId: number;
  title: string;
  description: string;
  image: string;
  price: number;
}
