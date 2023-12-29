using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QwertyToMIDI
{
    public partial class ButtonsForm : Form
    {
        private AppTray parent;

        private const int buttonWidth = 80;
        private const int buttonHeight = 30;
        private const int spacing = 10;

        private List<Button> dynamicButtons = new List<Button>();

        private Keys lastKey = Keys.None;

        public ButtonsForm(AppTray at)
        {
            InitializeComponent();

            parent = at;
        }

        private void ButtonsForm_Load(object sender, EventArgs e)
        {
            List<settings_keys> uniqueKeysList = parent.SettingsValues.SettingsKeys
            .GroupBy(k => k.key)
            .Select(g => g.First())
            .ToList();

            for (int i = 0; i < uniqueKeysList.Count; i++)
            {
                CreateDynamicButton(uniqueKeysList[i].key);
            }

            Button createButton = new Button();
            createButton.Text = "+";
            createButton.Size = new Size(buttonWidth, buttonHeight);

            createButton.Click += CreateButton_Click;

            flowLayoutPanel_dynamicButtons.Controls.Add(createButton);
        }

        private void CreateDynamicButton(Keys keyButton, bool createFromUser = false)
        {
            if (!dynamicButtons.Any(item => item.Text == keyButton.ToString()))
            {
                Button dynamicButton = new Button();
                dynamicButton.Text = keyButton.ToString();
                dynamicButton.Size = new Size(buttonWidth, buttonHeight);

                dynamicButton.Click += (sender, e) => DynamicButton_Click(keyButton);

                flowLayoutPanel_dynamicButtons.Controls.Add(dynamicButton);

                if (createFromUser)
                    flowLayoutPanel_dynamicButtons.Controls.SetChildIndex(dynamicButton, flowLayoutPanel_dynamicButtons.Controls.Count - 2);

                dynamicButtons.Add(dynamicButton);
            }
        }

        private void DynamicButton_Click(Keys keyButton)
        {
            dataGridView_KeyDown.Rows.Clear();
            dataGridView_KeyUp.Rows.Clear();

            lastKey = keyButton;

            foreach (settings_keys k in parent.SettingsValues.SettingsKeys)
            {
                if (k.key == keyButton)
                {
                    if (k.key_status == "Key Down")
                        dataGridView_KeyDown.Rows.Add(k.midi1, k.midi2, k.midi3);

                    if (k.key_status == "Key Up")
                        dataGridView_KeyUp.Rows.Add(k.midi1, k.midi2, k.midi3);
                }
            }

            button_AddKeyDown.Enabled = true;
            button_AddKeyUp.Enabled = true;
            button_DeleteButton.Enabled = true;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateDynamicButton(Keys.V, true);
        }

        private void button_AddKeyDown_Click(object sender, EventArgs e)
        {
            dataGridView_KeyDown.Rows.Add((int)numericUpDown_MIDI1.Value, (int)numericUpDown_MIDI2.Value, (int)numericUpDown_MIDI3.Value);

            if (!parent.gkh.HookedKeys.Contains(lastKey))
                parent.gkh.HookedKeys.Add(lastKey);

            parent.SettingsValues.SettingsKeys.Add(new settings_keys()
            {
                key = lastKey,
                key_status = "Key Down",
                midi1 = (int)numericUpDown_MIDI1.Value,
                midi2 = (int)numericUpDown_MIDI2.Value,
                midi3 = (int)numericUpDown_MIDI3.Value
            });

            parent.SaveFile();
        }

        private void button_RemoveKeyDown_Click(object sender, EventArgs e)
        {
            int selected_index = dataGridView_KeyDown.SelectedRows[0].Index;
            int dgv_Value1 = (int)dataGridView_KeyDown.Rows[selected_index].Cells[0].Value;
            int dgv_Value2 = (int)dataGridView_KeyDown.Rows[selected_index].Cells[1].Value;
            int dgv_Value3 = (int)dataGridView_KeyDown.Rows[selected_index].Cells[2].Value;

            foreach (var keys in parent.SettingsValues.SettingsKeys)
            {
                if (keys.key == lastKey && keys.key_status == "Key Down" && keys.midi1 == dgv_Value1 && keys.midi2 == dgv_Value2 && keys.midi3 == dgv_Value3)
                {
                    Debug.WriteLine("удаляется {0} {1} {2} {3} {4}", keys.key, keys.key_status, keys.midi1, keys.midi2, keys.midi3);
                    parent.SettingsValues.SettingsKeys.Remove(keys);

                    break;
                }
            }

            /*if (!parent.SettingsValues.SettingsKeys.Any(item => item.key == lastKey))
                parent.SettingsValues.SettingsKeys.Add(new settings_keys()
                {
                    key = lastKey,
                    key_status = "",
                    midi1 = 0,
                    midi2 = 0,
                    midi3 = 0
                });*/

            dataGridView_KeyDown.Rows.RemoveAt(dataGridView_KeyDown.SelectedRows[0].Index);

            parent.SaveFile();
        }

        private void button_AddKeyUp_Click(object sender, EventArgs e)
        {
            dataGridView_KeyUp.Rows.Add((int)numericUpDown_MIDI1.Value, (int)numericUpDown_MIDI2.Value, (int)numericUpDown_MIDI3.Value);

            if (!parent.gkh.HookedKeys.Contains(lastKey))
                parent.gkh.HookedKeys.Add(lastKey);

            parent.SettingsValues.SettingsKeys.Add(new settings_keys()
            {
                key = lastKey,
                key_status = "Key Up",
                midi1 = (int)numericUpDown_MIDI1.Value,
                midi2 = (int)numericUpDown_MIDI2.Value,
                midi3 = (int)numericUpDown_MIDI3.Value
            });

            parent.SaveFile();
        }

        private void button_RemoveKeyUp_Click(object sender, EventArgs e)
        {
            int selected_index = dataGridView_KeyUp.SelectedRows[0].Index;
            int dgv_Value1 = (int)dataGridView_KeyUp.Rows[selected_index].Cells[0].Value;
            int dgv_Value2 = (int)dataGridView_KeyUp.Rows[selected_index].Cells[1].Value;
            int dgv_Value3 = (int)dataGridView_KeyUp.Rows[selected_index].Cells[2].Value;

            foreach (var keys in parent.SettingsValues.SettingsKeys)
            {
                if (keys.key == lastKey && keys.key_status == "Key Up" && keys.midi1 == dgv_Value1 && keys.midi2 == dgv_Value2 && keys.midi3 == dgv_Value3)
                {
                    parent.SettingsValues.SettingsKeys.Remove(keys);

                    break;
                }
            }

            /*if (!parent.SettingsValues.SettingsKeys.Any(item => item.key == lastKey))
                parent.SettingsValues.SettingsKeys.Add(new settings_keys()
                {
                    key = lastKey,
                    key_status = "",
                    midi1 = 0,
                    midi2 = 0,
                    midi3 = 0
                });*/

            dataGridView_KeyUp.Rows.RemoveAt(dataGridView_KeyUp.SelectedRows[0].Index);

            parent.SaveFile();
        }

        private void dataGridView_KeyDown_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            button_EditKeyDown.Enabled = true;
            button_RemoveKeyDown.Enabled = true;
        }

        private void dataGridView_KeyDown_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView_KeyDown.Rows.Count == 0)
            {
                button_EditKeyDown.Enabled = false;
                button_RemoveKeyDown.Enabled = false;
            }
        }

        private void dataGridView_KeyUp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            button_EditKeyUp.Enabled = true;
            button_RemoveKeyUp.Enabled = true;
        }

        private void dataGridView_KeyUp_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView_KeyUp.Rows.Count == 0)
            {
                button_EditKeyUp.Enabled = false;
                button_RemoveKeyUp.Enabled = false;
            }
        }

        private void button_DeleteButton_Click(object sender, EventArgs e)
        {
            dataGridView_KeyDown.Rows.Clear();
            dataGridView_KeyUp.Rows.Clear();

            button_AddKeyDown.Enabled = false;
            button_EditKeyDown.Enabled = false;
            button_RemoveKeyDown.Enabled = false;

            button_AddKeyUp.Enabled = false;
            button_EditKeyUp.Enabled = false;
            button_RemoveKeyUp.Enabled = false;

            button_DeleteButton.Enabled = false;

            Button b = dynamicButtons.FindAll(item => item.Text == lastKey.ToString())[0];
            b.Dispose();
            dynamicButtons.Remove(b);

            parent.SettingsValues.SettingsKeys.RemoveAll(item => item.key == lastKey);

            lastKey = Keys.None;

            parent.SaveFile();
        }
    }
}
