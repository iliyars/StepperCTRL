using Stepper.BL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stepper.BL.Controller
{
    /// <summary>
    /// Запись данных в файл.
    /// </summary>
    public class FileManager
    {
        public event EventHandler FileClosed;

        private string _dataFilePath;
        private DateTime time;
        private ConfigData configData;
      //  public string ConfigFilePath { get; set; } = "C:\\Users\\iliya\\OneDrive\\Desktop\\конфиг.txt";

        //public Dictionary<string, double> ConfigData { get; set; } = new Dictionary<string, double>();

        /// <summary>
        /// Созать файл для записи данных из последовательного порта.
        /// </summary>
        /// <param name="check"></param>
        public void CreateDataFile(bool check)
        {
            if (check)
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss");
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string path = folderPath + "\\" + date + ".txt";
                try
                {
                    StreamWriter streamWriter = File.CreateText(path);
                    _dataFilePath = path;
                    time = DateTime.Now;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            } 
        }

        /// <summary>
        /// Проверка на существование файла.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>bool</returns>
        private bool IsFileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// Запись данных в файл
        /// </summary>
        /// <param name="writeState">флаг записи.</param>
        /// <param name="opperationCode">код команды.</param>
        /// <param name="playLoad">код данных.</param>
        /// <param name="crc">контрольная сумма.</param>
        public void WriteDataFile(bool writeState, UInt16 angleCode)
        {
            if (writeState && IsFileExist(_dataFilePath))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(_dataFilePath, true, System.Text.Encoding.Default))
                    {
                        time = time.AddMilliseconds(10.0);
                        string timestr = time.ToString("mm:ss:ff");
                        sw.WriteLine($"{timestr} {angleCode}");
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        /// <summary>
        /// Открывает файл настроек в блокноте.
        /// </summary>
        public void  OpenCurrentCofigFile()
        {
            if (IsFileExist(configData.ConfigFilePath))
            {
                configData = new ConfigData(configData.ConfigFilePath);
                using (Process openNotePad = new Process())
                {
                    openNotePad.StartInfo.FileName = configData.ConfigFilePath;
                    openNotePad.StartInfo.CreateNoWindow = true;
                    openNotePad.EnableRaisingEvents = true;
                    openNotePad.Exited += OpenNotePad_Exited;
                    openNotePad.Start();
                    openNotePad.WaitForExit();
                }
            }
            else
            {
                throw new Exception("Файл не найден");
            }
        }

        private void OpenNotePad_Exited(object sender, EventArgs e)
        {
            EventHandler handler = FileClosed;
            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Читает файл настроек. Заполняет словарь настроек.
        /// </summary>
        public void ReadCurrentConfigFile()
        {
            try
            {
                // Считаем количество строк
                int rows = 0;
                using (StreamReader sr = new StreamReader(configData.ConfigFilePath, Encoding.Default))
                {
                    while (sr.ReadLine() != null)
                    {
                        rows++;
                    }
                }
                using (StreamReader sr = new StreamReader(configData.ConfigFilePath, Encoding.Default))
                {
                    for(int i = 0; i < rows; i++)
                    {
                        var parsedLine = ParseString(sr.ReadLine());
                        configData.Config[parsedLine.Name] = parsedLine.Value;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public Dictionary<string, double> ShowCurrentConfig()
        {
            return configData.Config;
        }


        /// <summary>
        /// Разделяет строку черех '='.
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Tuple(string, double)</returns>
        private (String Name, double Value) ParseString(string line)
        {
            double value = 0;
            int position = line.IndexOf('=');
            if (position < 0)   //Если в строке не '='
                return (Name: "header", Value: 0);

            string name = line.Substring(0, position);
            Double.TryParse(line.Substring(position + 1), out value);
            return (Name: name, Value: value);
        }


        public void BinSerialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("config.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, configData);

            }
        }

        public void ReadBinFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs = new FileStream("config.dat", FileMode.OpenOrCreate))
            {
                configData = (ConfigData)formatter.Deserialize(fs);
            }
        }
        
        public void SetConfigFilePath(string path)
        {
            configData = new ConfigData(path);
            
        }

        public string GetFilePath()
        {
            return configData.ConfigFilePath;
        }

    }
}
