using App.BP.Data.Models;
using App.BP.Repository.Interfaces;

namespace App.BP.BLL.BLL
{
    public class MovimientoBLL
    {
        private IRepository<Movimiento> _repository;

        public MovimientoBLL(IRepository<Movimiento> repository)
        {
            _repository = repository;
        }
    }
}
