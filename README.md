> :warning: **AVISO: O script do banco de dados está incluído neste repositório.**

# Sistema de Gerenciamento de Produtos e Fornecedores

Este sistema permite o gerenciamento eficiente de produtos e fornecedores. Ele foi desenvolvido em C# e utiliza um banco de dados SQL Server para armazenar e recuperar dados.

## Características

### Cadastro de Produtos e Fornecedores
O sistema permite o cadastro de novos produtos e fornecedores através de um formulário.

### Visualização de Produtos e Fornecedores
Os produtos e fornecedores cadastrados podem ser visualizados em um DataGridView, permitindo uma fácil visualização e gerenciamento dos dados.

### Edição de Produtos e Fornecedores
O sistema permite a edição de produtos e fornecedores existentes. Ao selecionar um registro no DataGridView e clicar no botão de edição, os detalhes do registro são carregados em um formulário onde podem ser editados.

### Exclusão de Produtos e Fornecedores
O sistema também permite a exclusão de produtos e fornecedores. Ao selecionar um registro no DataGridView e clicar no botão de exclusão, o registro é excluído do banco de dados e do DataGridView.

## Conexão com o Banco de Dados

O sistema se conecta a um banco de dados SQL Server para armazenar e recuperar dados. Utilizamos a biblioteca SqlConnection para gerenciar a conexão com o banco de dados e executar consultas SQL.
