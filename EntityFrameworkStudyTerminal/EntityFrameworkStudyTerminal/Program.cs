using System;

using dotenv.net;

using EntityFrameworkStudyLogic.Connection;
using EntityFrameworkStudyLogic.Methods;
using EntityFrameworkStudyLogic.Models;

namespace EntityFrameworkStudyTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura de variáveis de ambiente
            DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { @"C:\projetos\EntityFrameworkStudy\EntityFrameworkStudyTerminal\EntityFrameworkStudyTerminal\.env" }));

            string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            string connectionString2 = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING_PROD");
            Console.WriteLine(connectionString);


            // Inicialização de conexão
            MyDbContext context = new MyDbContext(connectionString2);


            UsuarioMethods usuarioMethods = new UsuarioMethods(context);

            UsuarioRecord record = usuarioMethods.Get("");
        }
    }
}
