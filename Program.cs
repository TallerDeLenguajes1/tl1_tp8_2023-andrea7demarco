using System;
using ClasesParaTarea; 
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Tarea> TareasPendientes= new List<Tarea>();
List<Tarea> TareasRealizadas =new List<Tarea>();
string? salida= "" , desc="" , input , clave;
int num =0 , id ;
bool parseoBool;
int salir =0;
    // creo una instancia 
    funciones func = new funciones();



   do{
    Console.WriteLine(":::::::::::::MENU::::::::::::\n");
    Console.WriteLine("1. Listar Tareas Pendientes\n");
    Console.WriteLine("2. Listar Tareas Realizadas\n");
    Console.WriteLine("3. Agregar Tarea\n");
    Console.WriteLine("4. Eliminar Tarea\n");
    Console.WriteLine("5. Buscar tarea por ID\n");
    Console.WriteLine("6. Buscar tarea por CLAVE\n");
    Console.WriteLine("7. Marcar tarea como REALIZADA:\n ");
    Console.WriteLine("8. Salir\n");
    Console.WriteLine("Ingresar una opcion del menu:\n");
    input = Console.ReadLine();
    parseoBool = int.TryParse(input, out int operacion);
    
    switch(operacion){
        case 1:
            Console.WriteLine("Listado de tareas PENDIENTES:\n");
            foreach(Tarea tarea in TareasPendientes){
                tarea.MostrarTarea();
            }
            break;
        
        case 2:
            Console.WriteLine("Listado de tareas REALIZADAS:\n");
            foreach(Tarea tarea in TareasRealizadas){
                tarea.MostrarTarea();
            }
            break;

        case 3: 
                Console.WriteLine("Ingrese la descripcion de la tarea:\n");
               desc = Console.ReadLine();
               Tarea nTarea = new Tarea();
               nTarea.Descripcion = desc;
               nTarea.TareaID = num;
               Random random = new Random();
               nTarea.Duracion = random.Next(10,101);
               num+=1;

               TareasPendientes.Add(nTarea);

            break;
        case 4: 
            Console.WriteLine("Ingrese ID de la tarea a eliminar :\n");
            input = Console.ReadLine();
            parseoBool=int.TryParse(input, out id);
            for (int i = TareasPendientes.Count - 1; i >= 0; i--)
            {
             if (TareasPendientes[i].TareaID == id)
            {
            TareasPendientes.RemoveAt(i);
            }
            }
            //foreach( Tarea tarea in TareasPendientes){
               // if( id == tarea.TareaID){
                   // TareasPendientes.Remove(tarea);
               // }
           // }

            foreach( Tarea tarea in TareasRealizadas){
                if( id == tarea.TareaID){
                    TareasRealizadas.Add(tarea);
                }
            }
            break;
        
        case 5: 
           Console.WriteLine("Ingresar ID de la tarea a buscar:\n");
           parseoBool=int.TryParse(Console.ReadLine(), out id);
            Tarea? TareaEncontradaP= func.BuscarTareaPorID(id, TareasPendientes);
            Tarea? TareaEncontradaR= func.BuscarTareaPorID(id, TareasRealizadas);
            
            if (TareaEncontradaP == null || TareaEncontradaP == null) {
                Console.WriteLine($"No se encontró ninguna tarea con el Id:{id}");
            } else {
                Console.WriteLine("Tarea encontrada:\n");
                    TareaEncontradaP?.MostrarTarea();
                    TareaEncontradaR?.MostrarTarea();
            }
            break;
        case 6:
           Console.WriteLine("Ingresar Descripción de la tarea a buscar:\n");
           clave= Console.ReadLine();
           Tarea? TareaEncontradaClaveP = func.BuscarTareaPorClave(clave, TareasPendientes);
           Tarea? TareaEncontradaClaveR = func.BuscarTareaPorClave(clave, TareasRealizadas);
            if (TareaEncontradaClaveP == null || TareaEncontradaClaveP == null) {
                Console.WriteLine($"No se encontró ninguna tarea con la clave: {clave}");
            } else {
                Console.WriteLine("Tarea encontrada:\n");
                    TareaEncontradaClaveP?.MostrarTarea();
                    TareaEncontradaClaveR?.MostrarTarea();
            }

           break;
        
        case 7:
            Console.WriteLine("Marcar tarea PENDIENTE como REALIZADA:\n");
            Console.WriteLine("Ingresar ID de la tarea a buscar:\n");
            parseoBool=int.TryParse(Console.ReadLine(), out id);          
            foreach( Tarea tarea in TareasPendientes){
                if( id == tarea.TareaID){
                    TareasRealizadas.Add(tarea);
                }
            }
            foreach( Tarea tarea in TareasRealizadas){
                if( id == tarea.TareaID){
                    TareasPendientes.Remove(tarea);
                }
            }
           break;
        case 8:
           salir=8;
           Console.WriteLine("Salida exitosa");
           break;
           default:
           Console.WriteLine("Operación no válida.");
           break;
   }

   }while(salir!=8);







/*
foreach (var numero in MiLista ){
    Console.WriteLine(numero);
}
*/


