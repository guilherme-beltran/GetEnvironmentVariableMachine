using Microsoft.Win32;
using System.Configuration;

//1 - Vá em Painel de Controle\Sistema e Segurança\Sistema ou use o atalho Windows + Pause/Break:

//2 - Clique em Configurações avançadas do sistema:

//3 - Clique em Variáveis de ambiente e defina uma variavel no sistema e um valor para ela

//4 - Altere ou crie o arquivo de configuração e defina os valores para as chaves VARIABLE para o nome da variavel, KEY_NAME para o url onde encontram-se as variáveis de ambiente e DEFAULTVALUE para um valor padrão caso a variável não seja encontrada

//5 - O url de KEY_NAME especifica o local onde uma variável de ambiente é armazenada ou recuperada em uma operação set ou get.

//6 - A classe Registry fornece objetos RegistryKey que representam as chaves raiz no Registro do Windows
//ClassesRoot
//Define os tipos (ou classes) de documentos e as propriedades associadas a esses tipos. Este campo lê a chave base do Registro HKEY_CLASSES_ROOT do Windows.

//CurrentConfig	
//Contém informações de configuração relacionadas ao hardware que não é específico do usuário. Este campo lê a chave base HKEY_CURRENT_CONFIG do Registro do Windows.

//CurrentUser	
//Contém informações sobre as preferências do usuário atual. Este campo lê a chave base de Registro HKEY_CURRENT_USER do Windows.

//LocalMachine	
//Contém os dados de configuração para o computador local. Este campo lê a chave de base de Registro HKEY_LOCAL_MACHINE do Windows.

//PerformanceData	
//Contém informações de desempenho de componentes de software. Esse campo lê a chave base do Registro HKEY_PERFORMANCE_DATA do Windows.

//Users	
//Contém informações sobre a configuração de usuário padrão. Este campo lê a chave base do Registro do Windows HKEY_USERS.

GetEnvironmentVariable();

static void GetEnvironmentVariable()
{
    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
    {
        string? variable = ConfigurationManager.AppSettings["VARIABLE"];
        string? keyName = ConfigurationManager.AppSettings["KEY_NAME"];
        string? defaultValue = ConfigurationManager.AppSettings["DEFAULTVALUE"];

        string existingPathFolderVariable = (string)Registry
            .LocalMachine
            .OpenSubKey(keyName)
            .GetValue(
                name: variable,
                defaultValue: defaultValue,
                options: RegistryValueOptions.DoNotExpandEnvironmentNames);

        if (existingPathFolderVariable is null)
        {
            Console.WriteLine("Variavel não possui valor ou não foi encontrada.");

        }
        Console.WriteLine($"Valor da variavel de ambiente: {existingPathFolderVariable}");

    }
}