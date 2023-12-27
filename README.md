# DIO - Trilha .NET - Fundamentos
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da [DIO](https://web.dio.me/home).

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.
> O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas abaixo, para que no final, tenhamos um programa funcional.

## Desafio de projeto
### 🎯 Objetivos

[x]  **Adicionar** um veículo

[x] **Remover** um veículo

[x]  **Listar** os veículos ***estacionados***

### 📝  Regras de Negócio

[x]  Quando **Remover** um veículo dar o preço que o usuário deve pagar

#### Precificando:

- Preço inicial: Valor cobrado quando entra no estacionamento
- Preço por hora: Valor cobrado a cada hora que se ficou estacionado

> Exemplo:
> 
> 💲 R$5,00 + (R$2,00 x 2h) ⇒ R$5,00 + R$4,00 ⇒ **R$ 9,00**

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

## Implementaçõe Complementares
Além dos métodos implementados, foi criada uma verificação para garantir que o valor inserido se trata da placa de um carro. O método verifica tanto o comprimento quanto a formatação da placa.

##

> Desenvolvido por [Bruna de Paula](www.linkedin.com/in/brunadpaula)
