//http://zetcode.com/db/mysqlcsharptutorial/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Properties;


public static class UserManager
{
    public static string RegisterUser(string email, string password, string ipAddress)
    {
        string result = null;

        string connStr = GlobalVars.mySqlConnStringUsers;
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();
        MySqlCommand cmd;

        try
        {

            #region Check Email
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            string sqlExistsStatement
                = "SELECT * FROM tbl_users WHERE EMAIL=@EMAIL LIMIT 1";
            cmd.CommandText = sqlExistsStatement;
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Prepare();

            MySqlDataReader dtaRdr = cmd.ExecuteReader();

            if (!dtaRdr.HasRows)
            {

                dtaRdr.Close();

                #region Add User to DB
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;

                string sqlInsertStatement
                    = "INSERT INTO tbl_users "
                    + " (EMAIL, PASSWORD, IP_ADDRESS, CREATE_DATETIME) "
                    + " VALUES (@EMAIL, @PASSWORD, @IP_ADDRESS,  NOW())";
                cmd.CommandText = sqlInsertStatement;
                cmd.Parameters.AddWithValue("@EMAIL", email);

                cmd.Parameters.AddWithValue("@PASSWORD", Cryptography.Encrypt(password));
                cmd.Parameters.AddWithValue("@IP_ADDRESS", ipAddress);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                #endregion
                
                #region Sending Confirmation email to registered User"
                string MsgFrom = GlobalVars.projectMsgFrom;
                string MsgTo = email;
                string MsgSubject = "Welcome to " + GlobalVars.projectName;
                string MsgBody = "Congratulations! ,<br><br>" + "New account is successfully created for You: <br>" + "Password: " + password + "<br><br><br>" + "Thanks again for creating your account at " + GlobalVars.projectName + ". <br><br>";
                bool MsgIsBodyHtml = true;
                int MsgPriority = 2;
                string MsgAttachPath = null;
                string MsgCC = GlobalVars.projectMsgCC;
                string MsgBcc = GlobalVars.projectMsgBcc;
                result = Mailer.SendEmail(MsgFrom, MsgTo, MsgSubject, MsgBody, MsgIsBodyHtml, MsgPriority, MsgCC, MsgBcc, MsgAttachPath);
                #endregion

            }
            else
            {
                result = GlobalVars.mySqlMsgUserIsAlreadyRegistered;
            }
            if (dtaRdr != null)
            {
                dtaRdr.Close();
            }


            #endregion

        }


        catch (MySqlException e)
        {
            result = e.Message.Trim();
        }

        finally
        {
            if (conn != null)
            {
                conn.Close();
            }

        }
        return result;

    }


    public static string EmailPasswordToUser(string email)
    {
        string result = null;

        string connStr = GlobalVars.mySqlConnStringUsers;
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        
        try
        {
            #region Check Email

            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            string sqlExistsStatement
                = "SELECT PASSWORD FROM tbl_users WHERE EMAIL=@EMAIL";
            cmd.CommandText = sqlExistsStatement;
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Prepare();

            MySqlDataReader dtaRdr = cmd.ExecuteReader();

            if (dtaRdr.HasRows)
            {
                string password;
                while (dtaRdr.Read())
                {
                    password = dtaRdr.GetString(0);
                    password = Cryptography.Decrypt(password);

                    #region Sending email with password to user's email"
                    string MsgFrom = GlobalVars.projectMsgFrom;
                    string MsgTo = email;
                    string MsgSubject = GlobalVars.projectName + " password reminder";
                    string MsgBody = "Dear User, <br><br>" + "Your Password is: " + password + "<br><br><br>" + "Thanks again for using " + GlobalVars.projectName + ". <br><br>";
                    bool MsgIsBodyHtml = true;
                    int MsgPriority = 2;
                    string MsgAttachPath = null;
                    string MsgCC = GlobalVars.projectMsgCC;
                    string MsgBcc = GlobalVars.projectMsgBcc;
                    result = Mailer.SendEmail(MsgFrom, MsgTo, MsgSubject, MsgBody, MsgIsBodyHtml, MsgPriority, MsgCC, MsgBcc, MsgAttachPath);
                    #endregion


                    break;
                }

                if (dtaRdr != null)
                {
                    dtaRdr.Close();
                }

            }
            else
            {
                result = GlobalVars.mySqlMsgEmailNotFound;
            }

            #endregion

        }


        catch (MySqlException e)
        {
            result = e.Message.Trim();
        }

        finally
        {
          

            if (conn != null)
            {
                conn.Close();
            }

        }
        return result;

    }


    public static string GetUserIP()
    {
        // This returns the True IP of the client calling the requested page
        // Checks to see if HTTP_X_FORWARDED_FOR has a value then the client is operating via a proxy
        string ip;

        try
        {

            ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            //If Result.ToString.Trim.Length = 0 Then
            if (ip == null)
            {
                ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            return ip.Trim();
        }


        catch (Exception e)
        {
            return e.Message;
        }
    }
}
