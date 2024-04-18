import { PedidoModal } from "../model/pedidoModel";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
  })

export class PedidoService {
    apiUrl = 'http://localhost:5273/api/Pedido';
    pedido: PedidoModal[] = [];

    constructor(private http: HttpClient) {}

    getPedido(){
        return this.http.get<any>(this.apiUrl);
    }

    getPedidoById(id:number){
        return this.http.get<PedidoModal>(`${this.apiUrl}/${id}`);
    }
}