using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using UnityEngine;

public class Calculate
{
    //public static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    public static NLog.Logger logger = LogManager.GetLogger("Calculate");

    public delegate void LogReceived(string foo);

    public event LogReceived Logged;

    public int Div(int a, int b)
    {
        var config = new LoggingConfiguration();
        var fileTarget = new FileTarget("targetFile")
        {
            FileName = "C:/Users/Akhilkj/Documents/CalculatorTest/Logs/Test.log",
            Layout = "${longdate} ${level} ${message}  ${exception}"
        };
        config.AddTarget(fileTarget);
        config.AddRuleForOneLevel(LogLevel.Error, fileTarget);
        LogManager.Configuration = config;
        try
        {
            int x = a / b;
            Logged("dllLog " + x.ToString());
            //Logs to Unity Console
            Debug.Log("logtoUnityTest");
            return x;
        }
        catch (Exception ex)
        {
            logger.Error(ex);
        }
        return 0;
    }
}