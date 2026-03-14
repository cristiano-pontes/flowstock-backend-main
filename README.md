# FlowStock – Stock Management System

FlowStock is a simple stock management system developed for the Backend Development course project.

The aim of the system is to allow basic control of products and stock movements inside a small inventory system. The application makes it possible to register products, record stock entries and exits, and automatically update the quantity available for each product.

The project was developed throughout several stages of the course (TP01 to TP05). Each stage focused on a different part of the software development process, starting from requirements definition and finishing with the implementation of a working system.

---

# Technologies Used

The system was developed using the following technologies:

- C#
- ASP.NET Core Razor Pages
- Entity Framework Core
- SQLite database
- .NET 8

These technologies were chosen because they allow building a simple web application with database persistence in a structured and organised way.

---

# Project Structure

The project is divided into three main parts.

### Models

This folder contains the classes that represent the main entities of the system, such as:

- Product
- Supplier
- StockMovement
- Lot

These classes define the structure of the data used by the system.

---

### Data

The Data folder contains the **ApplicationDbContext** class.  
This class is responsible for connecting the application to the database using Entity Framework Core.

It defines the tables used by the system and manages database operations.

---

### Pages

The Pages folder contains the Razor Pages responsible for the user interface and system interaction.

Some of the implemented pages include:

- Product creation
- Product listing
- Stock movement registration

These pages allow users to interact with the system through a web interface.

---

# Main Features

The system currently allows:

- Registering new products
- Viewing a list of products
- Registering stock movements
- Automatically updating product quantity
- Storing information in a SQLite database

When a stock movement is registered, the system updates the product quantity automatically:

- **IN** increases the product quantity
- **OUT** decreases the product quantity

This keeps the stock information updated.

---

# Project Development (TP01 – TP05)

The project was developed following the stages defined in the course.

**TP01 – Requirements**  
Identification of the main actors and definition of the system requirements.

**TP02 – Use Cases**  
Creation of use cases describing how users interact with the system.

**TP03 – Class Modelling**  
Development of the class diagram representing the system entities.

**TP04 – Requirement Update**  
Addition of the Lot entity to support lot control and expiration information.

**TP05 – Implementation**  
Implementation of the backend system using ASP.NET Core and Entity Framework Core.

---

# Running the Project

To run the project locally:

Clone the repository

git clone https://github.com/FernandoFogaca/flowstock-backend.git

Navigate to the project folder

cd FlowStock-Backend

Run the project

dotnet run

The application will start locally and can be accessed in the browser.

---

# Authors

Cristiano Tomaz Monnerat  
Fernando Padilha Fogaça  
Michelly Vieira Guimarães Wilges  

Course: Backend Development  
Professor: Orlando Fonseca Guilarte

# FlowStock – Sistema de Gestão de Estoque

FlowStock é um sistema simples de controle de estoque desenvolvido como parte do projeto da disciplina de Desenvolvimento Back-End.

O objetivo do sistema é permitir um controle básico de produtos e movimentações de estoque dentro de um pequeno sistema de inventário. A aplicação permite cadastrar produtos, registrar entradas e saídas de estoque e atualizar automaticamente a quantidade disponível de cada produto.

O projeto foi desenvolvido ao longo de várias etapas da disciplina (TP01 até TP05). Cada etapa abordou uma parte diferente do processo de desenvolvimento de software, começando pela definição de requisitos e finalizando com a implementação do sistema.

---

# Tecnologias Utilizadas

O sistema foi desenvolvido utilizando as seguintes tecnologias:

- C#
- ASP.NET Core Razor Pages
- Entity Framework Core
- Banco de dados SQLite
- .NET 8

Essas tecnologias foram escolhidas por permitirem a construção de uma aplicação web simples com persistência de dados de forma organizada.

---

# Estrutura do Projeto

O projeto está dividido em três partes principais.

### Models

Esta pasta contém as classes que representam as entidades principais do sistema, como:

- Product
- Supplier
- StockMovement
- Lot

Essas classes definem a estrutura dos dados utilizados pela aplicação.

---

### Data

A pasta Data contém a classe **ApplicationDbContext**, responsável por conectar a aplicação ao banco de dados utilizando o Entity Framework Core.

Ela define as tabelas do sistema e gerencia as operações com o banco de dados.

---

### Pages

A pasta Pages contém as Razor Pages responsáveis pela interface do sistema e interação com o usuário.

Algumas das páginas implementadas incluem:

- Cadastro de produtos
- Listagem de produtos
- Registro de movimentação de estoque

Essas páginas permitem que o usuário utilize o sistema através de uma interface web.

---

# Funcionalidades Principais

O sistema atualmente permite:

- Cadastrar novos produtos
- Visualizar a lista de produtos cadastrados
- Registrar movimentações de estoque
- Atualizar automaticamente a quantidade de produtos
- Armazenar informações em um banco de dados SQLite

Quando uma movimentação de estoque é registrada, o sistema atualiza automaticamente a quantidade do produto:

- **IN** aumenta a quantidade
- **OUT** diminui a quantidade

Dessa forma o sistema mantém o controle de estoque atualizado.

---

# Desenvolvimento do Projeto (TP01 – TP05)

O projeto foi desenvolvido seguindo as etapas definidas durante a disciplina.

**TP01 – Requisitos**  
Identificação dos atores do sistema e definição dos requisitos principais.

**TP02 – Casos de Uso**  
Modelagem das interações entre o usuário e o sistema.

**TP03 – Modelagem de Classes**  
Criação do diagrama de classes representando as entidades do sistema.

**TP04 – Atualização de Requisitos**  
Inclusão da entidade Lot para permitir controle de lote e validade.

**TP05 – Implementação**  
Implementação do sistema utilizando ASP.NET Core e Entity Framework Core.

---

# Autores

Cristiano Tomaz Monnerat  
Fernando Padilha Fogaça  
Michelly Vieira Guimarães Wilges  

Disciplina: Desenvolvimento Back-End  
Professor: Orlando Fonseca Guilarte



