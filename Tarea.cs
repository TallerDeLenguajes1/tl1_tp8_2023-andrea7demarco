namespace ClasesParaTarea{
   public class Tarea{

    private int TareaID;
    private string? Descripcion;
    private int Duracion;
    public int tareaid {get => tareaid ; set => tareaid = value; }
    public string? descripcion {get => descripcion ; set => descripcion = value; }
    public int duracion {get => duracion ; set => duracion = value; }
   

   public void MostrarTarea(){
      Console.WriteLine($"Tarea ID[{TareaID}]");
      Console.WriteLine($"Descripcion:{Descripcion}");
      Console.WriteLine($"Duracion:{Duracion}");

   }


   }
}