namespace QwertyToMIDI
{
    partial class ButtonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonsForm));
            dataGridView_KeyDown = new DataGridView();
            Column_Controller = new DataGridViewTextBoxColumn();
            Column_Value = new DataGridViewTextBoxColumn();
            Column_Channel = new DataGridViewTextBoxColumn();
            numericUpDown_MIDI3 = new NumericUpDown();
            numericUpDown_MIDI2 = new NumericUpDown();
            numericUpDown_MIDI1 = new NumericUpDown();
            label_MIDI3 = new Label();
            label_MIDI2 = new Label();
            label_MIDI1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_AddKeyUp = new Button();
            button_EditKeyUp = new Button();
            button_RemoveKeyUp = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button_AddKeyDown = new Button();
            button_EditKeyDown = new Button();
            button_RemoveKeyDown = new Button();
            dataGridView_KeyUp = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            groupBox_dynamicButtons = new GroupBox();
            flowLayoutPanel_dynamicButtons = new FlowLayoutPanel();
            groupBox_KeyDown = new GroupBox();
            groupBox_KeyUp = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            button_DeleteButton = new Button();
            button_Refresh_Devices = new Button();
            comboBox_Device_List = new ComboBox();
            label_MIDI_Device = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KeyDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KeyUp).BeginInit();
            groupBox_dynamicButtons.SuspendLayout();
            groupBox_KeyDown.SuspendLayout();
            groupBox_KeyUp.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_KeyDown
            // 
            dataGridView_KeyDown.AllowUserToAddRows = false;
            dataGridView_KeyDown.AllowUserToDeleteRows = false;
            dataGridView_KeyDown.AllowUserToResizeColumns = false;
            dataGridView_KeyDown.AllowUserToResizeRows = false;
            dataGridView_KeyDown.BackgroundColor = SystemColors.Control;
            dataGridView_KeyDown.BorderStyle = BorderStyle.None;
            dataGridView_KeyDown.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_KeyDown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_KeyDown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KeyDown.Columns.AddRange(new DataGridViewColumn[] { Column_Controller, Column_Value, Column_Channel });
            dataGridView_KeyDown.Dock = DockStyle.Fill;
            dataGridView_KeyDown.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_KeyDown.Location = new Point(3, 19);
            dataGridView_KeyDown.MultiSelect = false;
            dataGridView_KeyDown.Name = "dataGridView_KeyDown";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_KeyDown.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_KeyDown.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(38, 90, 112);
            dataGridView_KeyDown.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_KeyDown.RowTemplate.Height = 25;
            dataGridView_KeyDown.ScrollBars = ScrollBars.Vertical;
            dataGridView_KeyDown.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_KeyDown.ShowCellErrors = false;
            dataGridView_KeyDown.ShowCellToolTips = false;
            dataGridView_KeyDown.ShowEditingIcon = false;
            dataGridView_KeyDown.ShowRowErrors = false;
            dataGridView_KeyDown.Size = new Size(222, 81);
            dataGridView_KeyDown.TabIndex = 1;
            dataGridView_KeyDown.RowsAdded += dataGridView_KeyDown_RowsAdded;
            dataGridView_KeyDown.RowsRemoved += dataGridView_KeyDown_RowsRemoved;
            // 
            // Column_Controller
            // 
            Column_Controller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Controller.HeaderText = "Controller";
            Column_Controller.Name = "Column_Controller";
            // 
            // Column_Value
            // 
            Column_Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Value.HeaderText = "Value";
            Column_Value.Name = "Column_Value";
            // 
            // Column_Channel
            // 
            Column_Channel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Channel.HeaderText = "Channel";
            Column_Channel.Name = "Column_Channel";
            // 
            // numericUpDown_MIDI3
            // 
            numericUpDown_MIDI3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown_MIDI3.Location = new Point(97, 61);
            numericUpDown_MIDI3.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown_MIDI3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_MIDI3.Name = "numericUpDown_MIDI3";
            numericUpDown_MIDI3.Size = new Size(128, 23);
            numericUpDown_MIDI3.TabIndex = 22;
            numericUpDown_MIDI3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown_MIDI2
            // 
            numericUpDown_MIDI2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown_MIDI2.Location = new Point(97, 32);
            numericUpDown_MIDI2.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            numericUpDown_MIDI2.Name = "numericUpDown_MIDI2";
            numericUpDown_MIDI2.Size = new Size(128, 23);
            numericUpDown_MIDI2.TabIndex = 21;
            // 
            // numericUpDown_MIDI1
            // 
            numericUpDown_MIDI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown_MIDI1.Location = new Point(97, 3);
            numericUpDown_MIDI1.Maximum = new decimal(new int[] { 127, 0, 0, 0 });
            numericUpDown_MIDI1.Name = "numericUpDown_MIDI1";
            numericUpDown_MIDI1.Size = new Size(128, 23);
            numericUpDown_MIDI1.TabIndex = 20;
            // 
            // label_MIDI3
            // 
            label_MIDI3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_MIDI3.AutoSize = true;
            label_MIDI3.Location = new Point(3, 63);
            label_MIDI3.Name = "label_MIDI3";
            label_MIDI3.Size = new Size(79, 15);
            label_MIDI3.TabIndex = 19;
            label_MIDI3.Text = "MIDI Channel";
            // 
            // label_MIDI2
            // 
            label_MIDI2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_MIDI2.AutoSize = true;
            label_MIDI2.Location = new Point(3, 34);
            label_MIDI2.Name = "label_MIDI2";
            label_MIDI2.Size = new Size(63, 15);
            label_MIDI2.TabIndex = 18;
            label_MIDI2.Text = "MIDI Value";
            // 
            // label_MIDI1
            // 
            label_MIDI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_MIDI1.AutoSize = true;
            label_MIDI1.Location = new Point(3, 5);
            label_MIDI1.Name = "label_MIDI1";
            label_MIDI1.Size = new Size(88, 15);
            label_MIDI1.TabIndex = 17;
            label_MIDI1.Text = "MIDI Controller";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(button_AddKeyUp, 0, 0);
            tableLayoutPanel2.Controls.Add(button_EditKeyUp, 1, 0);
            tableLayoutPanel2.Controls.Add(button_RemoveKeyUp, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(3, 100);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(222, 31);
            tableLayoutPanel2.TabIndex = 29;
            // 
            // button_AddKeyUp
            // 
            button_AddKeyUp.Dock = DockStyle.Top;
            button_AddKeyUp.Enabled = false;
            button_AddKeyUp.Location = new Point(3, 3);
            button_AddKeyUp.Name = "button_AddKeyUp";
            button_AddKeyUp.Size = new Size(67, 23);
            button_AddKeyUp.TabIndex = 0;
            button_AddKeyUp.Text = "Add";
            button_AddKeyUp.UseVisualStyleBackColor = true;
            button_AddKeyUp.Click += button_AddKeyUp_Click;
            // 
            // button_EditKeyUp
            // 
            button_EditKeyUp.Dock = DockStyle.Top;
            button_EditKeyUp.Enabled = false;
            button_EditKeyUp.Location = new Point(76, 3);
            button_EditKeyUp.Name = "button_EditKeyUp";
            button_EditKeyUp.Size = new Size(67, 23);
            button_EditKeyUp.TabIndex = 1;
            button_EditKeyUp.Text = "Edit";
            button_EditKeyUp.UseVisualStyleBackColor = true;
            button_EditKeyUp.Click += button_EditKeyUp_Click;
            // 
            // button_RemoveKeyUp
            // 
            button_RemoveKeyUp.Dock = DockStyle.Top;
            button_RemoveKeyUp.Enabled = false;
            button_RemoveKeyUp.Location = new Point(149, 3);
            button_RemoveKeyUp.Name = "button_RemoveKeyUp";
            button_RemoveKeyUp.Size = new Size(70, 23);
            button_RemoveKeyUp.TabIndex = 2;
            button_RemoveKeyUp.Text = "Remove";
            button_RemoveKeyUp.UseVisualStyleBackColor = true;
            button_RemoveKeyUp.Click += button_RemoveKeyUp_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button_AddKeyDown, 0, 0);
            tableLayoutPanel1.Controls.Add(button_EditKeyDown, 1, 0);
            tableLayoutPanel1.Controls.Add(button_RemoveKeyDown, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(222, 31);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // button_AddKeyDown
            // 
            button_AddKeyDown.Dock = DockStyle.Top;
            button_AddKeyDown.Enabled = false;
            button_AddKeyDown.Location = new Point(3, 3);
            button_AddKeyDown.Name = "button_AddKeyDown";
            button_AddKeyDown.Size = new Size(67, 23);
            button_AddKeyDown.TabIndex = 0;
            button_AddKeyDown.Text = "Add";
            button_AddKeyDown.UseVisualStyleBackColor = true;
            button_AddKeyDown.Click += button_AddKeyDown_Click;
            // 
            // button_EditKeyDown
            // 
            button_EditKeyDown.Dock = DockStyle.Top;
            button_EditKeyDown.Enabled = false;
            button_EditKeyDown.Location = new Point(76, 3);
            button_EditKeyDown.Name = "button_EditKeyDown";
            button_EditKeyDown.Size = new Size(67, 23);
            button_EditKeyDown.TabIndex = 1;
            button_EditKeyDown.Text = "Edit";
            button_EditKeyDown.UseVisualStyleBackColor = true;
            button_EditKeyDown.Click += button_EditKeyDown_Click;
            // 
            // button_RemoveKeyDown
            // 
            button_RemoveKeyDown.Dock = DockStyle.Top;
            button_RemoveKeyDown.Enabled = false;
            button_RemoveKeyDown.Location = new Point(149, 3);
            button_RemoveKeyDown.Name = "button_RemoveKeyDown";
            button_RemoveKeyDown.Size = new Size(70, 23);
            button_RemoveKeyDown.TabIndex = 2;
            button_RemoveKeyDown.Text = "Remove";
            button_RemoveKeyDown.UseVisualStyleBackColor = true;
            button_RemoveKeyDown.Click += button_RemoveKeyDown_Click;
            // 
            // dataGridView_KeyUp
            // 
            dataGridView_KeyUp.AllowUserToAddRows = false;
            dataGridView_KeyUp.AllowUserToDeleteRows = false;
            dataGridView_KeyUp.AllowUserToResizeColumns = false;
            dataGridView_KeyUp.AllowUserToResizeRows = false;
            dataGridView_KeyUp.BackgroundColor = SystemColors.Control;
            dataGridView_KeyUp.BorderStyle = BorderStyle.None;
            dataGridView_KeyUp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_KeyUp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KeyUp.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView_KeyUp.Dock = DockStyle.Fill;
            dataGridView_KeyUp.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_KeyUp.Location = new Point(3, 19);
            dataGridView_KeyUp.MultiSelect = false;
            dataGridView_KeyUp.Name = "dataGridView_KeyUp";
            dataGridView_KeyUp.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(38, 90, 112);
            dataGridView_KeyUp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_KeyUp.RowTemplate.Height = 25;
            dataGridView_KeyUp.ScrollBars = ScrollBars.Vertical;
            dataGridView_KeyUp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_KeyUp.ShowCellErrors = false;
            dataGridView_KeyUp.ShowCellToolTips = false;
            dataGridView_KeyUp.ShowEditingIcon = false;
            dataGridView_KeyUp.ShowRowErrors = false;
            dataGridView_KeyUp.Size = new Size(222, 81);
            dataGridView_KeyUp.TabIndex = 27;
            dataGridView_KeyUp.RowsAdded += dataGridView_KeyUp_RowsAdded;
            dataGridView_KeyUp.RowsRemoved += dataGridView_KeyUp_RowsRemoved;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Controller";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Channel";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox_dynamicButtons
            // 
            groupBox_dynamicButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_dynamicButtons.BackColor = SystemColors.Control;
            groupBox_dynamicButtons.Controls.Add(flowLayoutPanel_dynamicButtons);
            groupBox_dynamicButtons.Location = new Point(12, 41);
            groupBox_dynamicButtons.Name = "groupBox_dynamicButtons";
            groupBox_dynamicButtons.Padding = new Padding(0);
            groupBox_dynamicButtons.Size = new Size(295, 404);
            groupBox_dynamicButtons.TabIndex = 26;
            groupBox_dynamicButtons.TabStop = false;
            groupBox_dynamicButtons.Text = "Buttons";
            // 
            // flowLayoutPanel_dynamicButtons
            // 
            flowLayoutPanel_dynamicButtons.BackColor = Color.Transparent;
            flowLayoutPanel_dynamicButtons.Dock = DockStyle.Fill;
            flowLayoutPanel_dynamicButtons.Location = new Point(0, 16);
            flowLayoutPanel_dynamicButtons.Name = "flowLayoutPanel_dynamicButtons";
            flowLayoutPanel_dynamicButtons.Size = new Size(295, 388);
            flowLayoutPanel_dynamicButtons.TabIndex = 0;
            // 
            // groupBox_KeyDown
            // 
            groupBox_KeyDown.Controls.Add(dataGridView_KeyDown);
            groupBox_KeyDown.Controls.Add(tableLayoutPanel1);
            groupBox_KeyDown.Dock = DockStyle.Fill;
            groupBox_KeyDown.Location = new Point(3, 3);
            groupBox_KeyDown.Name = "groupBox_KeyDown";
            groupBox_KeyDown.Size = new Size(228, 134);
            groupBox_KeyDown.TabIndex = 28;
            groupBox_KeyDown.TabStop = false;
            groupBox_KeyDown.Text = "Key Down";
            // 
            // groupBox_KeyUp
            // 
            groupBox_KeyUp.Controls.Add(dataGridView_KeyUp);
            groupBox_KeyUp.Controls.Add(tableLayoutPanel2);
            groupBox_KeyUp.Dock = DockStyle.Fill;
            groupBox_KeyUp.Location = new Point(3, 143);
            groupBox_KeyUp.Name = "groupBox_KeyUp";
            groupBox_KeyUp.Size = new Size(228, 134);
            groupBox_KeyUp.TabIndex = 29;
            groupBox_KeyUp.TabStop = false;
            groupBox_KeyUp.Text = "Key Up";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox_KeyDown, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox_KeyUp, 0, 1);
            tableLayoutPanel3.Controls.Add(button_DeleteButton, 0, 3);
            tableLayoutPanel3.Location = new Point(313, 41);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(234, 404);
            tableLayoutPanel3.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(numericUpDown_MIDI2);
            panel1.Controls.Add(label_MIDI3);
            panel1.Controls.Add(label_MIDI1);
            panel1.Controls.Add(label_MIDI2);
            panel1.Controls.Add(numericUpDown_MIDI3);
            panel1.Controls.Add(numericUpDown_MIDI1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 87);
            panel1.TabIndex = 31;
            // 
            // button_DeleteButton
            // 
            button_DeleteButton.Dock = DockStyle.Fill;
            button_DeleteButton.Enabled = false;
            button_DeleteButton.Location = new Point(3, 376);
            button_DeleteButton.Name = "button_DeleteButton";
            button_DeleteButton.Size = new Size(228, 25);
            button_DeleteButton.TabIndex = 32;
            button_DeleteButton.Text = "Delete Button";
            button_DeleteButton.UseVisualStyleBackColor = true;
            button_DeleteButton.Click += button_DeleteButton_Click;
            // 
            // button_Refresh_Devices
            // 
            button_Refresh_Devices.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Refresh_Devices.Location = new Point(472, 12);
            button_Refresh_Devices.Name = "button_Refresh_Devices";
            button_Refresh_Devices.Size = new Size(75, 23);
            button_Refresh_Devices.TabIndex = 33;
            button_Refresh_Devices.Text = "Refresh";
            button_Refresh_Devices.UseVisualStyleBackColor = true;
            button_Refresh_Devices.Click += button_Refresh_Devices_Click;
            // 
            // comboBox_Device_List
            // 
            comboBox_Device_List.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Device_List.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Device_List.FormattingEnabled = true;
            comboBox_Device_List.Location = new Point(87, 12);
            comboBox_Device_List.MaxDropDownItems = 18;
            comboBox_Device_List.Name = "comboBox_Device_List";
            comboBox_Device_List.Size = new Size(379, 23);
            comboBox_Device_List.TabIndex = 32;
            comboBox_Device_List.SelectedIndexChanged += comboBox_Device_List_SelectedIndexChanged;
            // 
            // label_MIDI_Device
            // 
            label_MIDI_Device.AutoSize = true;
            label_MIDI_Device.Location = new Point(12, 15);
            label_MIDI_Device.Name = "label_MIDI_Device";
            label_MIDI_Device.Size = new Size(70, 15);
            label_MIDI_Device.TabIndex = 31;
            label_MIDI_Device.Text = "MIDI Device";
            // 
            // ButtonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 457);
            Controls.Add(button_Refresh_Devices);
            Controls.Add(comboBox_Device_List);
            Controls.Add(label_MIDI_Device);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(groupBox_dynamicButtons);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(528, 440);
            Name = "ButtonsForm";
            Text = "Buttons";
            Load += ButtonsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_KeyDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MIDI1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_KeyUp).EndInit();
            groupBox_dynamicButtons.ResumeLayout(false);
            groupBox_KeyDown.ResumeLayout(false);
            groupBox_KeyUp.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_KeyDown;
        private NumericUpDown numericUpDown_MIDI3;
        private NumericUpDown numericUpDown_MIDI2;
        private NumericUpDown numericUpDown_MIDI1;
        private Label label_MIDI3;
        private Label label_MIDI2;
        private Label label_MIDI1;
        private GroupBox groupBox_dynamicButtons;
        private DataGridViewTextBoxColumn Column_Controller;
        private DataGridViewTextBoxColumn Column_Value;
        private DataGridViewTextBoxColumn Column_Channel;
        private DataGridView dataGridView_KeyUp;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_AddKeyUp;
        private Button button_EditKeyUp;
        private Button button_RemoveKeyUp;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_AddKeyDown;
        private Button button_EditKeyDown;
        private Button button_RemoveKeyDown;
        private GroupBox groupBox_KeyDown;
        private GroupBox groupBox_KeyUp;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel_dynamicButtons;
        private Button button_DeleteButton;
        private Button button_Refresh_Devices;
        private ComboBox comboBox_Device_List;
        private Label label_MIDI_Device;
    }
}