using JobLoggerTestNamespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///////////////////////////////////////////////////////////////////////////////////////////////
//File: JobLoggerTest.cs
//Classes: JobLoggerTest
//Author: Christian Alfredo Pujadas Mendoza
//Date: 07-05-2016
//Description: Test of JobLogger methods
///////////////////////////////////////////////////////////////////////////////////////////////

namespace JobLoggerTestNamespace
{
    [TestClass]
    public class JobLoggerTest
    {
        [TestMethod]
        public void InsertIntoDatabaseTest1()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test InsertIntoDatabaseTest1";
            string messageType1 = "1";
            bool expected = false;
            bool actual = target.InsertIntoDatabase(messageString, messageType1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertIntoDatabaseTest2()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            string messageType1 = "1";
            bool expected = false;
            bool actual = target.InsertIntoDatabase(messageString, messageType1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertIntoDatabaseTest3()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            string messageType1 = null;
            bool expected = false;
            bool actual = target.InsertIntoDatabase(messageString, messageType1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveToFileTest1()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test SaveToFile1";
            bool expected = true;
            bool actual = target.SaveToFile(messageString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveToFileTest2()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool expected = false;
            bool actual = target.SaveToFile(messageString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveToFileTest3()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool expected = false;
            bool actual = target.SaveToFile(messageString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyConfigurationTest1()
        {
            bool logToFile = false;
            bool logToConsole = false;
            bool logToDatabase = false;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string expected = "Invalid_configuration";
            string actual = target.VerifyConfiguration(logToFile, logToConsole, logToDatabase);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyConfigurationTest2()
        {
            bool logToFile = false;
            bool logToConsole = false;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string expected = string.Empty;
            string actual = target.VerifyConfiguration(logToFile, logToConsole, logToDatabase);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyMessageTest1()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test VerifyMessage1";
            bool expected = true;
            bool actual = target.VerifyMessage(messageString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyMessageTest2()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool expected = false;
            bool actual = target.VerifyMessage(messageString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyMessageTest3()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool expected = false;
            bool actual = target.VerifyMessage(messageString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifySpecificationTest1()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = string.Empty;
            string actual = target.VerifySpecification(message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifySpecificationTest2()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = string.Empty;
            string actual = target.VerifySpecification(message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifySpecificationTest3()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = string.Empty;
            string actual = target.VerifySpecification(message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifySpecificationTest4()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = -10;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = "Error_or_Warning_or_Message_must_be_specified";
            string actual = target.VerifySpecification(message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteToConsoleTest1()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test WriteToConsole1";
            bool message = true;
            bool warning = true;
            bool error = true;
            bool expected = true;
            bool actual = target.WriteToConsole(messageString, message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteToConsoleTest2()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool message = true;
            bool warning = true;
            bool error = true;
            bool expected = false;
            bool actual = target.WriteToConsole(messageString, message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteToConsoleTest3()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool message = true;
            bool warning = true;
            bool error = true;
            bool expected = false;
            bool actual = target.WriteToConsole(messageString, message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteToConsoleTest4()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test WriteToConsole4";
            bool message = true;
            bool warning = true;
            bool error = true;
            bool expected = true;
            bool actual = target.WriteToConsole(messageString, message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteToConsoleTest5()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 3;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test WriteToConsole5";
            bool message = true;
            bool warning = true;
            bool error = true;
            bool expected = true;
            bool actual = target.WriteToConsole(messageString, message, warning, error, messageType);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest1()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest1";
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = string.Empty;
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest2()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest2";
            bool message = false;
            bool warning = false;
            bool error = false;
            string expected = "Error_or_Warning_or_Message_must_be_specified";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest3()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest3";
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = string.Empty;
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest4()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_empty";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest5()
        {
            bool logToFile = true;
            bool logToConsole = true;
            bool logToDatabase = true;
            int messageType = 1;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_null";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest6()
        {
            bool logToFile = false;
            bool logToConsole = false;
            bool logToDatabase = false;
            int messageType = 2;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest6";
            bool message = false;
            bool warning = false;
            bool error = false;
            string expected = "Invalid_configuration";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest7()
        {
            bool logToFile = false;
            bool logToConsole = false;
            bool logToDatabase = false;
            int messageType = 2;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest7";
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Invalid_configuration";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest8()
        {
            bool logToFile = false;
            bool logToConsole = false;
            bool logToDatabase = false;
            int messageType = 2;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_empty";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest9()
        {
            bool logToFile = false;
            bool logToConsole = false;
            bool logToDatabase = false;
            int messageType = 2;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_null";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest10()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 3;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest10";
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = string.Empty;
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest11()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 3;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest11";
            bool message = false;
            bool warning = false;
            bool error = false;
            string expected = "Error_or_Warning_or_Message_must_be_specified";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest12()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 3;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest12";
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = string.Empty;
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest13()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 3;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_empty";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest14()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 3;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_null";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest15()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 8;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest15";
            bool message = true;
            bool warning = true;
            bool error = true;
            string expected = "Error_or_Warning_or_Message_must_be_specified";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest16()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 8;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest16";
            bool message = false;
            bool warning = false;
            bool error = false;
            string expected = "Error_or_Warning_or_Message_must_be_specified";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest17()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 8;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = "Test LoggerMessageTest17";
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Error_or_Warning_or_Message_must_be_specified";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest18()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 8;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = string.Empty;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_empty";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoggerMessageTest19()
        {
            bool logToFile = false;
            bool logToConsole = true;
            bool logToDatabase = false;
            int messageType = 8;
            JobLogger target = new JobLogger(logToFile, logToConsole, logToDatabase, messageType);
            string messageString = null;
            bool message = true;
            bool warning = false;
            bool error = true;
            string expected = "Message_string_cannot_be_null";
            string actual = target.LoggerMessage(messageString, message, warning, error);
            Assert.AreEqual(expected, actual);
        }
    }
}