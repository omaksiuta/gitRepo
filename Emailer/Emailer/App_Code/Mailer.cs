//http://stackoverflow.com/questions/449887/sending-e-mail-using-c-sharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;


public static class Mailer
{

    //below function needs to be updated from lasunka
    public static string SendEmail(string msgFrom
            , string msgTo
            , string msgSubject
            , string msgBody
            , bool msgIsBodyHtml
            , string msgPriority
            , string msgCC
            , string msgBcc
            , string msgAttachPath
        , string setSmtpHost
        , string setSmtpPort
        , string setLoginEmail
        , string setPassword)
    {
        string result = null;

        try
        {
            System.Net.Mail.MailMessage MailMsg = new System.Net.Mail.MailMessage();

            MailMsg.From = new MailAddress(msgFrom.Trim());
            //MailMsg.Sender = new MailAddress(msgSender.Trim());

            MailMsg.To.Add(new MailAddress(msgTo.Trim()));

            if (msgCC != null)
            {
                MailMsg.CC.Add(new MailAddress(msgCC));
            }

            if (msgBcc != null)
            {
                MailMsg.Bcc.Add(new MailAddress(msgBcc));
            }

            if (msgAttachPath.ToString().Trim().Length > 0)
            {
                Attachment MailAttach = new Attachment(msgAttachPath);
                //MailAttach = new Attachment("C:\\Temp\\resume.doc");
                MailMsg.Attachments.Add(MailAttach);
            }

            MailMsg.Subject = msgSubject;
            MailMsg.Body = msgBody;
            MailMsg.IsBodyHtml = msgIsBodyHtml;
            MailMsg.SubjectEncoding = System.Text.Encoding.UTF8;
            MailMsg.BodyEncoding = System.Text.Encoding.UTF8;

            switch (msgPriority)
            {
                case "Low":
                    MailMsg.Priority = MailPriority.Low;
                    break;
                case "High":
                    MailMsg.Priority = MailPriority.High;
                    break;
                default:
                    MailMsg.Priority = MailPriority.Normal;
                    break;
            }
            SmtpClient mySmtpClient = new SmtpClient();
            mySmtpClient.UseDefaultCredentials.Equals(false);
            mySmtpClient.Host = setSmtpHost;
            //mySmtpClient.EnableSsl = true;
            System.Net.NetworkCredential authenticationInfo = new
                System.Net.NetworkCredential(setLoginEmail, setPassword);

            mySmtpClient.Credentials = authenticationInfo;



            mySmtpClient.Send(MailMsg);
            MailMsg.Dispose();
        }
        catch (Exception ex)
        {
            result = ex.Message;

            //errorFuncs.processError(DBNull.Value.ToString(), errorFuncs.whoCalledMe(), ex, null);
        }
        return result;
    }
}