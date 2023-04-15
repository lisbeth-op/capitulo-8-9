Producto producto1;
producto1.Nombre = "Libro";
producto1.Precio = 500;
producto1.Cantidad = 10;

Producto producto2;
producto2.Nombre = "Revista";
producto2.Precio = 500;
producto2.Cantidad = 10;

Console.WriteLine("Nombre: " + producto1.Nombre + ", Precio: " + producto1.Precio + ", Cantidad: " + producto1.Cantidad);
Console.WriteLine("Nombre: " + producto2.Nombre + ", Precio: " + producto2.Precio + ", Cantidad: " + producto2.Cantidad);


struct Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;
}