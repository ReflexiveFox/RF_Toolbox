#define DEBUG

using System;
using UnityEngine;

namespace RF_Toolbox.Utilities
{
    /// <summary>
    /// Custom Debug Logger for RF_Toolbox.
    /// Automatically includes the source class and method name in log messages.
    /// Can be globally enabled/disabled using the DEBUG flag.
    /// </summary>
    public static class RFLogger
    {
        /// <summary>
        /// Logs a message to the Unity Console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void Log(string message)
        {
#if DEBUG
            Debug.Log(FormatMessage(message));
#endif
        }

        /// <summary>
        /// Logs a warning message to the Unity Console.
        /// </summary>
        /// <param name="message">The warning message to log.</param>
        public static void LogWarning(string message)
        {
#if DEBUG
            Debug.LogWarning(FormatMessage(message));
#endif
        }

        /// <summary>
        /// Logs an error message to the Unity Console.
        /// </summary>
        /// <param name="message">The error message to log.</param>
        public static void LogError(string message)
        {
#if DEBUG
            Debug.LogError(FormatMessage(message));
#endif
        }

        /// <summary>
        /// Formats the log message to include contextual information.
        /// </summary>
        /// <param name="message">The original log message.</param>
        /// <returns>Formatted log message.</returns>
        private static string FormatMessage(string message)
        {
            var stackFrame = new System.Diagnostics.StackTrace(2).GetFrame(0);
            var method = stackFrame?.GetMethod();
            var className = method?.DeclaringType?.Name ?? "UnknownClass";
            var methodName = method?.Name ?? "UnknownMethod";

            return $"<color=cyan>[{className}::{methodName}]:</color> {message}";
        }
    }
}
