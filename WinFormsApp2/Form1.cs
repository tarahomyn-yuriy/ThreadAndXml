
using System.Diagnostics;
using System.Threading;
using System.Xml;
using System.IO;
using System.Xml.XPath;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        CancellationTokenSource CancellationTokenThread { get; set; }
        Thread thread { get; set; }

        private void buttonDownloadExCurr_Click(object sender, EventArgs e)
        {
            CancellationTokenThread = new CancellationTokenSource();
            thread = new Thread(new ThreadStart(DownloadExCurr));
            thread.Start();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancellationTokenThread.Cancel();
        }

        void DownloadExCurr()
        {
            bool isOK = false;

            ApendLine("Завантаження ХМЛ файлу з курсами валют з офційного сайту: bank.gov.ua");
            ApendLine(" --> https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");

            XPathDocument xPathDoc;
            XPathNavigator? xPathDocNavigator = null;

            try
            {
                xPathDoc = new XPathDocument("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");
                xPathDocNavigator = xPathDoc.CreateNavigator();

                isOK = true;
                ApendLine("OK\n");
            }
            catch (Exception ex)
            {
                ApendLine("Помилка завантаження або аналізу ХМЛ файлу: " + ex.Message);
            }

            if (isOK)
            {
                XPathNodeIterator? КурсВалюти = xPathDocNavigator?.Select("/exchange/currency");
                while (КурсВалюти!.MoveNext())
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    XPathNavigator? current = КурсВалюти.Current;

                    string Код_R030 = int.Parse(current?.SelectSingleNode("r030")?.Value ?? "0").ToString("D3");
                    string НазваВалюти = current?.SelectSingleNode("txt")?.Value ?? "";
                    string Коротко = current?.SelectSingleNode("cc")?.Value ?? "";
                    decimal Курс = decimal.Parse(current?.SelectSingleNode("rate")?.Value.Replace(".", ",") ?? "0");
                    DateTime ДатаКурсу = DateTime.Parse(current?.SelectSingleNode("exchangedate")?.Value ?? DateTime.MinValue.ToString());

                    ApendLine($"Код {Код_R030}, назва валюти {НазваВалюти}, коротка назва {Коротко}, курс {Курс}, дата курсу {ДатаКурсу}");
                }
            }

            if (!this.Disposing)
            {
                buttonDownloadExCurr.Invoke(new Action(() => buttonDownloadExCurr.Enabled = true));
                buttonCancel.Invoke(new Action(() => buttonCancel.Enabled = false));
            }
        }

        private void ApendLine(string head)
        {
            if (richTextBoxInfo.InvokeRequired)
            {
                richTextBoxInfo.Invoke(new Action<string>(ApendLine), head);
            }
            else
            {
                richTextBoxInfo.AppendText("\n" + head);
            }
        }

    }
}