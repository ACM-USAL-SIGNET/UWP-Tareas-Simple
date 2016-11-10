namespace Tareas
{
    public class Tarea
    {
        private static int contador = 0;
        public int Numero { get; set; }
        public string Info { get; set; }

        public Tarea()
        {
            contador++;
            Numero = contador;
            Info = "Tarea" + contador;
        }
    }
}
