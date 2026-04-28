using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;

namespace Modul9_103022400104
{
    public class BankTransferConfig
    {

        public Config config;
        private CountdownEvent string filePath = @"Bank+transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                if(File.Exists(filePath))
            }
            catch
            {

            }
        }
            
        public void readConfig
        {
            string json = File.ReadAllText(filePath);
            Config = JsonSeriallizer.Deserialixe<config>(JsonArray);
        }
        public void writeConfig
        {
            jsonSeriallizerOptions option = jsonSerializer;
            

        }
}
