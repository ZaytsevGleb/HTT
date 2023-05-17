import { Injectable } from '@angular/core';
import {map, Observable, pipe} from "rxjs";

import {HttApiClient, ICategoryDto, ProductDto} from "../client/htt-api.client";
import {ICategoryModel} from "../models/category.model";
import {ProductsService} from "./products.service";
import {IProductModel} from "../models/product.model";

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(
    private readonly httAPIClient: HttApiClient,
    private readonly productsService: ProductsService
  ) {}

  getCategories(): Observable<ICategoryModel[]>{
    return this.httAPIClient
      .getCategories()
      .pipe(map(( result ) => result.map(category => this.mapToModel(category))));
  }

  private mapToModel(dto: ICategoryDto):ICategoryModel {
    return {
      id: dto.id!,
      name: dto.name!,
      products: dto.products?.map((x) => this.mapProductToModel(x))!
    }
  }

  private mapProductToModel(dto: ProductDto): IProductModel{
    return {
      id: dto.id!,
      categoryId: dto.categoryId!,
      name: dto.name!,
      price: dto.price!
    }
  }
}
