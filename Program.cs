using System;
using ClasesParaTarea; 
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Tarea> TareasPendientes= new List<Tarea>();
List<Tarea> TareasRealizadas =new List<Tarea>();
string? salida= "";
int num =1;
int id;
do {
    Console.WriteLine("Ingrese la descripcion de la tarea:\n");
    string? desc = Console.ReadLine();
    
    Tarea nTarea = new Tarea();
    nTarea.Descripcion= desc;
    nTarea.TareaID = num;
    Random random = new Random();
    nTarea.Duracion = random.Next(10,101);
    num+=1;
    TareasPendientes.Add(nTarea);
    Console.WriteLine("Desea ingresar una nueva tarea Si[s] - No[n]\n");
    salida = Console.ReadLine();
} while( salida!="n");
    Console.WriteLine("Tareas Pendientes");
    foreach(Tarea tarea in TareasPendientes){
    tarea.MostrarTarea();
}
Console.WriteLine("Desea marcar una tarea como realizada Si[s] - No [n]:\n");
   salida=Console.ReadLine();

do{
    Console.WriteLine("Ingrese ID de tarea a realizar:\n");
    id=Console.Read();

    foreach(Tarea tarea in TareasPendientes){
        if( id == tarea.TareaID){
            TareasRealizadas.Add(tarea);
        }
    }

    foreach(Tarea tarea in TareasRealizadas){
        TareasPendientes.Remove(tarea);
    }
    Console.WriteLine("Ingrese ID de tarea a realizar:\n");
    id=Console.Read();
}while(salida!="n");

Console.WriteLine("TAREAS PENDIENTES:\n");
foreach(Tarea tarea in TareasPendientes){
    tarea.MostrarTarea();
}

Console.WriteLine("TAREAS REALIZADAS:\n");
foreach(Tarea tarea in TareasRealizadas){
    tarea.MostrarTarea();
}











/*
foreach (var numero in MiLista ){
    Console.WriteLine(numero);
}
*/


