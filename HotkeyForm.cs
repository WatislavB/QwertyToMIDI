using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwertyToMIDI
{
    public class HotkeyForm : Form
    {
        public event EventHandler<HotkeyEventArgs> HotkeyPressed;

        public HotkeyForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lhk = new Label();
            SuspendLayout();
            // 
            // lhk
            // 
            lhk.Dock = DockStyle.Fill;
            lhk.Location = new Point(0, 0);
            lhk.Name = "lhk";
            lhk.Size = new Size(234, 61);
            lhk.TabIndex = 0;
            lhk.Text = "Press the key...";
            lhk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HotkeyForm
            // 
            ClientSize = new Size(234, 61);
            Controls.Add(lhk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HotkeyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Choose Hotkey";
            KeyDown += HotkeyForm_KeyDown;
            ResumeLayout(false);
        }

        private void HotkeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Вызов события при нажатии клавиши
            HotkeyPressed?.Invoke(this, new HotkeyEventArgs { SelectedHotkey = e.KeyCode });

            Close();
        }

        private Label lhk;
    }

    public class HotkeyEventArgs : EventArgs
    {
        public Keys SelectedHotkey { get; set; }
    }
}
