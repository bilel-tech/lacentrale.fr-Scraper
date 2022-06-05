using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using lacentrale.fr_Scraper.Models;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace lacentrale.fr_Scraper
{
    public partial class MainForm : MetroForm
    {
        public bool LogToUi = true;
        public bool LogToFile = true;

        private readonly string _path = Application.StartupPath;
        private int _maxConcurrency;
        private Dictionary<string, string> _config;
        public HttpCaller HttpCaller = new HttpCaller();
        public MainForm()
        {
            InitializeComponent();
        }


        private async Task MainWork()
        {
            await Task.Delay(3000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicePointManager.DefaultConnectionLimit = 65000;
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            inputI.Text = _path + @"\input.txt";
            outputI.Text = _path + @"\output.csv";
            LoadConfig();
        }

        void InitControls(Control parent)
        {
            try
            {
                foreach (Control x in parent.Controls)
                {
                    try
                    {
                        if (x.Name.EndsWith("I"))
                        {
                            switch (x)
                            {
                                case MetroCheckBox _:
                                case CheckBox _:
                                    ((CheckBox)x).Checked = bool.Parse(_config[((CheckBox)x).Name]);
                                    break;
                                case RadioButton radioButton:
                                    radioButton.Checked = bool.Parse(_config[radioButton.Name]);
                                    break;
                                case TextBox _:
                                case RichTextBox _:
                                case MetroTextBox _:
                                    x.Text = _config[x.Name];
                                    break;
                                case NumericUpDown numericUpDown:
                                    numericUpDown.Value = int.Parse(_config[numericUpDown.Name]);
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    InitControls(x);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void SaveControls(Control parent)
        {
            try
            {
                foreach (Control x in parent.Controls)
                {
                    #region Add key value to disctionarry

                    if (x.Name.EndsWith("I"))
                    {
                        switch (x)
                        {
                            case MetroCheckBox _:
                            case RadioButton _:
                            case CheckBox _:
                                _config.Add(x.Name, ((CheckBox)x).Checked + "");
                                break;
                            case TextBox _:
                            case RichTextBox _:
                            case MetroTextBox _:
                                _config.Add(x.Name, x.Text);
                                break;
                            case NumericUpDown _:
                                _config.Add(x.Name, ((NumericUpDown)x).Value + "");
                                break;
                            default:
                                Console.WriteLine(@"could not find a type for " + x.Name);
                                break;
                        }
                    }
                    #endregion
                    SaveControls(x);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void SaveConfig()
        {
            _config = new Dictionary<string, string>();
            SaveControls(this);
            try
            {
                File.WriteAllText("config.txt", JsonConvert.SerializeObject(_config, Formatting.Indented));
            }
            catch (Exception e)
            {
                ErrorLog(e.ToString());
            }
        }
        private void LoadConfig()
        {
            try
            {
                _config = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("config.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
            InitControls(this);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), @"Unhandled Thread Exception");
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception)?.ToString(), @"Unhandled UI Exception");
        }
        #region UIFunctions
        public delegate void WriteToLogD(string s, Color c);
        public void WriteToLog(string s, Color c)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new WriteToLogD(WriteToLog), s, c);
                    return;
                }
                if (LogToUi)
                {
                    if (DebugT.Lines.Length > 5000)
                    {
                        DebugT.Text = "";
                    }
                    DebugT.SelectionStart = DebugT.Text.Length;
                    DebugT.SelectionColor = c;
                    DebugT.AppendText(DateTime.Now.ToString(Utility.SimpleDateFormat) + " : " + s + Environment.NewLine);
                }
                Console.WriteLine(DateTime.Now.ToString(Utility.SimpleDateFormat) + @" : " + s);
                if (LogToFile)
                {
                    File.AppendAllText(_path + "/data/log.txt", DateTime.Now.ToString(Utility.SimpleDateFormat) + @" : " + s + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void NormalLog(string s)
        {
            WriteToLog(s, Color.Black);
        }
        public void ErrorLog(string s)
        {
            WriteToLog(s, Color.Red);
        }
        public void SuccessLog(string s)
        {
            WriteToLog(s, Color.Green);
        }
        public void CommandLog(string s)
        {
            WriteToLog(s, Color.Blue);
        }

        public delegate void SetProgressD(int x);
        public void SetProgress(int x)
        {
            if (InvokeRequired)
            {
                Invoke(new SetProgressD(SetProgress), x);
                return;
            }
            if ((x <= 100))
            {
                ProgressB.Value = x;
            }
        }
        public delegate void DisplayD(string s);
        public void Display(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new DisplayD(Display), s);
                return;
            }
            displayT.Text = s;
        }

        #endregion
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
        private void loadInputB_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog { Filter = @"TXT|*.txt", InitialDirectory = _path };
            if (o.ShowDialog() == DialogResult.OK)
            {
                inputI.Text = o.FileName;
            }
        }
        private void openInputB_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(inputI.Text);
            }
            catch (Exception ex)
            {
                ErrorLog(ex.ToString());
            }
        }
        private void openOutputB_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(outputI.Text);
            }
            catch (Exception ex)
            {
                ErrorLog(ex.ToString());
            }
        }
        private void loadOutputB_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"csv file|*.csv",
                Title = @"Select the output location"
            };
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                outputI.Text = saveFileDialog1.FileName;
            }
        }

        private async void startB_Click_1(object sender, EventArgs e)
        {
            var doc = await HttpCaller.GetDoc("https://www.lacentrale.fr/listing?reclaimVAT=true&customerFamilyCodes=CONCESSIONNAIRE&energies=elec&mileageMax=50000&priceMax=29000&reclaimVAT=true&yearMax=2021&yearMin=2018");
            var json = doc.DocumentNode
                .SelectSingleNode("//script[contains(text(),'window.__PRELOADED_STATE_LISTING__')]").InnerText;

            #region Get makes and their models
            //var doc = await HttpCaller.GetDoc("https://www.lacentrale.fr/");
            //doc.Save("test.html");
            //var json = doc.DocumentNode.SelectSingleNode("//script[contains(text(),'window.__PRELOADED_STATE_LISTING')]")?.InnerText.Trim(); 
            #endregion
            #region Get Url cars for each page
            //var doc = await HttpCaller.GetDoc("https://www.lacentrale.fr/listing?energies=dies&makesModelsCommercialNames=RENAULT%3ACAPTUR&mileageMax=50000&options=&page=2&priceMax=29000&yearMax=2021&yearMin=2018");
            //var carsNodes = doc.DocumentNode.SelectNodes("//div[@class='resultList mB15 hiddenOverflow listing ']//a[@class='searchCard__link ']");
            //foreach (var carNode in carsNodes)
            //{
            //    Console.WriteLine(carNode.GetAttributeValue("href", ""));
            //} 
            #endregion

            //var doc = await HttpCaller.GetDoc("https://www.lacentrale.fr/auto-occasion-annonce-69108178598.html");
            ////doc.Save("car.html");
            //var jsonPhoneVaribalesQuery = doc.DocumentNode
            //    .SelectSingleNode("//script[contains(text(),'window.fragment_seller_contact_tabs_state')]").InnerText
            //    .Trim().Replace("window.fragment_seller_contact_tabs_state = ", "").Replace(";","");

            //var objt = JObject.Parse(jsonPhoneVaribalesQuery);
            //var price = string.Format(CultureInfo.InvariantCulture, "€{0:n0}", (int)objt.SelectToken("price"));
            //var id = (string) objt.SelectToken("classifiedId");
            //var cuRef = (string) objt.SelectToken("classifiedOwnerCorrelationId");
            //var eci = (string) objt.SelectToken("eventCorrelationId");
            //var url = $@"https://www.lacentrale.fr/seller-contact-tab?tab=PHONE&id={id}&cuRef={cuRef}&eci={eci}";
            //doc = await HttpCaller.GetDoc(url);
            //Console.WriteLine(doc.DocumentNode.OuterHtml);
            return;
            await MainWork();
        }
    }
}
