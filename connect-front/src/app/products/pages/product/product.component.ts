import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from 'src/app/core/models/product';
import { ProductService } from '../../shared/product.service'

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  product:Product;
  productId:number;

  constructor(private route: ActivatedRoute,
              private productService:ProductService,
              private router:Router){
    this.product = {
      productId:null,
      code:"",
      name:"",
      description:"",
      price:null
    };
   }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.productService
        .GetProductById(+params.get('productId'))
        .subscribe(product =>{
          this.product = product;}
        );
    });
  }
  deleteItem(product:Product): void{
    if(confirm("Desea eliminar este producto?")){
      this.router.navigate(['/products'])
      this.productService.DeleteProduct(product.productId)
      .subscribe(p => console.log(p)
      );//p:producto
    }
  }
  editItem(product:Product){
    console.log("Editar "+product)
  }


}
