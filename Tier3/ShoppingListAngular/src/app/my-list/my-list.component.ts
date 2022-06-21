import { Component, OnInit } from '@angular/core';
import { BackendService } from '../backend.service';
import { ShoppingListItem } from '../shopping-list-item';

@Component({
  selector: 'app-my-list',
  templateUrl: './my-list.component.html',
  styleUrls: ['./my-list.component.css'],
})
export class MyListComponent implements OnInit {
  shoppingList: ShoppingListItem[] | undefined;

  constructor(private backend: BackendService) {}

  async ngOnInit() {
    this.shoppingList = await this.backend.shoppingList();
    console.log(JSON.stringify(this.shoppingList));
  }
}
