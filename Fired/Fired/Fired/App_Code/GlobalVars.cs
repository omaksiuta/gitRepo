using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for GlobalVars
/// </summary>
public static class GlobalVars
{
    public static string projectName = "CutFires";
    public static string projectUrl = "www.cutfires.org";
    public static string projectMsgFrom = "asminfo@bk.ru";
    public static string projectMsgCC = null;
    public static string projectMsgBcc = null;

    public static string urlParamValueDelimiter = ",";
    public static string mySqlConnStringUsers//string connStr = "server=127.0.0.1;uid=root;pwd=12345;database=test;";
            = "Host=localhost;Character Set=utf8;database=test";
    public static string mySqlMsgUserIsAlreadyRegistered = "User with this email is already registered.";
    public static string mySqlMsgEmailNotFound = "Specified email does not exist.";


}