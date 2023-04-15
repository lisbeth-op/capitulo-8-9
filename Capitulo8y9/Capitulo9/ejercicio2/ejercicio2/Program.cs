Dueño dueño1;
dueño1.Nombre = "jose";
dueño1.Edad = 30;

Dueño dueño2;
dueño2.Nombre = "Maria";
dueño2.Edad = 50;

Mascota mascota1;
mascota1.Nombre = "ares";
mascota1.categoria = "Perro";
mascota1.Propietario = dueño1;

Mascota mascota2;
mascota2.Nombre = "Mimi";
mascota2.categoria = "Gato";
mascota2.Propietario = dueño2;

Console.WriteLine("Nombre mascota: " + mascota1.Nombre + ", Tipo: "
+ mascota1.categoria + ", Nombre dueño: " + mascota1.Propietario.Nombre
+ ", Edad: " + mascota1.Propietario.Edad);

Console.WriteLine("Nombre mascota: " + mascota2.Nombre +
", Tipo: " + mascota2.categoria + ", Nombre dueño: " +
 mascota2.Propietario.Nombre + ", Edad: " + mascota2.Propietario.Edad);


struct Dueño
{
    public string Nombre;
    public int Edad;
}

struct Mascota
{
    public string Nombre;
    public string categoria;
    public Dueño Propietario;
}