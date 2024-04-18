import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { LeyoutComponent } from './leyout/leyout.component';
import { MenuComponent } from './modules/menu/menu.component';
import { HomeComponent } from './home/home.component';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';
import { CadastroProdutoComponent } from './modules/produto/cadastro-produto/cadastro-produto.component';
import { CadastroPedidoComponent } from './modules/pedido/cadastro-pedido/cadastro-pedido.component';
import { ListarProdutoComponent } from './modules/produto/listar-produto/listar-produto.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ListarPedidoComponent } from './modules/pedido/listar-pedido/lista_pedido.component';
import { ListarFornecedorComponent } from './modules/fornecedor/listar-fornecedor/listar-fornecedor.component';
import { CadastroFornecedorComponent } from './modules/fornecedor/cadastro-fornecedor/cadastro-fornecedor.component';


@NgModule({
  declarations: [
    AppComponent,
    LeyoutComponent,
    MenuComponent,
    HomeComponent,
    CadastroProdutoComponent,
    CadastroPedidoComponent,
    ListarProdutoComponent,
    ListarPedidoComponent,
    ListarFornecedorComponent,
    CadastroFornecedorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    FontAwesomeModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
