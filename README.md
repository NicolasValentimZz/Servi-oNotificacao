
# Serviço de Alertas em C#

Este projeto foi desenvolvido com o propósito de solidificar o entendimento dos princípios SOLID, empregando a injeção de dependência para construir um código flexível, de fácil manutenção e com baixo acoplamento.

---

🎯 Qual o desafio?

O objetivo é criar um serviço de alerta que se encarregue de enviar mensagens por diversos canais, aplicando as melhores práticas de design de software.

---

🧠 Ideias implementadas

- Princípios SOLID
- Inversão de Dependência (DIP)
- Injeção de Dependência (DI)
- Interfaces
- Acoplamento mínimo

---

🏗️ Como a solução foi estruturada

Foi criada uma interface, a `INotification`, com a função de estabelecer o contrato de alerta.
O serviço `NotificationService` recebe essa interface através do construtor, o que permite trocar a implementação sem afetar a lógica do programa.

Esta maneira de fazer evita a dependência direta de classes concretas, o que torna o código mais maleável e simples de manter.

---

🔧 Por que usar Injeção de Dependência?

- Diminui o acoplamento entre as classes
- Facilita a evolução e a manutenção do sistema
- Permite adicionar novos canais de alerta sem mexer no serviço principal
- Aumenta a testabilidade do código

Sem o uso de DI, seria necessário alterar diretamente as classes existentes para novas implementações, dificultando a manutenção e o crescimento do código.

---

🚀 Um exemplo de expansão

Com esta estrutura, é simples incluir novos canais de alerta (como Email, SMS ou Push Notification) apenas criando novas implementações da interface `INotification`, sem mudar o serviço principal.

---

📚 O que foi aprendido

- Aplicação prática do princípio da Inversão de Dependência
- Uso de interfaces para promover o desacoplamento
- Organização do código seguindo as melhores práticas

---
Ainda contém alguns erros e bugs, sigo evoluindo o código para correção e refatoração.
