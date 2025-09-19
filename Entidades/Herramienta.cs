namespace Entidades
{
    public class Herramienta
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }

        public Herramienta(int id, string nombre, string descripcion, int stock, string imagen) 
        { 
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Stock = stock;
            this.Imagen = imagen;
        }
        public Herramienta(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }


        public Herramienta() { }
    }
}
