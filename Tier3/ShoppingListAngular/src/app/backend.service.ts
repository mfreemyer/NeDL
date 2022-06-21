
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom, Observable } from 'rxjs';
import { ShoppingListItem } from './shopping-list-item';

@Injectable({
  providedIn: 'root'
})
export class BackendService {
  constructor(private http: HttpClient) {}

  async shoppingList(): Promise<ShoppingListItem[]> {
    return firstValueFrom(
      this.http.get<ShoppingListItem[]>('https://localhost:7027/ShoppingList')
    );
  }
}
