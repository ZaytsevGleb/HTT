import {Component, OnInit} from '@angular/core';
import {ProductsService} from "../../services/products.service";
import {IProductModel} from "../../models/product.model";
import {CategoriesService} from "../../services/categories.service";
import {ICategoryModel} from "../../models/category.model";

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: IProductModel[] = [];
  categories: ICategoryModel[] = [];

  constructor(
    private readonly productsService: ProductsService,
    private  readonly categoriesService: CategoriesService) {}

  ngOnInit(): void {
   this.productsService.getProducts()
     .subscribe(products => {this.products = products});

   this.categoriesService.getCategories()
     .subscribe(categories => {this.categories = categories})
  }
}
