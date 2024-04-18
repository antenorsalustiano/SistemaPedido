import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProdutoService } from '../../../core/service/produto.service';
import { ProdutoModel } from 'src/app/core/model/produtoModel';


@Component({
  selector: 'app-cadastro-produto',
  templateUrl: './cadastro-produto.component.html',
  styleUrls: ['./cadastro-produto.component.css']
})
export class CadastroProdutoComponent implements OnInit{
  produtos: ProdutoModel[] = [];
  titulo: string = 'Cadastro Produto';
  btnSalvar: string = 'Cadastrar';
  public descricao:string = '';
  public valor:number = 0;
  public codigo:string = '';
  public display_success:boolean = false;
  public display_error:boolean = false;
  
  public indice:number = -1;

  constructor(
    public actived_route:ActivatedRoute,
    public produto_service:ProdutoService,
    public router:Router
  ){}

  ngOnInit(): void {
    this.actived_route.params.subscribe((params:any) => {
      
      if (params.indice > -1){
        this.indice = params.indice;
        this.buscarProdutoPorId(this.indice);
        this.titulo = "Editar Produto";
        this.btnSalvar = "Alterar";
      }
    });
  }

  cadastroProduto(): void{

    const novoProduto: ProdutoModel = {
      produtoId: 0,
      codigo: this.codigo,
      descricao: this.descricao,
      dataCadastro: new Date(),
      valor: this.valor
    };

    if(this.indice > 0)
      {
        novoProduto.produtoId = this.indice;
        this.produto_service.atualizarProduto(this.indice,novoProduto).subscribe(
          Response => {
            this.display_s();
          },
          (error) => {
            
            this.display_e();
          }
        );
      }
      else{
    

    this.produto_service.cadastrarProduto(novoProduto).subscribe(
      (response) => {
        console.log('Produto cadastrado com sucesso!', response);
        this.display_s();
      },
      (error) => {
        console.error('Erro ao cadastrar produto:', error);
        this.display_e();
      }
    );
  }
  }

  buscarProdutoPorId(id: number): void {
    this.produto_service.getProdutoById(id).subscribe(
      (produto) => {
        this.produtos = [produto];
        this.descricao = produto.descricao;
        this.codigo = produto.codigo;
        this.valor = produto.valor;
        console.log('Produto encontrado:', produto);
      },
      (error) => {
        console.error('Erro ao buscar produto por ID:', error);
      }
    );
  }


  display_s() {
    this.display_success = true;
  }

  display_e(){
    this.display_error = true;
  }

  clear() {
    this.descricao = '';
    this.valor = 0;
  }

  voltar(){
    this.router.navigateByUrl('lista-produto');
  }
}
