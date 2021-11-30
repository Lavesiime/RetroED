﻿namespace RetroED.Tools.StageconfigEditors.RSDKvBStageconfigEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ObjectsPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.LoadGlobalScriptsCB = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ObjCFGBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ObjPathHashBox = new System.Windows.Forms.TextBox();
            this.DelObjButton = new System.Windows.Forms.Button();
            this.ObjListBox = new System.Windows.Forms.ListBox();
            this.AddObjButton = new System.Windows.Forms.Button();
            this.SoundFXPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SFXNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SFXPathBox = new System.Windows.Forms.TextBox();
            this.RemoveSFXButton = new System.Windows.Forms.Button();
            this.SoundFXListBox = new System.Windows.Forms.ListBox();
            this.AddSFXButton = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_New = new System.Windows.Forms.MenuItem();
            this.MenuItem_Open = new System.Windows.Forms.MenuItem();
            this.MenuItem_Save = new System.Windows.Forms.MenuItem();
            this.MenuItem_SaveAs = new System.Windows.Forms.MenuItem();
            this.SFXIDLabel = new System.Windows.Forms.Label();
            this.ObjIDLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ObjectsPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SoundFXPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ObjectsPage);
            this.tabControl1.Controls.Add(this.SoundFXPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 559);
            this.tabControl1.TabIndex = 47;
            // 
            // ObjectsPage
            // 
            this.ObjectsPage.Controls.Add(this.groupBox7);
            this.ObjectsPage.Location = new System.Drawing.Point(4, 22);
            this.ObjectsPage.Name = "ObjectsPage";
            this.ObjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ObjectsPage.Size = new System.Drawing.Size(704, 533);
            this.ObjectsPage.TabIndex = 1;
            this.ObjectsPage.Text = "Objects";
            this.ObjectsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox7.Controls.Add(this.ObjIDLabel);
            this.groupBox7.Controls.Add(this.LoadGlobalScriptsCB);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.ObjCFGBox);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.ObjPathHashBox);
            this.groupBox7.Controls.Add(this.DelObjButton);
            this.groupBox7.Controls.Add(this.ObjListBox);
            this.groupBox7.Controls.Add(this.AddObjButton);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(698, 527);
            this.groupBox7.TabIndex = 47;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Object List";
            // 
            // LoadGlobalScriptsCB
            // 
            this.LoadGlobalScriptsCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadGlobalScriptsCB.AutoSize = true;
            this.LoadGlobalScriptsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadGlobalScriptsCB.Location = new System.Drawing.Point(409, 199);
            this.LoadGlobalScriptsCB.Name = "LoadGlobalScriptsCB";
            this.LoadGlobalScriptsCB.Size = new System.Drawing.Size(118, 17);
            this.LoadGlobalScriptsCB.TabIndex = 71;
            this.LoadGlobalScriptsCB.Text = "Load Global Scripts";
            this.LoadGlobalScriptsCB.UseVisualStyleBackColor = true;
            this.LoadGlobalScriptsCB.CheckedChanged += new System.EventHandler(this.LoadGlobalScriptsCB_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(405, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Object Name";
            // 
            // ObjCFGBox
            // 
            this.ObjCFGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjCFGBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjCFGBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ObjCFGBox.Location = new System.Drawing.Point(408, 87);
            this.ObjCFGBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjCFGBox.Name = "ObjCFGBox";
            this.ObjCFGBox.Size = new System.Drawing.Size(283, 19);
            this.ObjCFGBox.TabIndex = 69;
            this.ObjCFGBox.TextChanged += new System.EventHandler(this.ObjCFGBox_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(404, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Script Path";
            // 
            // ObjPathHashBox
            // 
            this.ObjPathHashBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjPathHashBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ObjPathHashBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ObjPathHashBox.Location = new System.Drawing.Point(407, 40);
            this.ObjPathHashBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjPathHashBox.Name = "ObjPathHashBox";
            this.ObjPathHashBox.Size = new System.Drawing.Size(284, 19);
            this.ObjPathHashBox.TabIndex = 67;
            this.ObjPathHashBox.TextChanged += new System.EventHandler(this.ObjPathBox_TextChanged);
            // 
            // DelObjButton
            // 
            this.DelObjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelObjButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelObjButton.Location = new System.Drawing.Point(408, 160);
            this.DelObjButton.Name = "DelObjButton";
            this.DelObjButton.Size = new System.Drawing.Size(284, 33);
            this.DelObjButton.TabIndex = 55;
            this.DelObjButton.Text = "Remove Object";
            this.DelObjButton.UseVisualStyleBackColor = true;
            this.DelObjButton.Click += new System.EventHandler(this.DelObjButton_Click);
            // 
            // ObjListBox
            // 
            this.ObjListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ObjListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ObjListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ObjListBox.FormattingEnabled = true;
            this.ObjListBox.Location = new System.Drawing.Point(3, 15);
            this.ObjListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ObjListBox.Name = "ObjListBox";
            this.ObjListBox.Size = new System.Drawing.Size(399, 509);
            this.ObjListBox.TabIndex = 1;
            this.ObjListBox.SelectedIndexChanged += new System.EventHandler(this.ObjListBox_SelectedIndexChanged);
            // 
            // AddObjButton
            // 
            this.AddObjButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddObjButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddObjButton.Location = new System.Drawing.Point(408, 116);
            this.AddObjButton.Name = "AddObjButton";
            this.AddObjButton.Size = new System.Drawing.Size(284, 33);
            this.AddObjButton.TabIndex = 54;
            this.AddObjButton.Text = "Add Object";
            this.AddObjButton.UseVisualStyleBackColor = true;
            this.AddObjButton.Click += new System.EventHandler(this.AddObjButton_Click);
            // 
            // SoundFXPage
            // 
            this.SoundFXPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SoundFXPage.Controls.Add(this.groupBox2);
            this.SoundFXPage.Location = new System.Drawing.Point(4, 22);
            this.SoundFXPage.Name = "SoundFXPage";
            this.SoundFXPage.Padding = new System.Windows.Forms.Padding(3);
            this.SoundFXPage.Size = new System.Drawing.Size(704, 533);
            this.SoundFXPage.TabIndex = 2;
            this.SoundFXPage.Text = "SoundFX";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox2.Controls.Add(this.SFXIDLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SFXNameBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SFXPathBox);
            this.groupBox2.Controls.Add(this.RemoveSFXButton);
            this.groupBox2.Controls.Add(this.SoundFXListBox);
            this.groupBox2.Controls.Add(this.AddSFXButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 527);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SoundFX List";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(404, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "SFX Name";
            // 
            // SFXNameBox
            // 
            this.SFXNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SFXNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SFXNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SFXNameBox.Location = new System.Drawing.Point(407, 95);
            this.SFXNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.SFXNameBox.Name = "SFXNameBox";
            this.SFXNameBox.Size = new System.Drawing.Size(283, 19);
            this.SFXNameBox.TabIndex = 71;
            this.SFXNameBox.TextChanged += new System.EventHandler(this.SFXNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(404, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "SFX Path";
            // 
            // SFXPathBox
            // 
            this.SFXPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SFXPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SFXPathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SFXPathBox.Location = new System.Drawing.Point(407, 39);
            this.SFXPathBox.Margin = new System.Windows.Forms.Padding(4);
            this.SFXPathBox.Name = "SFXPathBox";
            this.SFXPathBox.Size = new System.Drawing.Size(284, 19);
            this.SFXPathBox.TabIndex = 67;
            this.SFXPathBox.TextChanged += new System.EventHandler(this.SFXPathBox_TextChanged);
            // 
            // RemoveSFXButton
            // 
            this.RemoveSFXButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSFXButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveSFXButton.Location = new System.Drawing.Point(406, 165);
            this.RemoveSFXButton.Name = "RemoveSFXButton";
            this.RemoveSFXButton.Size = new System.Drawing.Size(283, 33);
            this.RemoveSFXButton.TabIndex = 55;
            this.RemoveSFXButton.Text = "Remove SFX";
            this.RemoveSFXButton.UseVisualStyleBackColor = true;
            this.RemoveSFXButton.Click += new System.EventHandler(this.RemoveSFXButton_Click);
            // 
            // SoundFXListBox
            // 
            this.SoundFXListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SoundFXListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SoundFXListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SoundFXListBox.FormattingEnabled = true;
            this.SoundFXListBox.Location = new System.Drawing.Point(3, 15);
            this.SoundFXListBox.Margin = new System.Windows.Forms.Padding(4);
            this.SoundFXListBox.Name = "SoundFXListBox";
            this.SoundFXListBox.Size = new System.Drawing.Size(399, 509);
            this.SoundFXListBox.TabIndex = 1;
            this.SoundFXListBox.SelectedIndexChanged += new System.EventHandler(this.SoundFXListBox_SelectedIndexChanged);
            // 
            // AddSFXButton
            // 
            this.AddSFXButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSFXButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddSFXButton.Location = new System.Drawing.Point(406, 126);
            this.AddSFXButton.Name = "AddSFXButton";
            this.AddSFXButton.Size = new System.Drawing.Size(285, 33);
            this.AddSFXButton.TabIndex = 54;
            this.AddSFXButton.Text = "Add SFX";
            this.AddSFXButton.UseVisualStyleBackColor = true;
            this.AddSFXButton.Click += new System.EventHandler(this.AddSFXButton_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_New,
            this.MenuItem_Open,
            this.MenuItem_Save,
            this.MenuItem_SaveAs});
            this.menuItem1.Text = "File";
            // 
            // MenuItem_New
            // 
            this.MenuItem_New.Index = 0;
            this.MenuItem_New.Text = "New";
            this.MenuItem_New.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Index = 1;
            this.MenuItem_Open.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.MenuItem_Open.Text = "&Open";
            this.MenuItem_Open.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Index = 2;
            this.MenuItem_Save.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.MenuItem_Save.Text = "&Save";
            this.MenuItem_Save.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MenuItem_SaveAs
            // 
            this.MenuItem_SaveAs.Index = 3;
            this.MenuItem_SaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.MenuItem_SaveAs.Text = "Save &As";
            this.MenuItem_SaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // SFXIDLabel
            // 
            this.SFXIDLabel.AutoSize = true;
            this.SFXIDLabel.Location = new System.Drawing.Point(404, 201);
            this.SFXIDLabel.Name = "SFXIDLabel";
            this.SFXIDLabel.Size = new System.Drawing.Size(53, 13);
            this.SFXIDLabel.TabIndex = 73;
            this.SFXIDLabel.Text = "SFX ID: 0";
            // 
            // ObjIDLabel
            // 
            this.ObjIDLabel.AutoSize = true;
            this.ObjIDLabel.Location = new System.Drawing.Point(406, 219);
            this.ObjIDLabel.Name = "ObjIDLabel";
            this.ObjIDLabel.Size = new System.Drawing.Size(64, 13);
            this.ObjIDLabel.TabIndex = 72;
            this.ObjIDLabel.Text = "Object ID: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(712, 559);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "RSDKv4 Stageconfig Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ObjectsPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.SoundFXPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ObjectsPage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ObjCFGBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ObjPathHashBox;
        private System.Windows.Forms.Button DelObjButton;
        private System.Windows.Forms.ListBox ObjListBox;
        private System.Windows.Forms.Button AddObjButton;
        private System.Windows.Forms.TabPage SoundFXPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SFXPathBox;
        private System.Windows.Forms.Button RemoveSFXButton;
        private System.Windows.Forms.ListBox SoundFXListBox;
        private System.Windows.Forms.Button AddSFXButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SFXNameBox;
        private System.Windows.Forms.CheckBox LoadGlobalScriptsCB;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem MenuItem_New;
        private System.Windows.Forms.MenuItem MenuItem_Open;
        private System.Windows.Forms.MenuItem MenuItem_Save;
        private System.Windows.Forms.MenuItem MenuItem_SaveAs;
        private System.Windows.Forms.Label SFXIDLabel;
        private System.Windows.Forms.Label ObjIDLabel;
    }
}

