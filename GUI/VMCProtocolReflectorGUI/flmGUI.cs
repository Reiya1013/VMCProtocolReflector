using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VMCProtocolReflectorGUI
{
    public partial class frmGUI : Form
    {
        const string filename = "setting.txt";

        public frmGUI()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            string[] settings = File.ReadAllLines(filename);

            nudReceivePort.Value = int.Parse(settings[0]);

            for (int i = 1; i < settings.Length; i++)
            {
                string[] host = settings[i].Split(':');
                if (host.Length == 2)
                {
                    SetSendPort(int.Parse(host[1]));
                }
            }
        }

        int SetObjNo = 1;
        private void SetSendPort(int port)
        {
            Control[] cs = this.Controls.Find("nudSendPort" + SetObjNo.ToString().PadLeft(2,'0'), true);
            if (cs.Length > 0)
            {
                ((NumericUpDown)cs[0]).Value = port;
                ((NumericUpDown)cs[0]).Visible = true;
            }
            SetObjNo += 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nudName = ((Button)sender).Name;

            Control[] cs = this.Controls.Find("nudSendPort" + nudName.Substring(nudName.Length -2,2), true);
            if (cs.Length > 0)
                ((NumericUpDown)cs[0]).Visible = true;
        }

        private void nudSendPort_DoubleClick(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Visible = false;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ArrayList sendPorts = new ArrayList();
            if (SendDataGet(nudSendPort01) != null) { sendPorts.Add(SendDataGet(nudSendPort01)); }
            if (SendDataGet(nudSendPort02) != null) { sendPorts.Add(SendDataGet(nudSendPort02)); }
            if (SendDataGet(nudSendPort03) != null) { sendPorts.Add(SendDataGet(nudSendPort03)); }
            if (SendDataGet(nudSendPort04) != null) { sendPorts.Add(SendDataGet(nudSendPort04)); }
            if (SendDataGet(nudSendPort05) != null) { sendPorts.Add(SendDataGet(nudSendPort05)); }
            if (SendDataGet(nudSendPort06) != null) { sendPorts.Add(SendDataGet(nudSendPort06)); }
            if (SendDataGet(nudSendPort07) != null) { sendPorts.Add(SendDataGet(nudSendPort07)); }
            if (SendDataGet(nudSendPort08) != null) { sendPorts.Add(SendDataGet(nudSendPort08)); }
            if (SendDataGet(nudSendPort09) != null) { sendPorts.Add(SendDataGet(nudSendPort09)); }
            if (SendDataGet(nudSendPort10) != null) { sendPorts.Add(SendDataGet(nudSendPort10)); }

            if (sendPorts.Count < 2)
            {
                MessageBox.Show("送信ポートが2個以下しか設定されていません。", "設定エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                for (int i = 0; i < sendPorts.Count-1; i++)
                {
                    for (int j = i+1; j < sendPorts.Count; j++)
                    {
                        if ((string)sendPorts[i] == (string)sendPorts[j])
                        {
                            MessageBox.Show("送信ポートが重複しています。", "設定エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                File.WriteAllText("setting.txt", nudReceivePort.Value.ToString() + "\r\n");

                for (int i = 0; i < sendPorts.Count; i++)
                    File.AppendAllText("setting.txt", sendPorts[i].ToString() + "\r\n");

                MessageBox.Show("設定完了。", "設定完了", MessageBoxButtons.OK);
            }

        }

        private string SendDataGet(NumericUpDown nudSendPortObj)
        {
            if (!nudSendPortObj.Visible)
                return null;
            else
                return "127.0.0.1:" + nudSendPortObj.Value;
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcessesByName("VMCProtocolReflector");

            foreach (System.Diagnostics.Process p in ps)
            {
                try
                {
                    //プロセスを強制的に終了させる
                    p.Kill();
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }


            Process.Start("VMCProtocolReflector.exe");

        }
    }
}
