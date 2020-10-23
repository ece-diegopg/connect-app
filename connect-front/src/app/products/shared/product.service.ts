import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, } from '@angular/common/http'
import {Product} from "../../core/models/product";
import { Observable } from 'rxjs';
//conexion a la api
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  Url:string = 'https://connect-backend.azurewebsites.net/products';

  constructor(private http:HttpClient) { }
  //productos
  GetProducts():Observable<Product[]>{
    return this.http.get<Product[]>(this.Url);
  }
  //un producto solo
  GetProductById(productId:number):Observable<Product>{
    return this.http.get<Product>(`${this.Url}/${productId}`);
  }
  //añadir producto
  PostProduct(product: Product):Observable<any>{
    return this.http.post<Product>(this.Url, product);
  }
  //eliminar producto
  DeleteProduct(productId:number):Observable<any>{
    let httpOptions ={
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
    return this.http.delete(`${this.Url}/${productId}`, httpOptions);
  }
}
