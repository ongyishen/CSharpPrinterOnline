using System;
using System.Data;
using System.Drawing.Printing;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CSharpPrinterOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsOnline
        {
            get
            {
                return lblOnline.Visible;
            }

            set
            {
                lblOnline.Visible = value;
                lblOffline.Visible = !lblOnline.Visible;
            }
        }

        public DataTable BuildPrinterDataTable()
        {
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add("PrinterName");
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                DataRow drNew = myDataTable.NewRow();
                drNew["PrinterName"] = printer;
                myDataTable.Rows.Add(drNew);
            }
            myDataTable.AcceptChanges();
            return myDataTable;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.PrinterName.DisplayMember = "PrinterName";
            this.PrinterName.ValueMember = "PrinterName";
            PrinterName.DataSource = BuildPrinterDataTable();
        }

        public bool IsPrinterConnected(string printerName)
        {
            PrinterSettings printerSetting = new PrinterSettings();
            bool flag = true;
            try
            {
                string str = "";
                printerSetting.PrinterName = printerName;
                if (!printerSetting.IsValid)
                {
                    return false;
                }
                int num = printerName.LastIndexOf("\\");
                if (num > 0)
                {
                    printerName = printerName.Substring(num + 1);
                }
                foreach (ManagementBaseObject managementBaseObject in (new ManagementObjectSearcher(string.Format("SELECT * FROM Win32_Printer WHERE Name='{0}'", printerName))).Get())
                {
                    flag = TextToBoolean(managementBaseObject["WorkOffline"]);
                    str = managementBaseObject["PortName"].ToString();
                    foreach (ManagementBaseObject managementBaseObject1 in (new ManagementObjectSearcher(string.Concat("SELECT * FROM Win32_TCPIPPrinterPort where Name LIKE '", str, "'"))).Get())
                    {
                        string str1 = managementBaseObject1["HostAddress"].ToString();
                        if (str1.Length <= 0)
                        {
                            continue;
                        }
                        PingReply pingReply = (new Ping()).Send(str1);
                        flag = (pingReply == null || pingReply.Status != IPStatus.Success ? true : false);
                    }
                }

            }
            catch (Exception ex)
            {

                //throw;
            }
            return !flag;
        }
        public bool TextToBoolean(object obj)
        {
            if ((obj == null) || (obj == DBNull.Value))
            {
                return false;
            }
            if (string.Compare(obj.ToString(), "T", true) != 0)
            {
                return (string.Compare(obj.ToString(), "True", true) == 0);
            }
            return true;
        }


        private void btnCheck_Click(object sender, System.EventArgs e)
        {
            btnCheck.Enabled = false;
            Application.DoEvents();
            IsOnline = IsPrinterConnected(PrinterName.Text);
            btnCheck.Enabled = true;
            Application.DoEvents();
        }
    }
}
