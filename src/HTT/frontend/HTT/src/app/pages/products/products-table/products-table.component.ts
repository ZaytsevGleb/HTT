import {Component, Input} from '@angular/core';
import {IProductModel} from "../../../models/product.model";
import {ProductItem} from "./product-item.model";
import {ICategoryModel} from "../../../models/category.model";

@Component({
  selector: 'products-table',
  templateUrl: './products-table.component.html',
  styleUrls: ['./products-table.component.css']
})
export class ProductsTableComponent {

  productItems: ProductItem[] = [];

  @Input() categories!: ICategoryModel[];

  @Input() set products(products: IProductModel[]) {
    this.productItems = products.map(product => {
      return new ProductItem(
        product.id,
        this.categories?.find(x => x.id = product.categoryId)!.name,
        product.name,
        product.price
      )
    })
  }
}
