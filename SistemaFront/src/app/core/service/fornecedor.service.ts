import { FornecedorModal } from "../model/fornecedorModel";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
    providedIn: 'root'
  })

  export class FornecedorService{
    apiUrl = 'http://localhost:5273/api/Fornecedores';
    fornecedor: FornecedorModal[]=[];

    constructor(private http: HttpClient) {}

    getFornecedor(){
        return this.http.get<any>(this.apiUrl);
    }

  }