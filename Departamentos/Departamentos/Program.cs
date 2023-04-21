using Departamentos;

ConexionBD conexion = new ConexionBD();
var department = conexion.Get();

foreach (var dep in department)
{
    Console.WriteLine(dep);
}

Console.ReadKey();