import {Component, OnInit} from '@angular/core';
import {CategoriesService} from "../../services/categories.service";
import {ICategoryModel} from "../../models/category.model";

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  categories: ICategoryModel[] = [];

  constructor(
    private readonly categoriesService: CategoriesService) {
  }

  ngOnInit(): void {
    this.categoriesService.getCategories()
      .subscribe(categories => {
        this.categories = categories
      })
  }
}
