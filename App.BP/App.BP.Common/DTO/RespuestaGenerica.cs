namespace App.BP.Common.DTO
{
    public class RespuestaGenerica<T> where T : class
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Mensaje { get; set; }
        public string ExeptionMessage { get; set; }
    }
}
