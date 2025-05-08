using System;
using System.Linq;
using EntityFrameworkStudyLogic.Connection;
using EntityFrameworkStudyLogic.Models;

namespace EntityFrameworkStudyLogic.Methods
{
    public class UsuarioMethods
    {

        private readonly MyDbContext _context;

        public UsuarioMethods(MyDbContext context)
        {
            _context = context;
        }



        public void BasicCRUD()
        {
            // CREATE
            var novo = new UsuarioRecord { Id = Guid.NewGuid().ToString(), Tenant_Id = 1579, Nome = "Fulano", Email = "fulano@email.com" };
            _context.Usuarios.Add(novo);
            _context.SaveChanges();

            // READ
            UsuarioRecord usuario = _context.Usuarios.FirstOrDefault(u => u.Id == "");

            // UPDATE
            if (usuario != null)
            {
                usuario.Nome = "Novo Nome";
                _context.SaveChanges();
            }

            // DELETE
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }



        public UsuarioRecord Get(string id)
        {
            UsuarioRecord usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            return usuario;
        }

        public string Create(UsuarioRecord record)
        {
            record.Id = Guid.NewGuid().ToString();

            _context.Usuarios.Add(record);
            _context.SaveChanges();

            return record.Id;
        }

        public void Update(UsuarioRecord record)
        {
            if (record != null)
            {
                record.Id = record.Id;
                _context.SaveChanges();
            }
        }

        public void Delete(UsuarioRecord record)
        {
            if (record != null)
            {
                _context.Usuarios.Remove(record);
                _context.SaveChanges();
            }
        }

    }
}
