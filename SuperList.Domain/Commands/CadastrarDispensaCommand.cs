using System;

namespace SuperList.Domain.Commands
{
    public class CadastrarDispensaCommand
    {
        public CadastrarDispensaCommand(Guid usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public Guid UsuarioId { get; private set; }
    }
}
