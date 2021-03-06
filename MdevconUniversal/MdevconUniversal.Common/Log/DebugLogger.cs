﻿using MdevconUniversal.Common.Contracts;

namespace MdevconUniversal.Common.Log
{
    public class DebugLogger : ILogger
    {
        public void Debug(string message)
        {
            System.Diagnostics.Debug.WriteLine("[DEBUG] - " + message);
        }

        public void Error(string message)
        {
            System.Diagnostics.Debug.WriteLine("[ERROR] - " + message);
        }
    }
}