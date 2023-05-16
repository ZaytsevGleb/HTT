import {Injectable} from '@angular/core';
import {map, Observable} from "rxjs";

import {HttApiClient, ICategoryDto, IProductDto} from "../client/htt-api.client";
import {IProductModel} from "../models/product.model";

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(
    private httAPIClient: HttApiClient
  ) {}

  getProducts(): Observable<IProductModel[]> {
    return this.httAPIClient
      .getProducts()
      .pipe(map(( result ) => result.map(product => this.mapToModel(product))));
  }

  private mapToModel(dto: IProductDto): IProductModel {
    return {
      id: dto.id!,
      categoryId: dto.categoryId!,
      name: dto.name!,
      price: dto.price!
    }
  }
}
