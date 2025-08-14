using System;
using System.Linq;

using EntityFrameworkStudyDatabase.Database;

namespace EntityFrameworkStudyLogic.Methods
{
    public class UsuarioMethods
    {

        private readonly ESTAGIOEntities _context;

        public UsuarioMethods()
        {
            _context = new ESTAGIOEntities();
        }



        public INFRAUSUARIO Get(string id)
        {
            INFRAUSUARIO usuario = _context.INFRAUSUARIO.FirstOrDefault(u => u.ID == id);
            return usuario;
        }

        public dynamic GetAll()
        {
            foreach (INFRAUSUARIO usuario in _context.INFRAUSUARIO)
            {
                Console.WriteLine("{0}\t{1}\t{2}", usuario.ID, usuario.NOME, usuario.SENHAHASH512);
            }

            return 0;
        }

        public string Create(INFRAUSUARIO record)
        {
            record.ID = Guid.NewGuid().ToString();

            _context.INFRAUSUARIO.Add(record);
            _context.SaveChanges();

            return record.ID;
        }

        public void Update(INFRAUSUARIO record)
        {
            if (record != null)
            {
                record.ID = record.ID;
                _context.SaveChanges();
            }
        }

        public void Delete(INFRAUSUARIO record)
        {
            if (record != null)
            {
                _context.INFRAUSUARIO.Remove(record);
                _context.SaveChanges();
            }
        }

    }
}
