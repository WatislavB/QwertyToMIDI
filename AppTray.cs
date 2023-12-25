using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NAudio.Midi;
using QwertyToMIDI;

namespace QwertyToMIDI
{
    public class AppTray : ApplicationContext
    {
        public int MidiDevice = -1;

        public string settings_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\QwertyToMIDI";
        public string keys_settings_fileName = "\\KeysSettings.xml";

        public globalKeyboardHook gkh = new globalKeyboardHook();

        public List<settings> SettingsLists = new List<settings>();

        private NotifyIcon trayIcon;

        public AppTray()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.RIcon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items = { new ToolStripMenuItem("Settings", null, SettingsShow), new ToolStripMenuItem("Exit", null, Exit) }
                },
                Visible = true
            };

            trayIcon.DoubleClick += new EventHandler(SettingsShow);

            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);

            LoadFile();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (MidiDevice > -1)
            {
                for (int i = 0; i < SettingsLists.Count; i++)
                {
                    if ((SettingsLists[i].key == e.KeyCode) && (SettingsLists[i].key_status == "Key Down"))
                    {
                        MidiOut midiOut = new MidiOut(MidiDevice);
                        midiOut.Send(MidiMessage.ChangeControl(SettingsLists[i].midi1, SettingsLists[i].midi2, SettingsLists[i].midi3).RawData);
                        midiOut.Close();

                        Debug.WriteLine(SettingsLists[i].key);
                    }
                }
            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (MidiDevice > -1)
            {
                for (int i = 0; i < SettingsLists.Count; i++)
                {
                    if ((SettingsLists[i].key == e.KeyCode) && (SettingsLists[i].key_status == "Key Up"))
                    {
                        MidiOut midiOut = new MidiOut(MidiDevice);
                        midiOut.Send(MidiMessage.ChangeControl(SettingsLists[i].midi1, SettingsLists[i].midi2, SettingsLists[i].midi3).RawData);
                        midiOut.Close();

                        Debug.WriteLine(SettingsLists[i].key);
                    }
                }
            }
        }

        void Exit(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        void SettingsShow(object? sender, EventArgs e)
        {
            SettingsForm settings_f = new SettingsForm(this);
            settings_f.Show();
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
                    gkh.HookedKeys.Add(SettingsLists[i].key);
                }
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
