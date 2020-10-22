import { Component, OnInit, Inject } from '@angular/core';
import {MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Product } from '../../../core/models/product';
@Component({
  selector: 'app-product-dialog',
  templateUrl: './product-dialog.component.html',
  styleUrls: ['./product-dialog.component.css']
})
export class ProductDialogComponent implements OnInit {
  product:Product;
  constructor(public dialogRef: MatDialogRef<ProductDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Product) { 
      this.product = data;
    }
  
  onNoClick(): void{
    console.log("onNoClick")
    console.log(this.product)
    this.data = this.product;
    this.dialogRef.close(false);
  }
  ngOnInit(): void {
  }

}
