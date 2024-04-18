import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ListarPedidoComponent } from './lista_pedido.component';

describe('ListarProdutoComponent', () => {
  let component: ListarPedidoComponent;
  let fixture: ComponentFixture<ListarPedidoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarPedidoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarPedidoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
