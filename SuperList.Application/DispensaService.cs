using SuperList.Domain;
using SuperList.Domain.Commands;
using SuperList.Domain.Repositories;
using SuperList.Domain.Services;
using System;
using System.Collections.Generic;

namespace SuperList.Application
{
    public class DispensaService : IDispensaService
    {
        readonly IDispensaRepository dispensaRepository;

        public DispensaService(IDispensaRepository dispensaRepository)
        {
                
        }

        //public IList<int> ObterDispensaPadrao(Guid usuarioId)
        //{

        //}

        public void Cadastrar(CadastrarDispensaCommand command)
        {
            //var dispensa = new Dispensa();
            //dispensa.CriarDispensa(dispensaRepository.NextIdentity(), command.UsuarioId);
            //dispensaRepository.Save(dispensa);
        }
    }
}
