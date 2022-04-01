using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    public class ModelUser
    {
        internal void SetUsuario(DtoUser u)
        {
            Context db = new Context();
            db.usuario.Add(u);
            db.SaveChanges();
            
        }
       
        internal DtoUser GetUsuario(int id)
        {
            Context db = new Context();
            DtoUser usuario = db.usuario.FirstOrDefault(o => o.id == id);

            return usuario;
        }

        public List<DtoUserList> GetUsuarios()
        {
            Context db = new Context();

            List<DtoUserList> usuarios = (from u in db.usuario
                                            select new DtoUserList
                                            {
                                                id = u.id,
                                                nome = u.nome
                                            }).ToList();
            return usuarios;
        }

        internal void EditarUsuario(DtoUser u)
        {
            Context db = new Context();
            DtoUser usuario = db.usuario.FirstOrDefault(o => o.id == u.id);
            usuario.nome = u.nome;
            usuario.login = u.login;
            usuario.senha = u.senha;
            db.SaveChanges();
        }

        internal void DeletarUsuario(int id)
        {
            Context db = new Context();
            DtoUser usuario = db.usuario.FirstOrDefault(o => o.id == id);
            db.usuario.Remove(usuario);
            db.SaveChanges();
        }
    }
}
