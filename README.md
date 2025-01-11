# LIBRARY
LIBRARY é uma aplicação desenvolvida em C# para gerenciar uma biblioteca. A aplicação é projetada para comunicar-se entre diversas camadas, como interface, modelos, usuários, empréstimos, catálogo, inventário e livros. Utiliza um banco de dados SQL para armazenar informações essenciais sobre usuários e livros, permitindo uma gestão eficiente dos empréstimos de livros.


**Estrutura do Projeto**

A estrutura do projeto segue o padrão de camadas, promovendo modularidade e facilidade de manutenção:

Interface: Responsável pela interação com o usuário, seja via console, aplicação desktop ou web.

Models: Contém as classes que representam as entidades do sistema, como User, Book, Borrow, Catalog e Inventory.

Camada de Negócio: Implementa as regras de negócio e coordena as interações entre as diferentes camadas.

Camada de Dados: Responsável pela comunicação com o banco de dados SQL, incluindo operações de CRUD (Create, Read, Update, Delete).


**Funcionalidades**

Cadastro de Usuários: Permite adicionar novos usuários ao sistema, incluindo informações pessoais e de contato.


**Gerenciamento de Livros:**

Adição de novos livros ao inventário.

Consulta ao catálogo por título, autor ou gênero.

Atualização de informações dos livros.


**Empréstimos:**

Registro de empréstimos de livros.

Controle de devolução e prazos.

Histórico de empréstimos por usuário.

Inventário: Monitora o estoque de livros, indicando livros disponíveis e reservas pendentes.
