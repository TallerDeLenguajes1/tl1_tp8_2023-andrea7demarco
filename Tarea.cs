namespace ClasesParaTarea{
   public class Tarea{

    private int tareaid;
    private string? descripcion;
    private int duracion;
    public int TareaID {get => tareaid ; set => tareaid = value; }
    public string? Descripcion {get => descripcion ; set => descripcion = value; }
    public int Duracion {get => duracion ; set => duracion = value; }
   

   public void MostrarTarea(){
      Console.WriteLine($"Tarea ID[{tareaid}]");
      Console.WriteLine($"Descripcion:{descripcion}");
      Console.WriteLine($"Duracion:{duracion}");

   }


   }
}