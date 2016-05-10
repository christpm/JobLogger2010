using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////////////////////////////
//File: JobLogger.cs
//Classes: JobLogger
//Author: Christian Alfredo Pujadas Mendoza
//Date: 05-05-2016
//Description: This class log different messages (message, warning or error) 
//             throughout an application
///////////////////////////////////////////////////////////////////////////////////////////////

namespace JobLoggerTestNamespace
{
    public class JobLogger
    {
        private static bool _logToFile;
        private static bool _logToConsole;
        private static bool _logToDatabase;
        private static int _messageType;
        private bool _initialized;

        public bool LogToFile
        {
            get
            {
                return _logToFile;
            }
            set
            {
                _logToFile = value;
            }
        }

        public bool LogToConsole
        {
            get
            {
                return _logToConsole;
            }
            set
            {
                _logToConsole = value;
            }
        }

        public bool LogToDatabase
        {
            get
            {
                return _logToDatabase;
            }
            set
            {
                _logToDatabase = value;
            }
        }

        public static int MessageType
        {
            get
            {
                return _messageType;
            }
            set
            {
                if ((value > 0) && (value < 4))
                {
                    _messageType = value;
                }
                else
                {
                    _messageType = -1;
                }
            }
        }

        public bool Initialized
        {
            get
            {
                return _initialized;
            }
            set
            {
                _initialized = value;
            }
        }

        public JobLogger(bool logToFile, bool logToConsole, bool logToDatabase, int messageType)
        {
            LogToFile = logToFile;
            LogToConsole = logToConsole;
            LogToDatabase = logToDatabase;
            MessageType = messageType;
            Initialized = true;
        }

        //private static bool InsertIntoDatabase(string messageString, string messageType)
        public bool InsertIntoDatabase(string messageString, string messageType)
        {
            bool insertIntoDatabaseReturn = false;

            try
            {
                int numberFromMessageType;
                bool isNumeric = int.TryParse(messageType, out numberFromMessageType);

                //if (isNumeric && (Convert.ToInt16(messageType) > 0) && (Convert.ToInt16(messageType) < 4) && messageString != string.Empty)
                if (isNumeric && (Convert.ToInt16(messageType) > 0) && messageString != string.Empty)
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

                    connection.Open();

                    string sqlQueryInsertInto = "Insert into Log Values('" + messageString + "'," + messageType + ")";

                    SqlCommand command = new SqlCommand(sqlQueryInsertInto);
                    command.ExecuteNonQuery();

                    connection.Close();

                    insertIntoDatabaseReturn = true;
                }
            }
            catch
            {
                insertIntoDatabaseReturn = false;
            }

            return insertIntoDatabaseReturn;
        }

        //public static string LoggerMessage(string messageString, bool message, bool warning, bool error)
        public string LoggerMessage(string messageString, bool message, bool warning, bool error)
        {
            string LogMessageReturn = string.Empty;

            if (messageString != string.Empty)
            {
                if (messageString != null)
                {
                    if (VerifyMessage(messageString))
                    {
                        string verifyConfigurationReturn = VerifyConfiguration(LogToConsole, LogToFile, LogToDatabase);
                        LogMessageReturn = verifyConfigurationReturn;

                        if (verifyConfigurationReturn == string.Empty)
                        {
                            string verifySpecificationReturn = VerifySpecification(message, warning, error, MessageType);
                            LogMessageReturn = verifySpecificationReturn;

                            if (verifySpecificationReturn == string.Empty)
                            {
                                bool mesageTypePermitedToLog = false;
                                mesageTypePermitedToLog = (message && MessageType == 1) || (warning && MessageType == 2) || (error && MessageType == 3);

                                bool writeToFileReturn = false;

                                if (LogToFile && mesageTypePermitedToLog)
                                {
                                    writeToFileReturn = SaveToFile(messageString);
                                }

                                bool writeToConsole = false;

                                if (LogToConsole && mesageTypePermitedToLog)
                                {
                                    writeToConsole = WriteToConsole(messageString, message, warning, error, MessageType);
                                }

                                bool insertIntoDatabaseReturn = false;

                                if (LogToDatabase && mesageTypePermitedToLog)
                                {
                                    insertIntoDatabaseReturn = InsertIntoDatabase(messageString, MessageType.ToString());
                                }
                            }
                        }
                    }
                }
                else
                {
                    LogMessageReturn = "Message_string_cannot_be_null";
                }
            }
            else
            { 
                LogMessageReturn = "Message_string_cannot_be_empty";
            }
            return LogMessageReturn;
        }

        //private static bool SaveToFile(string messageString)
        public bool SaveToFile(string messageString)
        {
            bool writeToFileReturn = false;

            try
            {
                if (messageString != string.Empty)
                {
                    if (messageString != null)
                    {
                        string stringMessageToTxtFile = string.Empty;
                        //string pathAndFileString = ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt";
                        string pathAndFileString = Environment.CurrentDirectory + "\\LogFile" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";

                        using (StreamWriter sw = File.AppendText(pathAndFileString))
                        {
                            sw.WriteLine(DateTime.Now.ToShortDateString() + " " + messageString);
                        }

                        writeToFileReturn = true;
                    }
                }
            }
            catch
            {
                writeToFileReturn = false;
            }

            return writeToFileReturn;
        }

        //private static string VerifyConfiguration(bool logToConsole, bool logToFile, bool logToDatabase)
        public string VerifyConfiguration(bool logToFile, bool logToConsole, bool logToDatabase)
        {
            string verifyConfigurationReturn = string.Empty;

            if (!logToFile && !logToConsole && !logToDatabase)
            {
                verifyConfigurationReturn = "Invalid_configuration";
            }

            return verifyConfigurationReturn;
        }

        //private static bool VerifyMessage(string messageString)
        public bool VerifyMessage(string messageString)
        {
            bool verifyMessageReturn = true;

            if (messageString == null)
            {
                verifyMessageReturn = false;
            }
            else if (messageString.Length == 0)
            {
                messageString.Trim();
                verifyMessageReturn = false;
            }

            return verifyMessageReturn;
        }

        //private static string VerifySpecification(bool logError, bool logMessage, bool logWarning, int messageType)
        public string VerifySpecification(bool message, bool warning, bool error, int messageType)
        {
            string verifySpecificationReturn = string.Empty;

            //if ((!logError && !logMessage && !logWarning) || messageType == -1)
            if ((!message && !warning && !error) || !((messageType > 0) && (messageType < 4)))
            {
                verifySpecificationReturn = "Error_or_Warning_or_Message_must_be_specified";
            }

            return verifySpecificationReturn;
        }

        //private static bool WriteToConsole(string messageString, bool message, bool warning, bool error, int messageType)
        public bool WriteToConsole(string messageString, bool message, bool warning, bool error, int messageType)
        {
            bool writeToConsoleReturn = false;

            Console.ForegroundColor = ConsoleColor.Gray;

            if (messageString != null && messageString != string.Empty)
            {
                if (message && messageType == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    writeToConsoleReturn = true;
                }
                else if (error && messageType == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    writeToConsoleReturn = true;
                }
                else if (warning && messageType == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    writeToConsoleReturn = true;
                }

                if (writeToConsoleReturn)
                {
                    Console.WriteLine(DateTime.Now.ToShortDateString() + " - " + messageString);
                }
                
                Thread.Sleep(100);
            }

            return writeToConsoleReturn;
        }
    }
}