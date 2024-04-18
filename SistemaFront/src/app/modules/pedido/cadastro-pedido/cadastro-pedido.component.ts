import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PedidoModal } from 'src/app/core/model/pedidoModel';
import { PedidoService } from 'src/app/core/service/pedido.service';

@Component({
  selector: 'app-cadastro-pedido',
  templateUrl: './cadastro-pedido.component.html',
  styleUrls: ['./cadastro-pedido.component.css']
})
export class CadastroPedidoComponent implements OnInit {
  pedidos: PedidoModal[] = [];
  titulo: string = 'Cadastro Produto';
  btnSalvar: string = 'Cadastrar';
  public nome:string = '';
  public produto:string = '';
  public quantidade:string = '';
  public data:string = '';
  public dataPedido:string = '';
  public display_success:boolean = false;
  public display_error:boolean = false;

  public indice:number = -1;

  
  constructor(
    public actived_route:ActivatedRoute,
    public pedido_service:PedidoService,
    public router:Router
  ){}

  
  ngOnInit(): void {
    this.actived_route.params.subscribe((params:any) => {
      
      if (params.indice > -1){
        this.indice = params.indice;
        this.buscarPedidoPorId(this.indice);
        this.titulo = "Editar Produto";
        this.btnSalvar = "Alterar";
      }
    });
  }

  buscarPedidoPorId(id: number){

    this.pedido_service.getPedidoById(id).subscribe(
      (pedido) =>{
        this.pedidos = [pedido];
        this.quantidade = pedido.quantidadeProdutos.toString();
        this.dataPedido = pedido.dataPedido.toString();
      }
    )
  }

  cadastroPedido(): void{}

  display_s() {
    this.display_success = true;
  }

  display_e(){
    this.display_error = true;
  }

  clear() {
    this.nome = '';
    this.produto = '';
    this.quantidade = '';
    this.data = ''
  }

  limpar(){
    this.display_success = false;
    this.display_error = false;
    this.nome = '';
    this.quantidade = '';
  }

  
  voltar(){
    this.router.navigateByUrl('lista-pedido');
  }
}
