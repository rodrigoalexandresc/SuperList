using SuperList.Domain.Commands;

namespace SuperList.Domain.Services
{
    public interface IDispensaService
    {
        void Cadastrar(CadastrarDispensaCommand command);
    }
}
