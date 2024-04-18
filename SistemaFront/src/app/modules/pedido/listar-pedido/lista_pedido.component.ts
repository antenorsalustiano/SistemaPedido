import { Component, OnInit } from '@angular/core';
import { faEdit } from '@fortawesome/free-solid-svg-icons';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { PedidoModal } from 'src/app/core/model/pedidoModel';
import { PedidoService } from 'src/app/core/service/pedido.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-lista-pedido',
    templateUrl: './lista_pedido.component.html',
    styleUrls: ['./lista-pedido.component.css']
  })

export class ListarPedidoComponent implements OnInit{
    faEdit = faEdit;
    faTrash = faTrash;
    pedidos: PedidoModal[] = [];

    
  constructor(
    public pedido_service:PedidoService,
    public router:Router
  ) {}

  
  ngOnInit(): void {
    this.carregarPedido();    
  }

  carregarPedido(){
    this.pedido_service.getPedido().subscribe(
        pedidos => {this.pedidos = pedidos}
    )
  }

  excluir(id:number){}
}