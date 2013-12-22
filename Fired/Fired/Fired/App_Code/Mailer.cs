using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

public static class Mailer
{

    //below function needs to be updated from lasunka
    public static string SendEmail(string MsgFrom, string MsgTo
            , string MsgSubject = " "
            , string MsgBody = " "
            , bool MsgIsBodyHtml = false
            , int MsgPriority = 0
            , string MsgCC = null
            , string MsgBcc = null
            , string MsgAttachPath = null)
    {
        string result = null;

        try
        {
            MailMessage MailMsg = new MailMessage();
            
            MailMsg.From = new MailAddress(MsgFrom);

            MailMsg.To.Add(new MailAddress("asminfo@bk.ru"));

            if (MsgCC != null)
            {
                MailMsg.CC.Add(new MailAddress("asminfo@bk.ru"));
            }
            else if (MsgBcc != null)
            {
                MailMsg.Bcc.Add(new MailAddress("asminfo@bk.ru"));
            }
            else if (MsgAttachPath != null)
            {
                Attachment MailAttach = null;
                MailAttach = new Attachment("C:\\Temp\\resume.doc");
                MailMsg.Attachments.Add(MailAttach);
            }


            MailMsg.Subject = MsgSubject;
            MailMsg.Body = MsgBody;
            MailMsg.IsBodyHtml = MsgIsBodyHtml;


            switch (MsgPriority)
            {
                case 1:
                    MailMsg.Priority = MailPriority.Low;
                    break;
                case 2:
                    MailMsg.Priority = MailPriority.High;
                    break;
                default:
                    MailMsg.Priority = MailPriority.Normal;
                    break;
            }
            SmtpClient mySmtpClient = new SmtpClient();
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