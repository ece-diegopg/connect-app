import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import {Router} from "@angular/router";
import { ProductDialogComponent } from 'src/app/products/components/product-dialog/product-dialog.component';
import{Product} from "../../../core/models/product";
import {ProductService} from "../../../products/shared/product.service";


@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {
  productToCreate:Product = {
    productId:0,
    code:"",
    name:"",
    description:"",
    price:0
  }

  constructor(private router:Router, public dialog:MatDialog, private productService:ProductService) { }

  ngOnInit(): void {
  }
  toHome(){
    this.router.navigate(['products']);
  }
  addProduct(){
    this.openDialog();
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(ProductDialogComponent, {
      width: '400px',
      data: Object.assign({}, this.productToCreate)//los objetos son pasados por referencia.
    });

    dialogRef.afterClosed()
      .subscribe(result => {
      console.log("afterClose");
      console.log(result );
      if(result != false){
      this.productService.PostProduct(result).subscribe(p =>{
        console.log(p);
      })}
      result = this.productToCreate;
    });
  }


}
