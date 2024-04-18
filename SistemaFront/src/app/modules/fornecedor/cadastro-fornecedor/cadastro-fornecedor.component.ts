import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FornecedorModal } from 'src/app/core/model/fornecedorModel';
import { FornecedorService } from 'src/app/core/service/fornecedor.service';


@Component({
    selector: 'app-cadastro-fornecedor',
    templateUrl: './cadastro-fornecedor.component.html',
    styleUrls: ['./cadastro-fornecedor.component.css']
  })

  export class CadastroFornecedorComponent implements OnInit {
  fornecedor: FornecedorModal[] = [];
  titulo: string = 'Cadastro Fornecedor';
  btnSalvar: string = 'Cadastrar';
  public emailContato: string = '';
  public uf: string ='';
  public nomeContato: string = '';
  public cnpj: string = '';

  public indice:number = -1;

  
  constructor(
    public actived_route:ActivatedRoute,
    public fornecedor_service:FornecedorService,
    public router:Router
  ){}

  ngOnInit(): void {


  }
}