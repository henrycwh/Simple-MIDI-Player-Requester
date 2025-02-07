using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using NAudio.Wave;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace midi_palyer_simple_edition
{
    internal class AI_Midi_Receptor : Form1
    {
        private string head_path = AppDomain.CurrentDomain.BaseDirectory;
        private string data_folder_name = "midi_data";
        private string data_folder_path;
        private string exception_file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exception_log.txt");
        private string download_url;
        private int data_folder_count;
        private int index_p = 0, index_d = 0;
        private DateTime currentTime;

        public AI_Midi_Receptor()
        {
            LoadConfig(); // 載入設定檔

            data_folder_path = Path.Combine(head_path, data_folder_name);
            Directory.CreateDirectory(data_folder_path);

        }

        void download_new_file()
        {
            using (WebClient c = new WebClient())
            {
                try
                {
                    // 在這裡執行與 WebClient 相關的工作
                    // 不需要手動呼叫 Dispose 方法，它將在 using 區塊結束時自動呼叫
                    string file = (index_d++) + ".wav";
                    Console.WriteLine("Downloading... " + file);
                    if (File.Exists(file)) File.Delete(file);
                    c.DownloadFile(download_url, data_folder_path);
                }
                catch (Exception e)
                {
                    // 使用 StreamWriter 開啟檔案，如果不存在則建立檔案，並設定編碼為 UTF-8
                    using (StreamWriter writer = new StreamWriter(exception_file_path, true, System.Text.Encoding.UTF8))
                    {
                        currentTime = DateTime.Now;
                        // 寫入文字至檔案
                        writer.WriteLine("Time: " + currentTime + "  error: " + e.Message);
                    }

                }
            }
        }

        public void Start_Download()
        {
            new Thread(() => {
                while (true)
                {
                    data_folder_count = Directory.GetFiles(data_folder_path).Length;
                    if (data_folder_count < 30)
                    {
                        download_new_file();
                    }
                    Thread.Sleep(5000);
                }
            }).Start();
        }

        public void Play_Music()
        {
            new Thread(() => {
                string p_file_path = data_folder_path + "\\" + (index_p++) + ".wav";

                while (true)
                {
                    if (File.Exists(p_file_path))
                    {
                        PlayWav(p_file_path);
                        File.Delete(p_file_path);

                        p_file_path = data_folder_path + "\\" + (index_p++) + ".wav";

                    }
                    else
                    {
                        // 使用 StreamWriter 開啟檔案，如果不存在則建立檔案，並設定編碼為 UTF-8
                        using (StreamWriter writer = new StreamWriter(exception_file_path, true, System.Text.Encoding.UTF8))
                        {
                            currentTime = DateTime.Now;
                            // 寫入文字至檔案
                            writer.WriteLine("Time: " + currentTime + "  error: " + "File does not exist.");

                        }
                    }
                }

            }).Start();
        }
        private static void PlayWav(string wavFilePath)
        {
            try
            {
                using (var audioFile = new AudioFileReader(wavFilePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        // Optionally, you can add code here to do other tasks while the audio plays.
                    }
                }
            }
            catch (Exception e)
            {
                string exception_file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exception_log.txt");
                // 使用 StreamWriter 開啟檔案，如果不存在則建立檔案，並設定編碼為 UTF-8
                using (StreamWriter writer = new StreamWriter(exception_file_path, true, System.Text.Encoding.UTF8))
                {
                    DateTime currentTime = DateTime.Now;
                    // 寫入文字至檔案
                    writer.WriteLine("Time: " + currentTime + "  error: " + e.Message);
                }
            }
        }

        private void LoadConfig()
        {
            try
            {

                string configFilePath = Path.Combine(head_path, "config.json");

                if (!File.Exists(configFilePath))
                {
                    throw new FileNotFoundException("設定檔未找到: " + configFilePath);
                }

                string json = File.ReadAllText(configFilePath);
                var config = JsonSerializer.Deserialize<Config>(json);

                if (config == null) throw new Exception("設定檔內容無法解析");

                download_url = config.download_url;
            }
            catch (Exception e)
            {
                Console.WriteLine("載入設定檔時發生錯誤: " + e.Message);
                throw;
            }
        }

        // 定義設定檔的類別 (對應 JSON 結構)
        public class Config
        {
            public string head_path { get; set; }
            public string exception_file_path { get; set; }
            public string download_url { get; set; }
        }

    }
}

