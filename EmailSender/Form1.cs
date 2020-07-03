using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials=new NetworkCredential()
                {
                    UserName="vhoagamo3@gmail.com",
                    Password= "ebysqhpbglvgjfje"
                }
            };
            MailAddress FromEmail = new MailAddress("vhoagamo3@gmail.com", "Vahagn Hovhannisyan");
            MailAddress ToEmail = new MailAddress(emailText.Text, "Someone");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = subjectText.Text,
                Body = messageText.Text,

            };
            Message.To.Add(ToEmail);

            Client.SendCompleted += Client_SendCompleted;
            Client.SendMailAsync(Message);
            //try
            //{
            //Client.Send(Message);
            //    MessageBox.Show("Message sent successfuly", "Done");

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something wrong \n "+ex.Message, "Error");

            //}

        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error!=null)
            {
                MessageBox.Show("Error happening \n " + e.Error.Message, "Error");
                return;
            }
            MessageBox.Show("Sent successfuly", "Done");
        }
    }
}
