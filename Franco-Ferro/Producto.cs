using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franco_Ferro
{
    internal class Producto
    {

        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto()
        {
            _id = 0;
            _descripcion = string.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;

        }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this._id = id;
            this._descripcion = string.Empty;
            this._costo = costo;
            this._precioVenta = 0;
            this._stock = stock;
            this._idUsuario = idUsuario;

        }

        public int Id { get; set; }

        public string Descripcion { get; set; }

        public double Costo { get; set; }

        public double PrecioVenta { get; set; }

        public int Stock { get; set; }

        public int IdUsuario { get; set; }






    }
}
