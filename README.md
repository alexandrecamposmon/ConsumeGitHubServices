# ConsumeGitHubServices
API responsável por consumir informações do GIT, sobre determinado repositório, junto com suas respectivas branches e webhooks.


Como iniciar a Aplicação

1 - Devemos ter em nossa maquina o Visual Studio 2022, no nosso caso estamos usando a versão 17.2.2
1.1 - .Net 6.0

2 - Vamos abrir a Solução "ConsumeGitHubServices.sln"

3 - Já com o  Visual Studio aberto,  precisamos nos certificar que o Startup Project é o "ConsumeGitHubServices.API" 
 
4 - Por fim, vamos iniciar o projeto, o qual automaticamente irá começar com o Swagger possibilitando a utilização de nossa Aplicação.

Observação: Na aplicação, estamos listando as informações do usuário "alexandrecamposmon", pois para algumas ações, se faz necessário o uso de um TOKEN. E esse token é individual.
Caso haja a necessidade de implementar métodos mais genéricos e capazes de buscar/escrever informações em outras contas, será obrigatório a informação da conta e de um token válido de acesso.
