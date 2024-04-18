import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CadastroProdutoComponent } from './modules/produto/cadastro-produto/cadastro-produto.component';
import { CadastroPedidoComponent } from './modules/pedido/cadastro-pedido/cadastro-pedido.component';
import { ListarProdutoComponent } from './modules/produto/listar-produto/listar-produto.component';
import { ListarPedidoComponent } from './modules/pedido/listar-pedido/lista_pedido.component';
import { ListarFornecedorComponent } from './modules/fornecedor/listar-fornecedor/listar-fornecedor.component';
import { CadastroFornecedorComponent } from './modules/fornecedor/cadastro-fornecedor/cadastro-fornecedor.component';


const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: '', component: HomeComponent },
  { path: 'pedido', component: CadastroPedidoComponent},
  { path: 'lista-produto', component: ListarProdutoComponent},
  { path: 'produto/:indice', component:CadastroProdutoComponent},
  { path: 'lista-pedido', component:ListarPedidoComponent},
  { path: 'pedido/:indice', component:CadastroPedidoComponent},
  { path: 'lista-fornecedor', component:ListarFornecedorComponent},
  { path: 'fornecedor/:indice', component:CadastroFornecedorComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
