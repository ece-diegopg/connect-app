import { Component, OnInit } from '@angular/core';
import{ Product } from '../../../core/models/product';
import {ProductService} from '../../shared/product.service'

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
  //template:`<app-product-card *ngFor="let product of products" [product]= 'product'></app-product-card>`
})
export class ProductsComponent implements OnInit {
  products: Product[]//lista de productos
  
  constructor(private productService:ProductService) {}
  ngOnInit(): void {
    //this.products = this.productService.getProducts()
    this.productService.GetProducts().subscribe(products =>{
        this.products = products;}
    );
  }

}
