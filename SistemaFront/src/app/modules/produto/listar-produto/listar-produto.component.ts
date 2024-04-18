import { Component, OnInit } from '@angular/core';
import { faEdit } from '@fortawesome/free-solid-svg-icons';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { ProdutoService } from '../../../core/service/produto.service';
import { ProdutoModel } from 'src/app/core/model/produtoModel';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listar-produto',
  templateUrl: './listar-produto.component.html',
  styleUrls: ['./listar-produto.component.css']
})

export class ListarProdutoComponent implements OnInit{
  faEdit = faEdit;
  faTrash = faTrash;
  produtos: ProdutoModel[] = [];

  constructor(
      public produto_service:ProdutoService,
      public router:Router
    ) {}

  ngOnInit(): void {
    this.carregarProduto();

    
  }

  carregarProduto(){
    this.produto_service.getProduto().subscribe(
      produtos => {this.produtos = produtos}
    )
  }

  excluir(indice:number){
    const confirmarExclusao = confirm('Tem certeza que deseja excluir este produto?');

    if(confirmarExclusao){

    this.produto_service.excluirProduto(indice).subscribe(
      Response => {
        console.log("Cadastro excluido com sucesso.");
        this.carregarProduto();
      }
    )
  }
  }

  editar(indice:number){
    this.router.navigateByUrl('produto/' + indice);
  }
}
