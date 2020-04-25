﻿using System.Linq;
using TreinoAPI.Db_Context;
using TreinoAPI.DTO.Auth;
using TreinoAPI.DTO.Usuarios;

namespace TreinoAPI.DAO
{
    public class UsuariosDAO
    {
        TreinoConnectionString DbTreino = new TreinoConnectionString();

        public UsuariosDTO SelectUsuario(int IDUsuario)
        {
            return DbTreino.Usuarios.Where((usuario) => usuario.IDUsuario == IDUsuario)
                                    .FirstOrDefault();
        }

        public UsuariosDTO SelectUsuarioPorCredenciais(string Usuario, string Senha)
        {
            return DbTreino.Usuarios.Where((usuario) => usuario.Usuario == Usuario && usuario.Senha == Senha)
                                    .FirstOrDefault();
        }

        public UsuariosDTO SelectUsuarioPorUsername(string Username)
        {
            return DbTreino.Usuarios.Where((usuario) => usuario.Usuario == Username)
                                    .FirstOrDefault();
        }

        public void InsertUsuario(RegisterDTO Register)
        {
            UsuariosDTO _usuario = PreparaUsuario(Register);

            DbTreino.Add(_usuario);
            DbTreino.SaveChanges();
        }

        private UsuariosDTO PreparaUsuario(RegisterDTO Register)
        {
            UsuariosDTO _usuario = new UsuariosDTO();

            _usuario.Usuario = Register.Username;
            _usuario.Senha = Register.Password;
            _usuario.Nome = Register.Name;
            return _usuario;
        }
    }
}