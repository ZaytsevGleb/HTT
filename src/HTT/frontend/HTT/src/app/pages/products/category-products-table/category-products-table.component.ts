import {Component, Input} from '@angular/core';
import {ICategoryModel} from "../../../models/category.model";
import {CategoryProducts} from "./category-products.model";
import {ProductItem} from "../product-item.model";

@Component({
  selector: 'category-products-table',
  templateUrl: './category-products-table.component.html',
  styleUrls: ['./category-products-table.component.css']
})
export class CategoryProductsTableComponent {

  categoryProducts: CategoryProducts[] = [];

  @Input() set categories(categories: ICategoryModel[]) {
    this.categoryProducts = categories.map(category => {
      return new CategoryProducts(
        category.name,
        category.products
          .map((product) => new ProductItem(
            product.name,
            product.price
          ))
      )
    });
  }

}
