import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductsComponent } from './pages/products/products.component'
import { ProductComponent } from './pages/product/product.component';

const routes: Routes = [
  { path: 'products', component: ProductsComponent },
  { path: 'products/:productId', component: ProductComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
