using App.BP.BLL.Interfaces;
using App.BP.Common.DTO;
using App.BP.Data.Models;
using App.BP.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App.BP.BLL.BLL
{
    public class ClienteBLL : IClienteBLL
    {
        private IRepository<Cliente> _repositoryCliente;
        private IRepository<Persona> _repositoryPersona;

        public ClienteBLL(IRepository<Cliente> repositoryCliente, IRepository<Persona> repositoryPersona)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryPersona = repositoryPersona;
        }

        public async Task<List<Cliente>> ObtenerClientesAsync()
        {
            var query = await _repositoryCliente.GetAllAsync();

            List<Cliente> clientes = await query.ToListAsync();
            return clientes;
        }

        public async Task<Cliente> CrearClienteAsync(ClienteDTO clienteDto)
        {

            Persona persona = new Persona { 
                Direccion = clienteDto.Direccion,
                Genero = clienteDto.Genero,
                Identificacion = clienteDto.Identificacion,
                Nombres = clienteDto.Nombre,
                Telefono = clienteDto.Telefono 
            };

            Cliente cliente = new Cliente
            {
                Estado = true,
                Password = clienteDto.Password
            };

            await _repositoryPersona.CreateEntityAsync(persona);
            await _repositoryPersona.SaveAsync();

            cliente.PersonaId = persona.Id;
            await _repositoryCliente.CreateEntityAsync(cliente);
            await _repositoryCliente.SaveAsync();
            return cliente;
        }

        public async Task<Cliente> EditarClienteAsync(ClienteDTO clienteDto)
        {
            Cliente cliente = await _repositoryCliente.GetEntityByIdAsync(clienteDto.ClienteId);

            cliente.Password = clienteDto.Password;

            Persona persona = await _repositoryPersona.GetEntityByIdAsync(cliente.PersonaId);

            persona.Direccion = clienteDto.Direccion;
            persona.Identificacion = clienteDto.Identificacion;
            persona.Nombres = clienteDto.Nombre;
            persona.Telefono = clienteDto.Telefono;
            persona.Genero = clienteDto.Genero;

            await _repositoryPersona.UpdateEntityAsync(persona);
            await _repositoryPersona.SaveAsync();

            await _repositoryCliente.UpdateEntityAsync(cliente);
            await _repositoryCliente.SaveAsync();
            return cliente;
        }

        public async Task EliminarClienteAsync(int id)
        {
            await _repositoryCliente.DeleteEntityAsync(id);
            await _repositoryCliente.SaveAsync();
        }
    }
}
