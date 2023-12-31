﻿namespace QwertyToMIDI
{
    partial class GridView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridView));
            button_Add = new Button();
            button_Remove = new Button();
            button_Edit = new Button();
            dataGridView_Keys = new DataGridView();
            Column_Key = new DataGridViewTextBoxColumn();
            Column_KeyStatus = new DataGridViewTextBoxColumn();
            Column_MIDI1 = new DataGridViewTextBoxColumn();
            Column_MIDI2 = new DataGridViewTextBoxColumn();
            Column_MIDI3 = new DataGridViewTextBoxColumn();
            label_Key = new Label();
            textBox_Key = new TextBox();
            label_MIDI1 = new Label();
            label_MIDI2 = new Label();
            label_MIDI3 = new Label();
            numericUpDown_MIDI1 = new NumericUpDown();
            numericUpDown_MIDI2 = new NumericUpDown();
            numericUpDown_MIDI3 = new NumericUpDown();
            label_MIDI_Device = new Label();
            comboBox_Device_List = new ComboBox();
            button_Refresh_Devices = new Button();
            comboBox_Key_status = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Keys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI3).BeginInit();
            SuspendLayout();
            // 
            // button_Add
            // 
            button_Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Add.Location = new Point(12, 434);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 0;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Remove
            // 
            button_Remove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Remove.Location = new Point(174, 434);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(75, 23);
            button_Remove.TabIndex = 2;
            button_Remove.Text = "Remove";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // button_Edit
            // 
            button_Edit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Edit.Location = new Point(93, 434);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(75, 23);
            button_Edit.TabIndex = 4;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // dataGridView_Keys
            // 
            dataGridView_Keys.AllowUserToAddRows = false;
            dataGridView_Keys.AllowUserToDeleteRows = false;
            dataGridView_Keys.AllowUserToResizeRows = false;
            dataGridView_Keys.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Keys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Keys.Columns.AddRange(new DataGridViewColumn[] { Column_Key, Column_KeyStatus, Column_MIDI1, Column_MIDI2, Column_MIDI3 });
            dataGridView_Keys.Location = new Point(12, 41);
            dataGridView_Keys.MultiSelect = false;
            dataGridView_Keys.Name = "dataGridView_Keys";
            dataGridView_Keys.ReadOnly = true;
            dataGridView_Keys.RowTemplate.Height = 25;
            dataGridView_Keys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Keys.Size = new Size(663, 284);
            dataGridView_Keys.TabIndex = 5;
            // 
            // Column_Key
            // 
            Column_Key.HeaderText = "Key";
            Column_Key.Name = "Column_Key";
            Column_Key.ReadOnly = true;
            Column_Key.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_KeyStatus
            // 
            Column_KeyStatus.HeaderText = "Key Status";
            Column_KeyStatus.Name = "Column_KeyStatus";
            Column_KeyStatus.ReadOnly = true;
            Column_KeyStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_MIDI1
            // 
            Column_MIDI1.HeaderText = "MIDI Controller";
            Column_MIDI1.Name = "Column_MIDI1";
            Column_MIDI1.ReadOnly = true;
            Column_MIDI1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_MIDI1.Width = 120;
            // 
            // Column_MIDI2
            // 
            Column_MIDI2.HeaderText = "MIDI Value";
            Column_MIDI2.Name = "Column_MIDI2";
            Column_MIDI2.ReadOnly = true;
            Column_MIDI2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_MIDI3
            // 
            Column_MIDI3.HeaderText = "MIDI Channel";
            Column_MIDI3.Name = "Column_MIDI3";
            Column_MIDI3.ReadOnly = true;
            Column_MIDI3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_MIDI3.Width = 110;
            // 
            // label_Key
            // 
            label_Key.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_Key.AutoSize = true;
            label_Key.Location = new Point(12, 334);
            label_Key.Name = "label_Key";
            label_Key.Size = new Size(26, 15);
            label_Key.TabIndex = 6;
            label_Key.Text = "Key";
            // 
            // textBox_Key
            // 
            textBox_Key.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Key.Location = new Point(44, 331);
            textBox_Key.Name = "textBox_Key";
            textBox_Key.ReadOnly = true;
            textBox_Key.Size = new Size(124, 23);
            textBox_Key.TabIndex = 7;
            textBox_Key.KeyUp += textBox_Key_KeyUp;
            // 
            // label_MIDI1
            // 
            label_MIDI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_MIDI1.AutoSize = true;
            label_MIDI1.Location = new Point(497, 333);
            label_MIDI1.Name = "label_MIDI1";
            label_MIDI1.Size = new Size(88, 15);
            label_MIDI1.TabIndex = 11;
            label_MIDI1.Text = "MIDI Controller";
            // 
            // label_MIDI2
            // 
            label_MIDI2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_MIDI2.AutoSize = true;
            label_MIDI2.Location = new Point(497, 362);
            label_MIDI2.Name = "label_MIDI2";
            label_MIDI2.Size = new Size(63, 15);
            label_MIDI2.TabIndex = 12;
            label_MIDI2.Text = "MIDI Value";
            // 
            // label_MIDI3
            // 
            label_MIDI3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_MIDI3.AutoSize = true;
            label_MIDI3.Location = new Point(497, 391);
            label_MIDI3.Name = "label_MIDI3";
            label_MIDI3.Size = new Size(79, 15);
            label_MIDI3.TabIndex = 13;
            label_MIDI3.Text = "MIDI Channel";
            // 
            // numericUpDown_MIDI1
            // 
            numericUpDown_MIDI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDown_MIDI1.Location = new Point(591, 331);
            numericUpDown_MIDI1.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            numericUpDown_MIDI1.Name = "numericUpDown_MIDI1";
            numericUpDown_MIDI1.Size = new Size(84, 23);
            numericUpDown_MIDI1.TabIndex = 14;
            // 
            // numericUpDown_MIDI2
            // 
            numericUpDown_MIDI2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDown_MIDI2.Location = new Point(591, 360);
            numericUpDown_MIDI2.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            numericUpDown_MIDI2.Name = "numericUpDown_MIDI2";
            numericUpDown_MIDI2.Size = new Size(84, 23);
            numericUpDown_MIDI2.TabIndex = 15;
            // 
            // numericUpDown_MIDI3
            // 
            numericUpDown_MIDI3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDown_MIDI3.Location = new Point(591, 389);
            numericUpDown_MIDI3.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown_MIDI3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_MIDI3.Name = "numericUpDown_MIDI3";
            numericUpDown_MIDI3.Size = new Size(84, 23);
            numericUpDown_MIDI3.TabIndex = 16;
            numericUpDown_MIDI3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_MIDI_Device
            // 
            label_MIDI_Device.AutoSize = true;
            label_MIDI_Device.Location = new Point(12, 15);
            label_MIDI_Device.Name = "label_MIDI_Device";
            label_MIDI_Device.Size = new Size(70, 15);
            label_MIDI_Device.TabIndex = 17;
            label_MIDI_Device.Text = "MIDI Device";
            // 
            // comboBox_Device_List
            // 
            comboBox_Device_List.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Device_List.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Device_List.FormattingEnabled = true;
            comboBox_Device_List.Location = new Point(88, 12);
            comboBox_Device_List.MaxDropDownItems = 18;
            comboBox_Device_List.Name = "comboBox_Device_List";
            comboBox_Device_List.Size = new Size(506, 23);
            comboBox_Device_List.TabIndex = 18;
            comboBox_Device_List.SelectedIndexChanged += comboBox_Device_List_SelectedIndexChanged;
            // 
            // button_Refresh_Devices
            // 
            button_Refresh_Devices.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Refresh_Devices.Location = new Point(600, 12);
            button_Refresh_Devices.Name = "button_Refresh_Devices";
            button_Refresh_Devices.Size = new Size(75, 23);
            button_Refresh_Devices.TabIndex = 19;
            button_Refresh_Devices.Text = "Refresh";
            button_Refresh_Devices.UseVisualStyleBackColor = true;
            button_Refresh_Devices.Click += button_Refresh_Devices_Click;
            // 
            // comboBox_Key_status
            // 
            comboBox_Key_status.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_Key_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Key_status.FormattingEnabled = true;
            comboBox_Key_status.Items.AddRange(new object[] { "Key Down", "Key Up" });
            comboBox_Key_status.Location = new Point(44, 360);
            comboBox_Key_status.MaxDropDownItems = 2;
            comboBox_Key_status.Name = "comboBox_Key_status";
            comboBox_Key_status.Size = new Size(124, 23);
            comboBox_Key_status.TabIndex = 20;
            // 
            // GridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 469);
            Controls.Add(comboBox_Key_status);
            Controls.Add(button_Refresh_Devices);
            Controls.Add(comboBox_Device_List);
            Controls.Add(label_MIDI_Device);
            Controls.Add(numericUpDown_MIDI3);
            Controls.Add(numericUpDown_MIDI2);
            Controls.Add(numericUpDown_MIDI1);
            Controls.Add(label_MIDI3);
            Controls.Add(label_MIDI2);
            Controls.Add(label_MIDI1);
            Controls.Add(textBox_Key);
            Controls.Add(label_Key);
            Controls.Add(dataGridView_Keys);
            Controls.Add(button_Edit);
            Controls.Add(button_Remove);
            Controls.Add(button_Add);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GridView";
            Text = "Grid View";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Keys).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Add;
        private Button button_Remove;
        private Button button_Edit;
        private DataGridView dataGridView_Keys;
        private Label label_Key;
        private TextBox textBox_Key;
        private Label label_MIDI1;
        private Label label_MIDI2;
        private Label label_MIDI3;
        private NumericUpDown numericUpDown_MIDI1;
        private NumericUpDown numericUpDown_MIDI2;
        private NumericUpDown numericUpDown_MIDI3;
        private Label label_MIDI_Device;
        private ComboBox comboBox_Device_List;
        private Button button_Refresh_Devices;
        private ComboBox comboBox_Key_status;
        private DataGridViewTextBoxColumn Column_Key;
        private DataGridViewTextBoxColumn Column_KeyStatus;
        private DataGridViewTextBoxColumn Column_MIDI1;
        private DataGridViewTextBoxColumn Column_MIDI2;
        private DataGridViewTextBoxColumn Column_MIDI3;
    }
}