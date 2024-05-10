
# Objetivo

Este repositório tem como objetivo demonstrar uma maneira de obter as variáveis de ambiente do registro do Windows utilizando a plataforma .NET.


# Como utilizar?

Para utilizar corretamente siga os seguintes passos:

#### 1. Vá em Painel de Controle\Sistema e Segurança\Sistema ou use o atalho Windows + Pause/Break:

#### 2. Clique em Configurações avançadas do sistema:

#### 3. Clique em Variáveis de ambiente e defina uma variavel no sistema e um valor para ela

#### 4. Altere ou crie o arquivo de configuração e defina os valores para as chaves

| Parâmetro   | Descrição                           |Obrigatório?|
| :---------- | :---------------------------------- |:----------|
| `VARIABLE` | Nome da variavel |Sim |
| `KEY_NAME` | Url onde encontram-se as variáveis de ambiente |Sim |
| `DEFAULTVALUE` | Valor padrão caso a variável não seja encontrada |Não |



6 - A classe ```Registry``` fornece objetos ```RegistryKey``` que representam as chaves raiz no Registro do Windows

| Propriedade   | Descrição                           |
| :---------- | :---------------------------------- |
| `ClassesRoot` | Define os tipos (ou classes) de documentos e as propriedades associadas a esses tipos. Este campo lê a chave base do Registro ```HKEY_CLASSES_ROOT``` do Windows. |
| `CurrentConfig` | Contém informações de configuração relacionadas ao hardware que não é específico do usuário. Este campo lê a chave base ```HKEY_CURRENT_CONFIG``` do Registro do Windows. |
| `CurrentUser` | Contém informações sobre as preferências do usuário atual. Este campo lê a chave base de Registro HKEY_CURRENT_USER do Windows. |
| `LocalMachine` | Contém os dados de configuração para o computador local. Este campo lê a chave de base de Registro HKEY_LOCAL_MACHINE do Windows. |
| `PerformanceData` | Contém informações de desempenho de componentes de software. Esse campo lê a chave base do Registro HKEY_PERFORMANCE_DATA do Windows. |
| `Users` | Contém informações sobre a configuração de usuário padrão. Este campo lê a chave base do Registro do Windows HKEY_USERS. |


# Fontes

Microsoft: https://learn.microsoft.com/pt-br/dotnet/api/microsoft.win32.registry?view=net-8.0

Stackoverflow: https://stackoverflow.com/questions/185208/how-do-i-get-and-set-environment-variables-in-c
