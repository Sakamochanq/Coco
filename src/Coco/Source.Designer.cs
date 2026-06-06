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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddObjectButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DelObjectButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ObjectListView = new System.Windows.Forms.ListView();
            this.DelObjectButton2 = new System.Windows.Forms.Button();
            this.AddObjectButton2 = new System.Windows.Forms.Button();
            this.Objectproperty = new System.Windows.Forms.PropertyGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FPSTimer = new System.Windows.Forms.Timer(this.components);
            this.FPSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(14, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(704, 445);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddObjectButton1,
            this.DelObjectButton1});
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ObjectListView);
            this.panel1.Controls.Add(this.DelObjectButton2);
            this.panel1.Controls.Add(this.AddObjectButton2);
            this.panel1.Controls.Add(this.Objectproperty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(732, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 499);
            this.panel1.TabIndex = 2;
            // 
            // ObjectListView
            // 
            this.ObjectListView.FullRowSelect = true;
            this.ObjectListView.GridLines = true;
            this.ObjectListView.HideSelection = false;
            this.ObjectListView.Location = new System.Drawing.Point(14, 17);
            this.ObjectListView.Name = "ObjectListView";
            this.ObjectListView.Size = new System.Drawing.Size(242, 147);
            this.ObjectListView.TabIndex = 4;
            this.ObjectListView.UseCompatibleStateImageBehavior = false;
            this.ObjectListView.View = System.Windows.Forms.View.Details;
            this.ObjectListView.SelectedIndexChanged += new System.EventHandler(this.ObjectListView_SelectedIndexChanged);
            // 
            // DelObjectButton2
            // 
            this.DelObjectButton2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DelObjectButton2.Location = new System.Drawing.Point(52, 170);
            this.DelObjectButton2.Name = "DelObjectButton2";
            this.DelObjectButton2.Size = new System.Drawing.Size(168, 30);
            this.DelObjectButton2.TabIndex = 4;
            this.DelObjectButton2.Text = "選択中のオブジェクトを削除";
            this.DelObjectButton2.UseVisualStyleBackColor = true;
            this.DelObjectButton2.Click += new System.EventHandler(this.DelObjectButton2_Click);
            // 
            // AddObjectButton2
            // 
            this.AddObjectButton2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddObjectButton2.Location = new System.Drawing.Point(14, 169);
            this.AddObjectButton2.Name = "AddObjectButton2";
            this.AddObjectButton2.Size = new System.Drawing.Size(30, 30);
            this.AddObjectButton2.TabIndex = 4;
            this.AddObjectButton2.Text = "+";
            this.AddObjectButton2.UseVisualStyleBackColor = true;
            this.AddObjectButton2.Click += new System.EventHandler(this.AddObjectButton2_Click);
            // 
            // Objectproperty
            // 
            this.Objectproperty.Location = new System.Drawing.Point(14, 206);
            this.Objectproperty.Name = "Objectproperty";
            this.Objectproperty.Size = new System.Drawing.Size(242, 281);
            this.Objectproperty.TabIndex = 0;
            this.Objectproperty.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Objectproperty_PropertyValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FPSLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FPSTimer
            // 
            this.FPSTimer.Enabled = true;
            this.FPSTimer.Interval = 1000;
            this.FPSTimer.Tick += new System.EventHandler(this.FPSTimer_Tick);
            // 
            // FPSLabel
            // 
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(38, 17);
            this.FPSLabel.Text = "FPS: 0";
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 523);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coco   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddObjectButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem DelObjectButton1;
        private System.Windows.Forms.PropertyGrid Objectproperty;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button DelObjectButton2;
        private System.Windows.Forms.Button AddObjectButton2;
        private System.Windows.Forms.ListView ObjectListView;
        private System.Windows.Forms.Timer FPSTimer;
        private System.Windows.Forms.ToolStripStatusLabel FPSLabel;
    }
}

