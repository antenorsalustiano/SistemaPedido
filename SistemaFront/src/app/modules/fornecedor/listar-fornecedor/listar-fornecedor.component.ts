import { Component, OnInit } from '@angular/core';
import { faEdit } from '@fortawesome/free-solid-svg-icons';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { Router } from '@angular/router';
import { FornecedorModal } from 'src/app/core/model/fornecedorModel';
import { FornecedorService } from 'src/app/core/service/fornecedor.service';


@Component({
    selector: 'app-listar-fornecedor',
    templateUrl: './listar-fornecedor.component.html',
    styleUrls: ['./listar-fornecedor.component.css']
  })


export class ListarFornecedorComponent implements OnInit{

    faEdit = faEdit;
    faTrash = faTrash;
    fornecedor: FornecedorModal[]=[];

     
  constructor(
    public fornecedor_service:FornecedorService,
    public router:Router
  ) {}


    ngOnInit(): void {
        this.carregarFornecedor();    
      }
    
      carregarFornecedor(){
        this.fornecedor_service.getFornecedor().subscribe(
            fornecedor => {this.fornecedor = fornecedor}
        )
      }

      excluir(id: number){

      }

      editar(id:number){}

}