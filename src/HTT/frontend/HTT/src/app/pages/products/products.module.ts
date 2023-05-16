import {ProductsTableComponent} from "./products-table/products-table.component";
import {NgModule} from "@angular/core";
import {ProductsComponent} from "./products.component";
import {ProductsService} from "../../services/products.service";
import {CategoriesService} from "../../services/categories.service";
import {NgForOf} from "@angular/common";

@NgModule({
  declarations: [
    ProductsComponent,
    ProductsTableComponent
  ],
  exports: [
    ProductsComponent
  ],
  imports: [
    NgForOf
  ],
  providers: [
    ProductsService,
    CategoriesService]
})
export class ProductsModule {
}
