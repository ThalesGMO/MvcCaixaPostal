using System.Collections;
using System.Collections.Generic;
using SistemaCaixaPostal.Core.Enums;
using SistemaCaixaPostal.Core.Helpers;

namespace SistemaCaixaPostal.Core.Interfaces.Helpers;

public interface INotification
{
    void Adicionar(string mensagem, TipoNotificacaoEnum tipo);
    bool TemNotificacao();
    string LerNotificacao();
}