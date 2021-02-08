using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stepper.BL.Model
{
    [Serializable]
    class ConfigData
    {
        public string ConfigFilePath { get; } = "C:\\Users\\iliya\\OneDrive\\Desktop\\конфиг.txt";

        public Dictionary<string, double> Config { get; set; } = new Dictionary<string, double>();

        public ConfigData(string configFilePath)
        {
            ConfigFilePath = configFilePath ?? throw new ArgumentNullException(nameof(configFilePath));
            Config = new Dictionary<string, double>();
           
        }
    }
}
