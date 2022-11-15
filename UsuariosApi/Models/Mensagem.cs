using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace UsuariosApi.Models
{
    public class Mensagem
    {
        public List<MailboxAddress> Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }

        public Mensagem(IEnumerable<string> emailDestinatario, string assunto, int usuarioId, string codigoDeAtivacao)
        {
            this.Destinatario = new List<MailboxAddress>();
            this.Destinatario.AddRange(emailDestinatario.Select(d => new MailboxAddress(d)));
            this.Assunto = assunto;
            this.Conteudo = $"https://localhost:6001/ativa?UsuarioId={usuarioId}&CodigoDeAtivacao={codigoDeAtivacao}";
        }
    }
}
