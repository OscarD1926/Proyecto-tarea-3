using System;
using System.Collections.Generic;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
}

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static int contadorId = 1;

    static void Main()
    {
        CrearUsuario();
    }

    static void CrearUsuario()
    {
        Usuario u = new Usuario();
        u.Id = contadorId++;

        Console.Write("Ingrese nombre: ");
        u.Nombre = Console.ReadLine();

        Console.Write("Ingrese email: ");
        u.Email = Console.ReadLine();

        usuarios.Add(u);

        Console.WriteLine("Usuario creado correctamente.");
    }
}