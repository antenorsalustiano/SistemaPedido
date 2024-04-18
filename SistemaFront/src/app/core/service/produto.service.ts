import { Injectable } from '@angular/core';
import { ProdutoModel } from '../model/produtoModel';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProdutoService {
  apiUrl = 'http://localhost:5273/api/Produto';
  produto: ProdutoModel[] = [];
  
  constructor(private http: HttpClient) {}
 
  getProduto(){
    return this.http.get<any>(this.apiUrl);
  }
 
  getProdutoById(id: number): Observable<ProdutoModel> {
    return this.http.get<ProdutoModel>(`${this.apiUrl}/${id}`);
  }

  cadastrarProduto(produto:ProdutoModel){
    return this.http.post(this.apiUrl, produto);
  }

  atualizarProduto(id: number, produto: ProdutoModel){
    const url = `${this.apiUrl}/${id}`;
    return this.http.put<ProdutoModel>(url, produto);
  }

  excluirProduto(id: number): Observable<void> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.delete<void>(url);
  }

  carregar(){
    this.produto = JSON.parse(String(localStorage.getItem('produto')));
    if(this.produto == null){
      return [];
    }
    return this.produto;
  }

}
