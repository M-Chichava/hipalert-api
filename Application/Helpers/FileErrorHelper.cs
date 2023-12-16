﻿using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Application.Helpers
{
    public class FileErrorHelper
    {
        public FileErrorHelper()
        {
        }
        
        // This method is called when a certain error occurs and saves the error in a log file.
        public static void SaveError(IConfiguration configuration, int statusCode, string message, string details)
        {
            string path = $"{configuration["LogErrorDirectory"]}{DateTime.Today.ToString("yyyyMMdd")}.txt";
            
            FileStream fileStream = new FileStream(path, FileMode.Append);

            var ms = DateTime.Now + "-" + "Status Code: " + statusCode + " - " + message + " - Details: " + details +
                     "\n" + "\n";

            byte[] messageByteArray = new UTF8Encoding(true).GetBytes(ms);
            
            fileStream.Write(messageByteArray, 0, messageByteArray.Length);
            fileStream.Flush();
            fileStream.Dispose();
        }
    }
}