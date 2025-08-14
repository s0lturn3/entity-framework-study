using EntityFrameworkStudyDatabase.Database;
using EntityFrameworkStudyLogic.Methods;
using System;

namespace EntityFrameworkStudyTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioMethods usuarioMethods = new UsuarioMethods();

            Console.WriteLine("Operações de usuário:");
            Console.WriteLine($@"1. READ
2. CREATE
3. UPDATE
4. DELETE");
            Console.WriteLine();

            int opt = Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1: // LEITURA
                    usuarioMethods.GetAll();
                    break;

                case 2: // CRIAÇÃO
                    usuarioMethods.Create(new INFRAUSUARIO
                    {
                        TENANT_ID = 0,
                        USUARIO = "EF6",
                        NOME = "Erick (EntityFramework)",
                        DATACRIACAO = DateTime.Now,
                        EMAIL = "ecoliveira@sispro.com.br",
                        IS_ACTIVE = true,
                        SENHAHASH512 = "EF6"
                    });
                    break;

                case 3: // ATUALIZAÇÃO
                    usuarioMethods.Update(new INFRAUSUARIO
                    {
                        ID = "",
                        USUARIO = "EF6  _",
                        NOME = "Erick (EntityFramework)  _",
                        DATAULTIMOACESSO = DateTime.Now,
                        EMAIL = "ecoliveira@sispro.com.br  _",
                        IS_ACTIVE = true,
                        SENHAHASH512 = "EF6  _"
                    });
                    break;

                case 4: // EXCLUSÃO
                    usuarioMethods.Delete(new INFRAUSUARIO { ID = "" });
                    break;
            }

            Console.ReadKey();
        }
    }
}
