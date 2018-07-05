using NLog;
using System;
using UnityEngine;

public class Calculate
{
    //public static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    public static NLog.Logger logger = LogManager.GetLogger("Calculate");

    public int Div(int a, int b)
    {
        // logs to file specified in Unity
        logger.Error("dllError");
        try
        {
            int x = a / b;
            logger.Debug("dlllog: " + x);
            Debug.Log("logtoUnityConsoleTest");
            return x;
        }
        catch (Exception ex)
        {
            logger.Error(ex);
        }
        return 0;
    }
}