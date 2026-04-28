using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul9_103022400008
{
    public class BankTransferConfig
    {

        public Config config;

        string path = "bank_transfer_config.json";

        public BankTransferConfig() {
            try
            {
                ReadJson();
            }
            catch{
                WriteJSON();
                setDefaultJSON(); 
            }
        } 

        public void ReadJson()
        {
            string stringy = File.ReadAllText(path);

            config = JsonSerializer.Deserialize<Config>(stringy);
        }

        public void WriteJSON() {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            string output = JsonSerializer.Serialize(config, options);
            File.WriteAllText(path, output);
        }

        public void setDefaultJSON()
        {
            config = new Config();

            config.lang = "en";

            Transfer transfer = new Transfer(25000000, 6500, 15000);

            config.transfer = transfer;

            List<string> method = new List<string> { 
                "RTO real-time", "SKN", "RTGS", "BI FAST"
            };

            config.Method = method;

            Confirmation confirmation = new Confirmation("yes", "ya");

            config.confirm = confirmation;
        }
    }
}
