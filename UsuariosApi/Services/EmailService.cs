using MailKit.Net.Smtp;
using MimeKit;
using System;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class EmailService
    {
        public void EnviarEmail(string[] emailDestinatario, string assunto,int UsuarioId, string codigoDeAtivacao)
        {
            Mensagem mensagem = new Mensagem(emailDestinatario, assunto, UsuarioId, codigoDeAtivacao);
            var mensagemDeEmail = CriaCorpoDoEmail(mensagem);
            Enviar(mensagemDeEmail);
        }

        private void Enviar(MimeMessage mensagemDeEmail)
        {
            using(var client = new SmtpClient())
            {
                try
                {
                    client.Connect("conexão a fazer");
                    //Configurar provedor de email
                    client.Send(mensagemDeEmail);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CriaCorpoDoEmail(Mensagem mensagem)
        {
            var mensagemDeEmail = new MimeMessage();
            mensagemDeEmail.From.Add(new MailboxAddress("Adicionar remetente"));
            mensagemDeEmail.To.AddRange(mensagem.Destinatario);
            mensagemDeEmail.Subject = mensagem.Assunto;
            mensagemDeEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = mensagem.Assunto
            };

            return mensagemDeEmail;
        }
    }
}
