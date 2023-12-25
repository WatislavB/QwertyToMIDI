using NAudio.Midi;
using System.Diagnostics;
using System.Xml.Serialization;

namespace QwertyToMIDI
{
    public class AppTray : ApplicationContext
    {
        public int MidiDevice = -1;

        public string settings_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\QwertyToMIDI";
        public string keys_settings_fileName = "\\KeysSettings.xml";

        public globalKeyboardHook gkh = new globalKeyboardHook();

        public settings SettingsValues = new settings();

        private NotifyIcon trayIcon;

        public AppTray()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.RIcon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items = { new ToolStripMenuItem("Grid View", null, GridViewShow), new ToolStripMenuItem("Settings", null, SettingsShow), new ToolStripMenuItem("Exit", null, Exit) }
                },
                Visible = true
            };

            trayIcon.DoubleClick += new EventHandler(GridViewShow);

            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);

            LoadFile();
            LoadDevices();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (MidiDevice > -1)
            {
                for (int i = 0; i < SettingsValues.SettingsKeys.Count; i++)
                {
                    if ((SettingsValues.SettingsKeys[i].key == e.KeyCode) && (SettingsValues.SettingsKeys[i].key_status == "Key Down"))
                    {
                        MidiOut midiOut = new MidiOut(MidiDevice);
                        midiOut.Send(MidiMessage.ChangeControl(SettingsValues.SettingsKeys[i].midi1, SettingsValues.SettingsKeys[i].midi2, SettingsValues.SettingsKeys[i].midi3).RawData);
                        midiOut.Close();

                        Debug.WriteLine(SettingsValues.SettingsKeys[i].key);
                    }
                }
            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (MidiDevice > -1)
            {
                for (int i = 0; i < SettingsValues.SettingsKeys.Count; i++)
                {
                    if ((SettingsValues.SettingsKeys[i].key == e.KeyCode) && (SettingsValues.SettingsKeys[i].key_status == "Key Up"))
                    {
                        MidiOut midiOut = new MidiOut(MidiDevice);
                        midiOut.Send(MidiMessage.ChangeControl(SettingsValues.SettingsKeys[i].midi1, SettingsValues.SettingsKeys[i].midi2, SettingsValues.SettingsKeys[i].midi3).RawData);
                        midiOut.Close();

                        Debug.WriteLine(SettingsValues.SettingsKeys[i].key);
                    }
                }
            }
        }

        void Exit(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        void GridViewShow(object? sender, EventArgs e)
        {
            GridView gridview_f = new GridView(this);
            gridview_f.Show();
        }

        void SettingsShow(object? sender, EventArgs e)
        {
            SettingsForm settings_f = new SettingsForm();
            settings_f.Show();
        }

        private void LoadFile()
        {
            string path = settings_path + keys_settings_fileName;

            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(settings));

                StreamReader reader = new StreamReader(path);
                SettingsValues = serializer.Deserialize(reader) as settings;
                reader.Close();

                for (int i = 0; i < SettingsValues.SettingsKeys.Count; i++)
                {
                    gkh.HookedKeys.Add(SettingsValues.SettingsKeys[i].key);
                }
            }
        }

        private void LoadDevices()
        {
            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                if (SettingsValues.MidiDeviceName == MidiOut.DeviceInfo(device).ProductName)
                {
                    MidiDevice = device;
                }
            }
        }
    }

    public class settings
    {
        public List<settings_keys> SettingsKeys = new List<settings_keys>();
        public string? MidiDeviceName { get; set; }
    }

    public class settings_keys
    {
        public Keys key { get; set; }
        public string key_status { get; set; }
        public int midi1 { get; set; }
        public int midi2 { get; set; }
        public int midi3 { get; set; }
    }
}
