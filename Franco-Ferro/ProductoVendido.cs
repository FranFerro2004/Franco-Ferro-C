using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franco_Ferro
{
    internal class ProductoVendido
    {

        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public Producto()
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;

        }

        public Producto(int id, int idProducto, int stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = 0;

        }

        public int ID { get; set; }

        public int IdProducto { get; set; }

        public int Stock { get; set; }

        public int IDVenta { get; set; } 


    }
}
