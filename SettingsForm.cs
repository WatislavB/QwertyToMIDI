using Microsoft.Win32;

namespace QwertyToMIDI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RegistryKey winLogonKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            checkBox_Startup.Checked = winLogonKey.GetValueNames().Contains(Application.ProductName);
        }

        private void checkBox_Startup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (checkBox_Startup.Checked)
                rk.SetValue(Application.ProductName, Application.ExecutablePath);
            else
                rk.DeleteValue(Application.ProductName, false);
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
