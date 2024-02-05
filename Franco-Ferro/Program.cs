/*using System;

namespace Franco_Ferro
{


    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("==== Menú ====");
                    Console.WriteLine("1. Obtener Producto por Id");
                    Console.WriteLine("2. Listar Todos los Productos");
                    Console.WriteLine("3. Crear Nuevo Producto");
                    Console.WriteLine("4. Modificar Producto");
                    Console.WriteLine("5. Eliminar Producto");
                    Console.WriteLine("6. Salir");

                    Console.Write("Ingrese la opción deseada: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese el Id del producto a obtener: ");
                            if (int.TryParse(Console.ReadLine(), out int idObtener))
                            {
                                MostrarProducto(ProductoData.ObtenerProducto(idObtener));
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el Id.");
                            }
                            break;

                        case "2":
                            MostrarProducto(ProductoData.ListarProductos());
                            break;

                        case "3":
                            CrearNuevoProducto();
                            break;

                        case "4":
                            ModificarProducto();
                            break;

                        case "5":
                            EliminarProducto();
                            break;

                        case "6":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 6.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void MostrarProducto(System.Collections.Generic.List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"Id: {producto.Id}, Descripción: {producto.Descripcion}, Precio: {producto.PrecioVenta}");
            }
        }

        static void CrearNuevoProducto()
        {
            try
            {
                Console.Write("Ingrese la descripción del nuevo producto: ");
                string descripcion = Console.ReadLine();

                Console.Write("Ingrese el costo del nuevo producto: ");
                if (double.TryParse(Console.ReadLine(), out double costo))
                {
                    Console.Write("Ingrese el precio de venta del nuevo producto: ");
                    if (double.TryParse(Console.ReadLine(), out double precioVenta))
                    {
                        Console.Write("Ingrese el stock del nuevo producto: ");
                        if (int.TryParse(Console.ReadLine(), out int stock))
                        {
                            Console.Write("Ingrese el Id del usuario: ");
                            if (int.TryParse(Console.ReadLine(), out int idUsuario))
                            {
                                ProductoData.CrearProducto(new Producto
                                {
                                    Descripcion = descripcion,
                                    Costo = costo,
                                    PrecioVenta = precioVenta,
                                    Stock = stock,
                                    IdUsuario = idUsuario
                                });
                                Console.WriteLine("Producto creado exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el Id del usuario.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para el stock.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para el precio de venta.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el costo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el producto: {ex.Message}");
            }
        }


        static void ModificarProducto()
        {
            try
            {
                Console.Write("Ingrese el Id del producto a modificar: ");
                if (int.TryParse(Console.ReadLine(), out int idModificar))
                {
                    var producto = ProductoData.ObtenerProducto(idModificar);
                    if (producto.Count > 0)
                    {
                        Console.Write("Ingrese la nueva descripción del producto: ");
                        string nuevaDescripcion = Console.ReadLine();

                        Console.Write("Ingrese el nuevo costo del producto: ");
                        if (double.TryParse(Console.ReadLine(), out double nuevoCosto))
                        {
                            Console.Write("Ingrese el nuevo precio de venta del producto: ");
                            if (double.TryParse(Console.ReadLine(), out double nuevoPrecioVenta))
                            {
                                Console.Write("Ingrese el nuevo stock del producto: ");
                                if (int.TryParse(Console.ReadLine(), out int nuevoStock))
                                {
                                    Console.Write("Ingrese el nuevo Id del usuario: ");
                                    if (int.TryParse(Console.ReadLine(), out int nuevoIdUsuario))
                                    {
                                        ProductoData.ModificarProducto(new Producto
                                        {
                                            Id = idModificar,
                                            Descripcion = nuevaDescripcion,
                                            Costo = nuevoCosto,
                                            PrecioVenta = nuevoPrecioVenta,
                                            Stock = nuevoStock,
                                            IdUsuario = nuevoIdUsuario
                                        });
                                        Console.WriteLine("Producto modificado exitosamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Entrada no válida para el nuevo Id del usuario.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Entrada no válida para el nuevo stock.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el nuevo precio de venta.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para el nuevo costo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún producto con el Id proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar el producto: {ex.Message}");
            }
        }

        static void EliminarProducto()
        {
            try
            {
                Console.Write("Ingrese el Id del producto a eliminar: ");
                if (int.TryParse(Console.ReadLine(), out int idEliminar))
                {
                    var producto = ProductoData.ObtenerProducto(idEliminar);
                    if (producto.Count > 0)
                    {
                        ProductoData.EliminarProducto(new Producto { Id = idEliminar });
                        Console.WriteLine("Producto eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún producto con el Id proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el producto: {ex.Message}");
            }
        }




    }
}  */



using System;

namespace Franco_Ferro
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("==== Menú ====");
                    Console.WriteLine("1. Interactuar con Usuarios");
                    Console.WriteLine("2. Interactuar con Productos");
                    Console.WriteLine("3. Interactuar con Ventas");
                    Console.WriteLine("4. Salir");

                    Console.Write("Ingrese la opción deseada: ");
                    string opcionEntidad = Console.ReadLine();

                    switch (opcionEntidad)
                    {
                        case "1":
                            MenuUsuarios();
                            break;

                        case "2":
                            MenuProductos();
                            break;

                        case "3":
                            MenuVentas();
                            break;

                        case "4":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 4.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void MenuUsuarios()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("==== Menú ====");
                    Console.WriteLine("1. Obtener Usuario por Id");
                    Console.WriteLine("2. Listar Todos los Usuarios");
                    Console.WriteLine("3. Crear Nuevo Usuario");
                    Console.WriteLine("4. Modificar Usuario");
                    Console.WriteLine("5. Eliminar Usuario");
                    Console.WriteLine("6. Salir");

                    Console.Write("Ingrese la opción deseada: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese el Id del usuario a obtener: ");
                            if (int.TryParse(Console.ReadLine(), out int idObtener))
                            {
                                MostrarUsuario(UsuarioData.ObtenerUsuario(idObtener));
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el Id.");
                            }
                            break;

                        case "2":
                            MostrarUsuario(UsuarioData.ListarUsuarios());
                            break;

                        case "3":
                            CrearNuevoUsuario();
                            break;

                        case "4":
                            ModificarUsuario();
                            break;

                        case "5":
                            EliminarUsuario();
                            break;

                        case "6":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 6.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            static void MostrarUsuario(List<Usuario> usuarios)
            {
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"Id: {usuario.Id}, Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}");
                }
            }

            static void CrearNuevoUsuario()
            {
                try
                {
                    Console.Write("Ingrese el nombre del nuevo usuario: ");
                    string nombreUsuario = Console.ReadLine();

                    Console.Write("Ingrese el apellido del nuevo usuario: ");
                    string apellidoUsuario = Console.ReadLine();

                    Console.Write("Ingrese el nombre del usuario: ");
                    string nombreDeUsuario = Console.ReadLine();

                    Console.Write("Ingrese la contraseña del nuevo usuario: ");
                    string contrasenaUsuario = Console.ReadLine();

                    Console.Write("Ingrese el correo electrónico del nuevo usuario: ");
                    string mailUsuario = Console.ReadLine();

                    

                    UsuarioData.CrearUsuario(new Usuario
                    {
                        Nombre = nombreUsuario,
                        Apellido = apellidoUsuario,
                        NombreUsuario = nombreDeUsuario,
                        Contrasena = contrasenaUsuario,
                        Mail = mailUsuario
                        
                    });

                    Console.WriteLine("Usuario creado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el usuario: {ex.Message}");
                }
            }


            static void ModificarUsuario()
            {
                try
                {
                    Console.Write("Ingrese el Id del usuario a modificar: ");
                    if (int.TryParse(Console.ReadLine(), out int idModificar))
                    {
                        var usuario = UsuarioData.ObtenerUsuario(idModificar);
                        if (usuario.Count > 0)
                        {
                            Console.Write("Ingrese el nuevo nombre del usuario: ");
                            string nuevoNombre = Console.ReadLine();

                            Console.Write("Ingrese el nuevo apellido del usuario: ");
                            string nuevoApellido = Console.ReadLine();

                            Console.Write("Ingrese el nuevo nombre de usuario: ");
                            string nuevoNombreUsuario = Console.ReadLine();

                            Console.Write("Ingrese el nuevo correo electrónico del usuario: ");
                            string nuevoMail = Console.ReadLine();

                            Console.Write("Ingrese la nueva contraseña del usuario: ");
                            string nuevaContrasena = Console.ReadLine();

                            UsuarioData.ModificarUsuario(new Usuario
                            {
                                Id = idModificar,
                                Nombre = nuevoNombre,
                                Apellido = nuevoApellido,
                                NombreUsuario = nuevoNombreUsuario,
                                Mail = nuevoMail,
                                Contrasena = nuevaContrasena
                            });

                            Console.WriteLine("Usuario modificado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ningún usuario con el Id proporcionado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para el Id.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al modificar el usuario: {ex.Message}");
                }
            }



            static void EliminarUsuario()
            {
                try
                {
                    Console.Write("Ingrese el Id del usuario a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int idEliminar))
                    {
                        var usuario = UsuarioData.ObtenerUsuario(idEliminar);
                        if (usuario.Count > 0)
                        {
                            UsuarioData.EliminarUsuario(new Usuario { Id = idEliminar });
                            Console.WriteLine("Usuario eliminado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ningún usuario con el Id proporcionado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para el Id.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar el usuario: {ex.Message}");
                }
            }


        }

        static void MenuProductos()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("==== Menú ====");
                    Console.WriteLine("1. Obtener Producto por Id");
                    Console.WriteLine("2. Listar Todos los Productos");
                    Console.WriteLine("3. Crear Nuevo Producto");
                    Console.WriteLine("4. Modificar Producto");
                    Console.WriteLine("5. Eliminar Producto");
                    Console.WriteLine("6. Salir");

                    Console.Write("Ingrese la opción deseada: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese el Id del producto a obtener: ");
                            if (int.TryParse(Console.ReadLine(), out int idObtener))
                            {
                                MostrarProducto(ProductoData.ObtenerProducto(idObtener));
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el Id.");
                            }
                            break;

                        case "2":
                            MostrarProducto(ProductoData.ListarProductos());
                            break;

                        case "3":
                            CrearNuevoProducto();
                            break;

                        case "4":
                            ModificarProducto();
                            break;

                        case "5":
                            EliminarProducto();
                            break;

                        case "6":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 6.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void MostrarProducto(System.Collections.Generic.List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"Id: {producto.Id}, Descripción: {producto.Descripcion}, Precio: {producto.PrecioVenta}");
            }
        }

        static void CrearNuevoProducto()
        {
            try
            {
                Console.Write("Ingrese la descripción del nuevo producto: ");
                string descripcion = Console.ReadLine();

                Console.Write("Ingrese el costo del nuevo producto: ");
                if (double.TryParse(Console.ReadLine(), out double costo))
                {
                    Console.Write("Ingrese el precio de venta del nuevo producto: ");
                    if (double.TryParse(Console.ReadLine(), out double precioVenta))
                    {
                        Console.Write("Ingrese el stock del nuevo producto: ");
                        if (int.TryParse(Console.ReadLine(), out int stock))
                        {
                            Console.Write("Ingrese el Id del usuario: ");
                            if (int.TryParse(Console.ReadLine(), out int idUsuario))
                            {
                                ProductoData.CrearProducto(new Producto
                                {
                                    Descripcion = descripcion,
                                    Costo = costo,
                                    PrecioVenta = precioVenta,
                                    Stock = stock,
                                    IdUsuario = idUsuario
                                });
                                Console.WriteLine("Producto creado exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el Id del usuario.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para el stock.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para el precio de venta.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el costo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el producto: {ex.Message}");
            }
        }


        static void ModificarProducto()
        {
            try
            {
                Console.Write("Ingrese el Id del producto a modificar: ");
                if (int.TryParse(Console.ReadLine(), out int idModificar))
                {
                    var producto = ProductoData.ObtenerProducto(idModificar);
                    if (producto.Count > 0)
                    {
                        Console.Write("Ingrese la nueva descripción del producto: ");
                        string nuevaDescripcion = Console.ReadLine();

                        Console.Write("Ingrese el nuevo costo del producto: ");
                        if (double.TryParse(Console.ReadLine(), out double nuevoCosto))
                        {
                            Console.Write("Ingrese el nuevo precio de venta del producto: ");
                            if (double.TryParse(Console.ReadLine(), out double nuevoPrecioVenta))
                            {
                                Console.Write("Ingrese el nuevo stock del producto: ");
                                if (int.TryParse(Console.ReadLine(), out int nuevoStock))
                                {
                                    Console.Write("Ingrese el nuevo Id del usuario: ");
                                    if (int.TryParse(Console.ReadLine(), out int nuevoIdUsuario))
                                    {
                                        ProductoData.ModificarProducto(new Producto
                                        {
                                            Id = idModificar,
                                            Descripcion = nuevaDescripcion,
                                            Costo = nuevoCosto,
                                            PrecioVenta = nuevoPrecioVenta,
                                            Stock = nuevoStock,
                                            IdUsuario = nuevoIdUsuario
                                        });
                                        Console.WriteLine("Producto modificado exitosamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Entrada no válida para el nuevo Id del usuario.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Entrada no válida para el nuevo stock.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el nuevo precio de venta.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para el nuevo costo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún producto con el Id proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar el producto: {ex.Message}");
            }
        }

        static void EliminarProducto()
        {
            try
            {
                Console.Write("Ingrese el Id del producto a eliminar: ");
                if (int.TryParse(Console.ReadLine(), out int idEliminar))
                {
                    var producto = ProductoData.ObtenerProducto(idEliminar);
                    if (producto.Count > 0)
                    {
                        ProductoData.EliminarProducto(new Producto { Id = idEliminar });
                        Console.WriteLine("Producto eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún producto con el Id proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el producto: {ex.Message}");
            }
        }
  
        static void MenuVentas()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("==== Menú de Ventas ====");
                    Console.WriteLine("1. Obtener Venta por Id");
                    Console.WriteLine("2. Listar Todas las Ventas");
                    Console.WriteLine("3. Crear Nueva Venta");
                    Console.WriteLine("4. Modificar Venta");
                    Console.WriteLine("5. Eliminar Venta");
                    Console.WriteLine("6. Salir");

                    Console.Write("Ingrese la opción deseada: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese el Id de la venta a obtener: ");
                            if (int.TryParse(Console.ReadLine(), out int idObtener))
                            {
                                MostrarVenta(VentaData.ObtenerVenta(idObtener));
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida para el Id.");
                            }
                            break;

                        case "2":
                            MostrarVenta(VentaData.ListarVentas());
                            break;

                        case "3":
                            CrearNuevaVenta();
                            break;

                        case "4":
                            ModificarVenta();
                            break;

                        case "5":
                            EliminarVenta();
                            break;

                        case "6":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 6.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void MostrarVenta(List<Venta> ventas)
        {
            foreach (var venta in ventas)
            {
                Console.WriteLine($"Id: {venta.ID}, Comentarios: {venta.Comentarios}, IdUsuario: {venta.IDUsuario}");
            }
        }

        static void CrearNuevaVenta()
        {
            try
            {
                Console.Write("Ingrese los comentarios de la nueva venta: ");
                string comentarios = Console.ReadLine();

                Console.Write("Ingrese el Id del usuario: ");
                if (int.TryParse(Console.ReadLine(), out int idUsuario))
                {
                    VentaData.CrearVenta(new Venta
                    {
                        Comentarios = comentarios,
                        IDUsuario = idUsuario
                    });
                    Console.WriteLine("Venta creada exitosamente.");
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id del usuario.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la venta: {ex.Message}");
            }
        }

        static void ModificarVenta()
        {
            try
            {
                Console.Write("Ingrese el Id de la venta a modificar: ");
                if (int.TryParse(Console.ReadLine(), out int idModificar))
                {
                    var venta = VentaData.ObtenerVenta(idModificar);
                    if (venta.Count > 0)
                    {
                        Console.Write("Ingrese los nuevos comentarios de la venta: ");
                        string nuevosComentarios = Console.ReadLine();

                        Console.Write("Ingrese el nuevo Id del usuario: ");
                        if (int.TryParse(Console.ReadLine(), out int nuevoIdUsuario))
                        {
                            VentaData.ModificarVenta(new Venta
                            {
                                ID = idModificar,
                                Comentarios = nuevosComentarios,
                                IDUsuario = nuevoIdUsuario
                            });
                            Console.WriteLine("Venta modificada exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para el nuevo Id del usuario.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna venta con el Id proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar la venta: {ex.Message}");
            }
        }

        static void EliminarVenta()
        {
            try
            {
                Console.Write("Ingrese el Id de la venta a eliminar: ");
                if (int.TryParse(Console.ReadLine(), out int idEliminar))
                {
                    var venta = VentaData.ObtenerVenta(idEliminar);
                    if (venta.Count > 0)
                    {
                        VentaData.EliminarVenta(new Venta { ID = idEliminar });
                        Console.WriteLine("Venta eliminada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ninguna venta con el Id proporcionado.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el Id.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la venta: {ex.Message}");
            }
        }

    }
    }

