namespace Servicio
{
    public class NotificacionService
    {
        public virtual void Enviar(string mensaje)
        {
            Console.WriteLine("Enviando notificación: " + mensaje);
        }
    }
}
