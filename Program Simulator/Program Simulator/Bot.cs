using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program_Simulator
{
    internal class Bot
    {
        private readonly string kBotFilePath;
        private bool isCommunicationEstablished = false;

        private Process process;
        private StreamWriter consoleWriter;
        private StreamReader consoleReader;

        public string mBotName;
        private Vector2 position = new Vector2(0, 0);
        public List<Vector2> traversedSpaces = new List<Vector2>();
        public int mPathCost;

        public Vector2 mCoordinates
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
                traversedSpaces.Add(value);
                mPathCost += Board.GetWeight(value);
            }
        }



        public Bot(string botFilePath)
        {
            kBotFilePath = botFilePath;
        }

        /// <summary>
        /// Opens the bot's exe file to start communication with the bot
        /// </summary>
        public void Start()
        {
            traversedSpaces.Clear();
            mPathCost = 0;

            // Start the C# program
            process = new Process();
            process.StartInfo.FileName = kBotFilePath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            consoleWriter = process.StandardInput;
            consoleWriter.WriteLine("Reading?");
            consoleWriter.Flush();

            consoleReader = process.StandardOutput;
            string text = consoleReader.ReadLine();
            if (text != "") 
            {
                mBotName = text;
                isCommunicationEstablished = true; 
            }
        }

        public void SendConsoleMessages(string message)
        {
            consoleWriter.WriteLine(message);
            consoleWriter.Flush();
        }
        public void SendConsoleMessages(List<string> messages)
        {
            foreach (string message in messages)
            {
                consoleWriter.WriteLine(message);
                consoleWriter.Flush();
            }
        }

        public List<string> ReadNewConsoleMessages()
        {
            List<string> readMessages = new List<string>();

            string output = consoleReader.ReadLine();

            while (output != "Over")
            {
                readMessages.Add(output);

                output = consoleReader.ReadLine();
            }

            return readMessages;
        }

        public void End()
        {
            // Close the process
            //process.WaitForExit();
            process.Close();

            isCommunicationEstablished = false;
        }

        public void Clear()
        {
            traversedSpaces.Clear();
            mPathCost = 0;
        }
    }
}
