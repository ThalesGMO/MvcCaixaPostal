using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaCaixaPostal.Core.Enums;
using SistemaCaixaPostal.Core.Interfaces.Helpers;

namespace SistemaCaixaPostal.Core.Helpers;

public class Notification : INotification
{
    private readonly List<NotificacaoItem> notificacoes = [];

    public void Adicionar(string mensagem, TipoNotificacaoEnum tipo)
    {
        notificacoes.Add(new NotificacaoItem(mensagem, tipo));
    }

    public string LerNotificacao()
    {
        if (!notificacoes.Any()) return string.Empty;

        var sb = new StringBuilder();
        foreach (var item in notificacoes)
        {
            sb.AppendLine($"Mensagem: {item.Mensagem} - Tipo: {item.Tipo}");
        }
        return sb.ToString();
    }

    public bool TemNotificacao()
    {
        return notificacoes.Any();
    }

    internal class NotificacaoItem
    {
        internal NotificacaoItem(string mensagem, TipoNotificacaoEnum tipo)
        {
            Mensagem = mensagem;
            Tipo = tipo;
        }

        public string Mensagem { get; }
        public TipoNotificacaoEnum Tipo { get; }
    }
}