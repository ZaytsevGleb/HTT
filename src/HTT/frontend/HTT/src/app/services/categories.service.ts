import { Injectable } from '@angular/core';
import {map, Observable} from "rxjs";

import {HttApiClient, ICategoryDto} from "../client/htt-api.client";
import {ICategoryModel} from "../models/category.model";

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(
    private readonly httAPIClient: HttApiClient
  ) {}

  getCategories(): Observable<ICategoryModel[]>{
    return this.httAPIClient
      .getCategories()
      .pipe(map(( result ) => result.map(category => this.mapToModel(category))));
  }

  private mapToModel(dto: ICategoryDto):ICategoryModel {
    return {
      id: dto.id!,
      name: dto.name!
    }
  }
}
