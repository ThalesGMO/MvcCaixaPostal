using Model = SistemaCaixaPostal.Core.Models;
using SistemaCaixaPostal.Core.Interfaces.Helpers;
using SistemaCaixaPostal.Core.Enums;

namespace SistemaCaixaPostal.ViewModels;

public class SocioViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string QueryString { get; set; }
    public string CancelMessage { get; set; }

    public SocioViewModel()
    {
        
    }

    public SocioViewModel(Model.Socio socio)
    {
        Id = socio.Id;
        Nome = socio.Nome;
        Email = socio.Email;
        Telefone = socio.Telefone;
    }

    public virtual bool IsValid(INotification notification)
    {
        if (string.IsNullOrEmpty(Nome))
            notification.Adicionar("O Preenchimento do campo Nome é obrigatório", TipoNotificacaoEnum.Erro);
        
        if (string.IsNullOrEmpty(Email))
            notification.Adicionar("O Preenchimento do campo Email é obrigatório", TipoNotificacaoEnum.Erro);
        
        if (string.IsNullOrEmpty(Telefone))
            notification.Adicionar("O Preenchimento do campo Telefone é obrigatório", TipoNotificacaoEnum.Erro);

        return !notification.TemNotificacao();
    }
}