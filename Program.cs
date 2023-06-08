using ClasesParaTarea; 
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



List<Tarea> TareasPendientes= new List<Tarea>();
List<Tarea> TareasRealizadas =new List<Tarea>();
string salida= "";
int num =1;
do {
    Console.WriteLine("Ingrese la descripcion de la tarea:\n");
    string desc = Console.ReadLine();
    
    Tarea nTarea = new Tarea();
    nTarea.descripcion= desc;
    nTarea.tareaid = num;
    Random random = new Random();
    nTarea.duracion = random.Next(10,101);
    num+=1;

    TareasPendientes.Add(nTarea);
    Console.WriteLine("Desea ingresar una nueva tarea Si[s] - No[n]\n");
    salida = Console.ReadLine();
} while( salida!="n");

foreach(Tarea tarea in TareasPendientes){
    Console.WriteLine("Tareas PENDIENTES:\n");

}








/*
foreach (var numero in MiLista ){
    Console.WriteLine(numero);
}
*/


