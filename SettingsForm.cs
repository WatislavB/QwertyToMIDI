using Microsoft.VisualBasic.ApplicationServices;
using NAudio.CoreAudioApi;
using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QwertyToMIDI
{
    public partial class SettingsForm : Form
    {
        string settings_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\QwertyToMIDI";
        string keys_settings_fileName = "\\KeysSettings.xml";

        globalKeyboardHook gkh = new globalKeyboardHook();

        Keys lastKey = Keys.None;
        int editIndex = -1;

        List<settings> SettingsLists = new List<settings>();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);

            comboBox_Key_status.SelectedIndex = 0;

            LoadFile();
            LoadDevices();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox_Device_List.Text != "")
            {
                for (int i = 0; i < SettingsLists.Count; i++)
                {
                    if ((SettingsLists[i].key == e.KeyCode) && (SettingsLists[i].key_status == "Key Down"))
                    {
                        MidiOut midiOut = new MidiOut(comboBox_Device_List.SelectedIndex);
                        midiOut.Send(MidiMessage.ChangeControl(SettingsLists[i].midi1, SettingsLists[i].midi2, SettingsLists[i].midi3).RawData);
                        midiOut.Close();

                        Debug.WriteLine(SettingsLists[i].key);
                    }
                }
            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox_Device_List.Text != "")
            {
                for (int i = 0; i < SettingsLists.Count; i++)
                {
                    if ((SettingsLists[i].key == e.KeyCode) && (SettingsLists[i].key_status == "Key Up"))
                    {
                        MidiOut midiOut = new MidiOut(comboBox_Device_List.SelectedIndex);
                        midiOut.Send(MidiMessage.ChangeControl(SettingsLists[i].midi1, SettingsLists[i].midi2, SettingsLists[i].midi3).RawData);
                        midiOut.Close();

                        Debug.WriteLine(SettingsLists[i].key);
                    }
                }
            }
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

                    gkh.HookedKeys.Remove(SettingsLists[editIndex].key);
                    gkh.HookedKeys.Add(lastKey);

                    SettingsLists[editIndex].key = lastKey;
                    SettingsLists[editIndex].key_status = comboBox_Key_status.Text;
                    SettingsLists[editIndex].midi1 = (int)numericUpDown_MIDI1.Value;
                    SettingsLists[editIndex].midi2 = (int)numericUpDown_MIDI2.Value;
                    SettingsLists[editIndex].midi3 = (int)numericUpDown_MIDI3.Value;

                    EditingToggle();
                }
                else
                {
                    dataGridView_Keys.Rows.Add(textBox_Key.Text, comboBox_Key_status.Text, numericUpDown_MIDI1.Value, numericUpDown_MIDI2.Value, numericUpDown_MIDI3.Value);

                    gkh.HookedKeys.Add(lastKey);

                    SettingsLists.Add(new settings()
                    {
                        key = lastKey,
                        key_status = comboBox_Key_status.Text,
                        midi1 = (int)numericUpDown_MIDI1.Value,
                        midi2 = (int)numericUpDown_MIDI2.Value,
                        midi3 = (int)numericUpDown_MIDI3.Value
                    });
                }

                ClearBoxes();
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
                    if (dataGridView_Keys.SelectedCells.Count > 0)
                    {
                        textBox_Key.Text = SettingsLists[editIndex].key.ToString();
                        if (SettingsLists[editIndex].key_status == "Key Down") { comboBox_Key_status.SelectedIndex = 0; } else { comboBox_Key_status.SelectedIndex = 1; }
                        numericUpDown_MIDI1.Value = SettingsLists[editIndex].midi1;
                        numericUpDown_MIDI2.Value = SettingsLists[editIndex].midi2;
                        numericUpDown_MIDI3.Value = SettingsLists[editIndex].midi3;

                        lastKey = SettingsLists[editIndex].key;
                    }
                }
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_Keys.Rows.Count > 0)
            {
                if (dataGridView_Keys.SelectedCells.Count > 0)
                {
                    SettingsLists.RemoveAt(dataGridView_Keys.SelectedCells[0].RowIndex);
                    gkh.HookedKeys.RemoveAt(dataGridView_Keys.SelectedCells[0].RowIndex);
                    dataGridView_Keys.Rows.RemoveAt(dataGridView_Keys.SelectedCells[0].RowIndex);
                }
            }
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
                editIndex = dataGridView_Keys.SelectedCells[0].RowIndex;
            }
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

        private void textBox_Key_KeyUp(object sender, KeyEventArgs e)
        {
            textBox_Key.Text = e.KeyCode.ToString();

            lastKey = e.KeyCode;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
            SaveFile();
        }

        private void notifyIcon_MIDIController_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void toolStripMenuItem_Show_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            notifyIcon_MIDIController.Visible = false;
            notifyIcon_MIDIController.Dispose();

            Application.Exit();
        }

        private void button_Refresh_Devices_Click(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void SaveFile()
        {
            if (!Directory.Exists(settings_path))
            {
                Directory.CreateDirectory(settings_path);
            }

            string path = settings_path + keys_settings_fileName;

            Stream stream = File.OpenWrite(path);

            XmlSerializer serialiser = new XmlSerializer(typeof(List<settings>));
            serialiser.Serialize(stream, SettingsLists);
            stream.Close();
        }

        private void LoadFile()
        {
            string path = settings_path + keys_settings_fileName;

            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<settings>));

                StreamReader reader = new StreamReader(path);
                SettingsLists = serializer.Deserialize(reader) as List<settings>;
                reader.Close();

                for (int i = 0; i < SettingsLists.Count; i++)
                {
                    dataGridView_Keys.Rows.Add(SettingsLists[i].key, SettingsLists[i].key_status, SettingsLists[i].midi1, SettingsLists[i].midi2, SettingsLists[i].midi3);

                    gkh.HookedKeys.Add(SettingsLists[i].key);
                }

                gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            }
        }

        private void LoadDevices()
        {
            comboBox_Device_List.Items.Clear();

            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                Debug.WriteLine(MidiOut.DeviceInfo(device).ProductName);

                comboBox_Device_List.Items.Add(MidiOut.DeviceInfo(device).ProductName);
            }
        }
    }

    public class settings
    {
        public Keys key { get; set; }
        public string? key_status { get; set; }
        public int midi1 { get; set; }
        public int midi2 { get; set; }
        public int midi3 { get; set; }
    }
}