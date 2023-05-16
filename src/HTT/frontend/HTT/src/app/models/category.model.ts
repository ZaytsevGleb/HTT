import {IProductModel} from "./product.model";

export interface ICategoryModel {
  id: string,
  name: string
  products: IProductModel[]
}
