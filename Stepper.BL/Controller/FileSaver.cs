using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Stepper.BL.Controller
{
    /// <summary>
    /// Запись данных в файл.
    /// </summary>
    public class FileSaver
    {
        private string _dataFilePath;

        /// <summary>
        /// Созать файл для записи данных из последовательного порта.
        /// </summary>
        /// <param name="check"></param>
        public void CreateDataFile(bool check)
        {
            if (check)
            {
                _writeDataFileState = true;
                string date = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss");
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string path = folderPath + "\\" + date + ".txt";
                try
                {
                    StreamWriter streamWriter = File.CreateText(path);
                    _dataFilePath = path;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                _writeDataFileState = false;
            }
        }

        /// <summary>
        /// Проверка на существование файла.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>bool</returns>
        private bool IsFileExist()
        {
            return File.Exists(_dataFilePath);
        }

        /// <summary>
        /// Запись данных в файл
        /// </summary>
        /// <param name="writeState">флаг записи.</param>
        /// <param name="opperationCode">код команды.</param>
        /// <param name="playLoad">код данных.</param>
        /// <param name="crc">контрольная сумма.</param>
        public void WriteDataFile(bool writeState, byte opperationCode, UInt16 playLoad, byte crc)
        {
            if (writeState && IsFileExist())
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(_dataFilePath, true, System.Text.Encoding.Default))
                    {
                        string time = DateTime.Now.ToString("mm:ss:fff");
                        sw.WriteLine($"{time} {opperationCode} {playLoad} {crc} ");
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

    }
}
