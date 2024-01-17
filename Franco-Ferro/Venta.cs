using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franco_Ferro
{
    internal class Venta
    {

        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta()
        {
            _id = 0;
            _comentarios = string.Empty;
            _idUsuario = 0;

        }

        public Venta(int id, string comentarios, int idUsuarios)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario= idUsuarios;

        }

        public int ID { get; set; }

        public string Comentarios { get; set;}

        public int IDUsuario { get; set;}


    }
}
