# DrinkMachine

### O projeto refere-se à uma máquina de bebidas de um restaurante Fast-Food, programada com base nas regras de negócio listadas abaixo:

- Os sabores de bebida foram armazenados na classe DrinkType dentro de Models para que fossem salvos somente os sabores/tipos fornecidos.
- O design foi feito de uma forma em que a pessoa só consegue avançar após selecionar as opções já disponibilizadas. 
- Requisitos como tipo de tampa e tipo de copo e quantidade de gelo propostos no desafio são selecionados automaticamente no pedido com base nas requisições feitas no teste.
- O pedido só pode ser finalizado após todas as informações do Order Summary estarem preenchidas.
- O botão Reset só deve funcionar quando um pedido estiver em andamento.
- Ao finalizar o pedido, você deve conseguir iniciar outro pedido pelo botão “New Order”.
- Ao finalizar o pedido, a mensagem de erro ao clicar em “Complete Order” deve voltar novamente a mensagem de erro inicial “Order was not initialized”.
