namespace Coco
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FPSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FPSTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCanvasButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddObjectButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DelObjectButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.DelALLObjectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Objectproperty = new System.Windows.Forms.PropertyGrid();
            this.AddObjectButton2 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.DelObjectButton2 = new System.Windows.Forms.Button();
            this.ObjectListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FPSLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FPSLabel
            // 
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(38, 17);
            this.FPSLabel.Text = "FPS: 0";
            // 
            // FPSTimer
            // 
            this.FPSTimer.Enabled = true;
            this.FPSTimer.Interval = 1000;
            this.FPSTimer.Tick += new System.EventHandler(this.FPSTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveCanvasButton,
            this.toolStripMenuItem2,
            this.ExitButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem1.Text = "ファイル（F）";
            // 
            // SaveCanvasButton
            // 
            this.SaveCanvasButton.Name = "SaveCanvasButton";
            this.SaveCanvasButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveCanvasButton.Size = new System.Drawing.Size(202, 22);
            this.SaveCanvasButton.Text = "画面を保存";
            this.SaveCanvasButton.Click += new System.EventHandler(this.SaveCanvasButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitButton.Size = new System.Drawing.Size(202, 22);
            this.ExitButton.Text = "終了";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddObjectButton1,
            this.DelObjectButton1,
            this.toolStripMenuItem3,
            this.DelALLObjectButton});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ファイルFToolStripMenuItem.Text = "描画（D）";
            // 
            // AddObjectButton1
            // 
            this.AddObjectButton1.Name = "AddObjectButton1";
            this.AddObjectButton1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.AddObjectButton1.Size = new System.Drawing.Size(256, 22);
            this.AddObjectButton1.Text = "新規オブジェクトの追加";
            this.AddObjectButton1.Click += new System.EventHandler(this.AddObjectButton1_Click);
            // 
            // DelObjectButton1
            // 
            this.DelObjectButton1.Name = "DelObjectButton1";
            this.DelObjectButton1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.DelObjectButton1.Size = new System.Drawing.Size(256, 22);
            this.DelObjectButton1.Text = "選択中のオブジェクトを削除";
            this.DelObjectButton1.Click += new System.EventHandler(this.DelObjectButton1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(253, 6);
            // 
            // DelALLObjectButton
            // 
            this.DelALLObjectButton.Name = "DelALLObjectButton";
            this.DelALLObjectButton.Size = new System.Drawing.Size(256, 22);
            this.DelALLObjectButton.Text = "全てのオブジェクトを削除";
            this.DelALLObjectButton.Click += new System.EventHandler(this.DelALLObjectButton_Click);
            // 
            // Objectproperty
            // 
            this.Objectproperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Objectproperty.Location = new System.Drawing.Point(14, 313);
            this.Objectproperty.Name = "Objectproperty";
            this.Objectproperty.Size = new System.Drawing.Size(340, 192);
            this.Objectproperty.TabIndex = 0;
            this.Objectproperty.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Objectproperty_PropertyValueChanged);
            // 
            // AddObjectButton2
            // 
            this.AddObjectButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddObjectButton2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddObjectButton2.Location = new System.Drawing.Point(14, 272);
            this.AddObjectButton2.Name = "AddObjectButton2";
            this.AddObjectButton2.Size = new System.Drawing.Size(35, 35);
            this.AddObjectButton2.TabIndex = 4;
            this.AddObjectButton2.Text = "+";
            this.AddObjectButton2.UseVisualStyleBackColor = true;
            this.AddObjectButton2.Click += new System.EventHandler(this.AddObjectButton2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(10, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(695, 494);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // DelObjectButton2
            // 
            this.DelObjectButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelObjectButton2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DelObjectButton2.Location = new System.Drawing.Point(96, 272);
            this.DelObjectButton2.Name = "DelObjectButton2";
            this.DelObjectButton2.Size = new System.Drawing.Size(193, 35);
            this.DelObjectButton2.TabIndex = 4;
            this.DelObjectButton2.Text = "選択中のオブジェクトを削除";
            this.DelObjectButton2.UseVisualStyleBackColor = true;
            this.DelObjectButton2.Click += new System.EventHandler(this.DelObjectButton2_Click);
            // 
            // ObjectListView
            // 
            this.ObjectListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectListView.FullRowSelect = true;
            this.ObjectListView.GridLines = true;
            this.ObjectListView.HideSelection = false;
            this.ObjectListView.Location = new System.Drawing.Point(14, 12);
            this.ObjectListView.Name = "ObjectListView";
            this.ObjectListView.Size = new System.Drawing.Size(340, 254);
            this.ObjectListView.TabIndex = 4;
            this.ObjectListView.UseCompatibleStateImageBehavior = false;
            this.ObjectListView.View = System.Windows.Forms.View.Details;
            this.ObjectListView.SelectedIndexChanged += new System.EventHandler(this.ObjectListView_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ObjectListView);
            this.panel1.Controls.Add(this.DelObjectButton2);
            this.panel1.Controls.Add(this.Objectproperty);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddObjectButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(713, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 518);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(55, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddObjectButton2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 518);
            this.panel2.TabIndex = 7;
            // 
            // Source
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1079, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coco   |   Sakamochanq";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Source_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer FPSTimer;
        private System.Windows.Forms.ToolStripStatusLabel FPSLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddObjectButton1;
        private System.Windows.Forms.ToolStripMenuItem DelObjectButton1;
        private System.Windows.Forms.ListView ObjectListView;
        private System.Windows.Forms.Button DelObjectButton2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button AddObjectButton2;
        private System.Windows.Forms.PropertyGrid Objectproperty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem SaveCanvasButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem DelALLObjectButton;
    }
}

