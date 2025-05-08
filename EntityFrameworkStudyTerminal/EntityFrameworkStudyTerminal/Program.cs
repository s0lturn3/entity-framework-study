using dotenv.net;
using EntityFrameworkStudyLogic.Connection;
using EntityFrameworkStudyLogic.Methods;
using System;

namespace EntityFrameworkStudyTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Load();
            DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { @"C:\projetos\EntityFrameworkStudy\EntityFrameworkStudyTerminal\EntityFrameworkStudyTerminal\.env" }));

            string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            UsuarioMethods usuarioMethods = new UsuarioMethods();
            
            Console.WriteLine(connectionString);
        }
    }
}
