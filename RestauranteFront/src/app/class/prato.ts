import { Restaurante } from './restaurante';

export class Prato {
  id: number;
  nome: string;
  preco: number;
  restauranteId: number;
  restaurante: Restaurante;
}
