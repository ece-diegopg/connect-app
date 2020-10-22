import { Component, OnInit , Input} from '@angular/core';
import { Product } from 'src/app/core/models/product';
import {Router} from "@angular/router"

@Component({
  selector: 'app-product-card',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css']
})
export class ProductCardComponent implements OnInit {
  @Input() product: Product;

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  /*onView(product:Product){
    this.router.navigate(['/products', this.product.productId])
  }*/
  onView(product:Product){
    this.router.navigate(['/products', product.productId]);
  }
}
