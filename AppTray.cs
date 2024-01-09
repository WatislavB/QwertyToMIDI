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

        private ButtonsForm buttons_f;
        private GridView gridview_f;
        private SettingsForm settings_f;

        private List<Form> openedForms = new List<Form>();

        public AppTray()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.RIcon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items = { new ToolStripMenuItem("Settings Hotkeys", null, SettingsHotkeys), new ToolStripMenuItem("Grid View", null, GridViewShow), new ToolStripMenuItem("Settings", null, SettingsShow), new ToolStripMenuItem("Exit", null, Exit) }
                },
                Visible = true
            };

            trayIcon.DoubleClick += new EventHandler(SettingsHotkeys);

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
                    if (SettingsValues.SettingsKeys[i].key_status != "")
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
                    if (SettingsValues.SettingsKeys[i].key_status != "")
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

        void SettingsHotkeys(object? sender, EventArgs e)
        {
            if (!IsFormOpened(typeof(ButtonsForm)))
            {
                if (IsFormOpened(typeof(GridView)))
                {
                    gridview_f.Close();
                }

                buttons_f = new ButtonsForm(this);
                buttons_f.FormClosed += (s, args) => openedForms.Remove(buttons_f);
                openedForms.Add(buttons_f);
                buttons_f.Show();
            }
            else
            {
                buttons_f.Focus();
            }
        }

        void GridViewShow(object? sender, EventArgs e)
        {
            if (!IsFormOpened(typeof(GridView)))
            {
                if (IsFormOpened(typeof(ButtonsForm)))
                {
                    buttons_f.Close();
                }

                gridview_f = new GridView(this);
                gridview_f.FormClosed += (s, args) => openedForms.Remove(gridview_f);
                openedForms.Add(gridview_f);
                gridview_f.Show();
            }
            else
            {
                gridview_f.Focus();
            }
        }

        void SettingsShow(object? sender, EventArgs e)
        {
            if (!IsFormOpened(typeof(SettingsForm)))
            {
                settings_f = new SettingsForm();
                settings_f.FormClosed += (s, args) => openedForms.Remove(settings_f);
                openedForms.Add(settings_f);
                settings_f.Show();
            }
            else
            {
                settings_f.Focus();
            }
        }

        public void SaveFile()
        {
            if (!Directory.Exists(settings_path))
            {
                Directory.CreateDirectory(settings_path);
            }

            string path = settings_path + keys_settings_fileName;

            Stream stream = File.Open(path, FileMode.Create);

            XmlSerializer serialiser = new XmlSerializer(typeof(settings));
            serialiser.Serialize(stream, SettingsValues);
            stream.Close();
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

        private bool IsFormOpened(Type formType)
        {
            return openedForms.Exists(form => form.GetType() == formType);
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
