using NAudio.Midi;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QwertyToMIDI
{
    public partial class GridView : Form
    {
        private AppTray parent;

        Keys lastKey = Keys.None;
        int editIndex = -1;

        public GridView(AppTray at)
        {
            InitializeComponent();

            parent = at;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            comboBox_Key_status.SelectedIndex = 0;

            LoadDevices();
            LoadGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Key.Text != "")
            {
                if (editIndex > -1)
                {
                    dataGridView_Keys.Rows[editIndex].Cells[0].Value = textBox_Key.Text;
                    dataGridView_Keys.Rows[editIndex].Cells[1].Value = comboBox_Key_status.Text;
                    dataGridView_Keys.Rows[editIndex].Cells[2].Value = numericUpDown_MIDI1.Value;
                    dataGridView_Keys.Rows[editIndex].Cells[3].Value = numericUpDown_MIDI2.Value;
                    dataGridView_Keys.Rows[editIndex].Cells[4].Value = numericUpDown_MIDI3.Value;

                    parent.gkh.HookedKeys.Remove(parent.SettingsValues.SettingsKeys[editIndex].key);
                    parent.gkh.HookedKeys.Add(lastKey);

                    parent.SettingsValues.SettingsKeys[editIndex].key = lastKey;
                    parent.SettingsValues.SettingsKeys[editIndex].key_status = comboBox_Key_status.Text;
                    parent.SettingsValues.SettingsKeys[editIndex].midi1 = (int)numericUpDown_MIDI1.Value;
                    parent.SettingsValues.SettingsKeys[editIndex].midi2 = (int)numericUpDown_MIDI2.Value;
                    parent.SettingsValues.SettingsKeys[editIndex].midi3 = (int)numericUpDown_MIDI3.Value;

                    EditingToggle();
                }
                else
                {
                    dataGridView_Keys.Rows.Add(lastKey, comboBox_Key_status.Text, (int)numericUpDown_MIDI1.Value, (int)numericUpDown_MIDI2.Value, (int)numericUpDown_MIDI3.Value);

                    parent.gkh.HookedKeys.Add(lastKey);

                    parent.SettingsValues.SettingsKeys.Add(new settings_keys()
                    {
                        key = lastKey,
                        key_status = comboBox_Key_status.Text,
                        midi1 = (int)numericUpDown_MIDI1.Value,
                        midi2 = (int)numericUpDown_MIDI2.Value,
                        midi3 = (int)numericUpDown_MIDI3.Value
                    });
                }

                ClearBoxes();
                SaveFile();
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (editIndex > -1)
            {
                EditingToggle();
                ClearBoxes();
            }
            else
            {
                EditingToggle();

                if (dataGridView_Keys.Rows.Count > 0)
                {
                    if (dataGridView_Keys.SelectedRows.Count > 0)
                    {
                        textBox_Key.Text = parent.SettingsValues.SettingsKeys[editIndex].key.ToString();
                        if (parent.SettingsValues.SettingsKeys[editIndex].key_status == "Key Down") { comboBox_Key_status.SelectedIndex = 0; } else { comboBox_Key_status.SelectedIndex = 1; }
                        numericUpDown_MIDI1.Value = parent.SettingsValues.SettingsKeys[editIndex].midi1;
                        numericUpDown_MIDI2.Value = parent.SettingsValues.SettingsKeys[editIndex].midi2;
                        numericUpDown_MIDI3.Value = parent.SettingsValues.SettingsKeys[editIndex].midi3;

                        lastKey = parent.SettingsValues.SettingsKeys[editIndex].key;
                    }
                }
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_Keys.Rows.Count > 0)
            {
                if (dataGridView_Keys.SelectedRows.Count > 0)
                {
                    parent.SettingsValues.SettingsKeys.RemoveAt(dataGridView_Keys.SelectedRows[0].Index);
                    parent.gkh.HookedKeys.RemoveAt(dataGridView_Keys.SelectedRows[0].Index);
                    dataGridView_Keys.Rows.RemoveAt(dataGridView_Keys.SelectedRows[0].Index);

                    SaveFile();
                }
            }
        }

        private void textBox_Key_KeyUp(object sender, KeyEventArgs e)
        {
            textBox_Key.Text = e.KeyCode.ToString();

            lastKey = e.KeyCode;
        }

        private void comboBox_Device_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            parent.MidiDevice = comboBox_Device_List.SelectedIndex;

            parent.SettingsValues.MidiDeviceName = MidiOut.DeviceInfo(comboBox_Device_List.SelectedIndex).ProductName;

            SaveFile();
        }

        private void button_Refresh_Devices_Click(object sender, EventArgs e)
        {
            LoadDevices();
        }

        public void ClearBoxes()
        {
            lastKey = Keys.None;

            textBox_Key.Text = "";
            comboBox_Key_status.SelectedIndex = 0;
            numericUpDown_MIDI1.Value = 0;
            numericUpDown_MIDI2.Value = 0;
            numericUpDown_MIDI3.Value = 1;

            textBox_Key.Focus();
        }

        public void EditingToggle()
        {
            if (editIndex > -1)
            {
                button_Add.Text = "Add";
                button_Edit.Text = "Edit";
                button_Remove.Enabled = true;
                editIndex = -1;
            }
            else
            {
                button_Add.Text = "Save";
                button_Edit.Text = "Cancel";
                button_Remove.Enabled = false;
                editIndex = dataGridView_Keys.SelectedRows[0].Index;
            }
        }

        private void LoadGrid()
        {
            if (parent.SettingsValues.SettingsKeys != null)
            {
                for (int i = 0; i < parent.SettingsValues.SettingsKeys.Count; i++)
                {
                    dataGridView_Keys.Rows.Add(parent.SettingsValues.SettingsKeys[i].key, parent.SettingsValues.SettingsKeys[i].key_status, parent.SettingsValues.SettingsKeys[i].midi1, parent.SettingsValues.SettingsKeys[i].midi2, parent.SettingsValues.SettingsKeys[i].midi3);
                }
            }
        }

        private void SaveFile()
        {
            if (!Directory.Exists(parent.settings_path))
            {
                Directory.CreateDirectory(parent.settings_path);
            }

            string path = parent.settings_path + parent.keys_settings_fileName;

            Stream stream = File.Open(path, FileMode.Create);

            XmlSerializer serialiser = new XmlSerializer(typeof(settings));
            serialiser.Serialize(stream, parent.SettingsValues);
            stream.Close();
        }

        private void LoadDevices()
        {
            comboBox_Device_List.Items.Clear();

            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                Debug.WriteLine(MidiOut.DeviceInfo(device).ProductName);

                comboBox_Device_List.Items.Add(MidiOut.DeviceInfo(device).ProductName);
            }

            if (comboBox_Device_List.Items.Count >= parent.MidiDevice)
            {
                comboBox_Device_List.SelectedIndex = parent.MidiDevice;
            }
        }
    }
}