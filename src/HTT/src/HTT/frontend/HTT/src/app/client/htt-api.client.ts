//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

import { mergeMap as _observableMergeMap, catchError as _observableCatch } from 'rxjs/operators';
import { Observable, throwError as _observableThrow, of as _observableOf } from 'rxjs';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';

export const API_BASE_URL = new InjectionToken<string>('API_BASE_URL');

@Injectable()
export class HttApiClient {
    private http: HttpClient;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
        this.http = http;
        this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : "";
    }

    /**
     * @return Success
     */
    getCategories(): Observable<CategoryDto[]> {
        let url_ = this.baseUrl + "/api/categories";
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetCategories(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetCategories(response_ as any);
                } catch (e) {
                    return _observableThrow(e) as any as Observable<CategoryDto[]>;
                }
            } else
                return _observableThrow(response_) as any as Observable<CategoryDto[]>;
        }));
    }

    protected processGetCategories(response: HttpResponseBase): Observable<CategoryDto[]> {
        const status = response.status;
        const responseBlob =
            response instanceof HttpResponse ? response.body :
            (response as any).error instanceof Blob ? (response as any).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }}
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            if (Array.isArray(resultData200)) {
                result200 = [] as any;
                for (let item of resultData200)
                    result200!.push(CategoryDto.fromJS(item));
            }
            else {
                result200 = <any>null;
            }
            return _observableOf(result200);
            }));
        } else if (status === 500) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            let result500: any = null;
            let resultData500 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result500 = ErrorDto.fromJS(resultData500);
            return throwException("Server Error", status, _responseText, _headers, result500);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf(null as any);
    }

    /**
     * @return Success
     */
    getProducts(): Observable<ProductDto[]> {
        let url_ = this.baseUrl + "/api/products";
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetProducts(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetProducts(response_ as any);
                } catch (e) {
                    return _observableThrow(e) as any as Observable<ProductDto[]>;
                }
            } else
                return _observableThrow(response_) as any as Observable<ProductDto[]>;
        }));
    }

    protected processGetProducts(response: HttpResponseBase): Observable<ProductDto[]> {
        const status = response.status;
        const responseBlob =
            response instanceof HttpResponse ? response.body :
            (response as any).error instanceof Blob ? (response as any).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }}
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            if (Array.isArray(resultData200)) {
                result200 = [] as any;
                for (let item of resultData200)
                    result200!.push(ProductDto.fromJS(item));
            }
            else {
                result200 = <any>null;
            }
            return _observableOf(result200);
            }));
        } else if (status === 500) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            let result500: any = null;
            let resultData500 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result500 = ErrorDto.fromJS(resultData500);
            return throwException("Server Error", status, _responseText, _headers, result500);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf(null as any);
    }
}

export class CategoryDto implements ICategoryDto {
    id?: string;
    name?: string | undefined;
    products?: ProductDto[] | undefined;
    createdDate?: Date;

    constructor(data?: ICategoryDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            if (Array.isArray(_data["products"])) {
                this.products = [] as any;
                for (let item of _data["products"])
                    this.products!.push(ProductDto.fromJS(item));
            }
            this.createdDate = _data["createdDate"] ? new Date(_data["createdDate"].toString()) : <any>undefined;
        }
    }

    static fromJS(data: any): CategoryDto {
        data = typeof data === 'object' ? data : {};
        let result = new CategoryDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        if (Array.isArray(this.products)) {
            data["products"] = [];
            for (let item of this.products)
                data["products"].push(item.toJSON());
        }
        data["createdDate"] = this.createdDate ? this.createdDate.toISOString() : <any>undefined;
        return data;
    }
}

export interface ICategoryDto {
    id?: string;
    name?: string | undefined;
    products?: ProductDto[] | undefined;
    createdDate?: Date;
}

export class ErrorDto implements IErrorDto {
    message?: string | undefined;
    details?: string | undefined;

    constructor(data?: IErrorDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.message = _data["message"];
            this.details = _data["details"];
        }
    }

    static fromJS(data: any): ErrorDto {
        data = typeof data === 'object' ? data : {};
        let result = new ErrorDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["message"] = this.message;
        data["details"] = this.details;
        return data;
    }
}

export interface IErrorDto {
    message?: string | undefined;
    details?: string | undefined;
}

export class ProductDto implements IProductDto {
    id?: string;
    categoryId?: string;
    name?: string | undefined;
    price?: number;
    createdDate?: Date;

    constructor(data?: IProductDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.categoryId = _data["categoryId"];
            this.name = _data["name"];
            this.price = _data["price"];
            this.createdDate = _data["createdDate"] ? new Date(_data["createdDate"].toString()) : <any>undefined;
        }
    }

    static fromJS(data: any): ProductDto {
        data = typeof data === 'object' ? data : {};
        let result = new ProductDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["categoryId"] = this.categoryId;
        data["name"] = this.name;
        data["price"] = this.price;
        data["createdDate"] = this.createdDate ? this.createdDate.toISOString() : <any>undefined;
        return data;
    }
}

export interface IProductDto {
    id?: string;
    categoryId?: string;
    name?: string | undefined;
    price?: number;
    createdDate?: Date;
}

export class ApiException extends Error {
    override message: string;
    status: number;
    response: string;
    headers: { [key: string]: any; };
    result: any;

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isApiException = true;

    static isApiException(obj: any): obj is ApiException {
        return obj.isApiException === true;
    }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): Observable<any> {
    if (result !== null && result !== undefined)
        return _observableThrow(result);
    else
        return _observableThrow(new ApiException(message, status, response, headers, null));
}

function blobToText(blob: any): Observable<string> {
    return new Observable<string>((observer: any) => {
        if (!blob) {
            observer.next("");
            observer.complete();
        } else {
            let reader = new FileReader();
            reader.onload = event => {
                observer.next((event.target as any).result);
                observer.complete();
            };
            reader.readAsText(blob);
        }
    });
}