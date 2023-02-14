using App.BP.Common.DTO;


namespace App.BP.BLL.Interfaces
{
    public interface ITarjetaBLL
    {
        Task<TarjetaResumen> ObtenerTarjeta(string numeroTarjeta);
    }
}
