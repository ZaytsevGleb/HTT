import {ProductItem} from "../product-item.model";

export class CategoryProducts{
  constructor(
   public name: string,
   public products: ProductItem[]
  ) {
  }
}
