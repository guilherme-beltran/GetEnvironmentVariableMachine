using Microsoft.Win32;
using System.Configuration;

GetEnvironmentVariable();

static void GetEnvironmentVariable()
{
    //Funciona somente na plataforma Windows
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
    else
    {
        Console.WriteLine("Sistema Operacional não é Windows. Esse código funcionará somente com Windows.");
    }
}