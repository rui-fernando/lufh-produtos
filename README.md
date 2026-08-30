# Sistema de Gestão de Produtos e Solicitações

Sistema desktop em C# para gestão interna de um laboratório/setor, controlando produtos, equipe, pedidos e solicitações de serviço. Desenvolvido com arquitetura em camadas, persistência via Entity Framework e um serviço WCF para exposição das operações de negócio.

## 📋 Sobre o projeto

O sistema centraliza o controle de produtos (equipamentos/materiais) sob responsabilidade de uma equipe, permitindo o registro de solicitantes, a abertura de pedidos vinculados a produtos e tipos de serviço, e o acompanhamento do status de cada solicitação, do pedido ao atendimento.

## ✨ Funcionalidades

- **Gestão de equipe** — cadastro de membros da equipe, com controle de matrícula, cargo e status.
- **Gestão de produtos** — cadastro de produtos com peso, modelo, tipo e status, vinculados ao solicitante e ao responsável pela criação/edição.
- **Solicitações** — registro de solicitantes e acompanhamento do status de suas solicitações.
- **Pedidos e serviços** — abertura de pedidos vinculando produto, tipo de serviço e ordem de serviço, com observações e status próprio.
- **Autenticação de usuários** — login com senha e salt para maior segurança no armazenamento de credenciais.
- **Serviço WCF** — operações de equipe, produto, pedido, serviço, solicitação e tipo de serviço expostas como serviços, possibilitando integração com outras aplicações.

## 🛠️ Tecnologias utilizadas

- **C#** (.NET Framework)
- **Windows Forms** — interface desktop, com telas de cadastro, edição, visualização e login
- **Entity Framework** — mapeamento objeto-relacional (Code-based Mapping)
- **SQL Server** — banco de dados
- **WCF (Windows Communication Foundation)** — camada de serviços

## 🏗️ Arquitetura

```
sistema-gestao/
├── Entidades/               # Classes de domínio (Usuario, EquipeLab, Produto, Pedido, Servico, Solicitacoes, ...)
├── Interfaces/                # Contratos de serviço (IProduto, IPedido, IServico, ISolicitacao, ...)
├── Controllers/
│   ├── Context/                # Contexto do Entity Framework
│   ├── Map/                    # Mapeamento das entidades para o banco de dados
│   ├── Repositorios/            # Regras de acesso a dados (CRUD) de cada entidade
│   └── Util/                    # Classes utilitárias (ex: geração de salt/hash de senha)
├── WcfService/                   # Serviços WCF que expõem as operações de negócio
└── App/                            # Aplicação desktop (Windows Forms)
    ├── FRM_LOGIN/                   # Tela de autenticação
    ├── FRM_CAD/                      # Telas de cadastro
    ├── FRM_EDIT/                      # Telas de edição
    └── FRM_VIS/                        # Telas de visualização/listagem
```

Assim como em outros projetos C# do autor, a interface (Forms) não acessa o banco diretamente — toda a persistência passa pelos repositórios, que utilizam o Entity Framework.

## ▶️ Como executar

### Pré-requisitos
- Visual Studio (com suporte a .NET Framework e WCF)
- SQL Server
- IIS Express ou servidor WCF local

### Passos

1. Abra a solução (`.sln`) no Visual Studio.
2. Ajuste a string de conexão no contexto do Entity Framework para apontar para sua instância do SQL Server.
3. Restaure os pacotes NuGet de cada projeto.
4. Defina o projeto de interface desktop como projeto de inicialização e execute.

## 📌 Status

Projeto descontinuado — substituído por versões posteriores do sistema.

## 👤 Autor

Desenvolvido em equipe por Rui Fernando, estudante de Ciência da Computação na Universidade Estadual da Paraíba (UEPB), como parte de projeto de pesquisa institucional.
