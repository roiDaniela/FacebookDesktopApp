namespace B16_Ex01_Roi_302882527_Iris_30580715
{
    partial class Facebook
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
               this.buttonLogin = new System.Windows.Forms.Button();
               this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.contextMenuStripAddChekin = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.addChekinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.removeChekinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.buttonRate = new System.Windows.Forms.Button();
               this.checkedListBoxParametersToRateFriends = new System.Windows.Forms.CheckedListBox();
               this.textBoxChooseParametersToRate = new System.Windows.Forms.TextBox();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.tabPage2 = new System.Windows.Forms.TabPage();
               this.splitContainer1 = new System.Windows.Forms.SplitContainer();
               this.buttonMinusZoom = new System.Windows.Forms.Button();
               this.buttonPlusZoom = new System.Windows.Forms.Button();
               this.gmap = new GMap.NET.WindowsForms.GMapControl();
               this.splitContainer2 = new System.Windows.Forms.SplitContainer();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.webBrowser2 = new System.Windows.Forms.WebBrowser();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.textBoxNoRateParametersSelected = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
               this.tabControl1.SuspendLayout();
               this.contextMenuStripAddChekin.SuspendLayout();
               this.tabPage1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.tabPage2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
               this.splitContainer1.Panel1.SuspendLayout();
               this.splitContainer1.Panel2.SuspendLayout();
               this.splitContainer1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
               this.splitContainer2.Panel1.SuspendLayout();
               this.splitContainer2.Panel2.SuspendLayout();
               this.splitContainer2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonLogin
               // 
               this.buttonLogin.Location = new System.Drawing.Point(6, 6);
               this.buttonLogin.Name = "buttonLogin";
               this.buttonLogin.Size = new System.Drawing.Size(75, 23);
               this.buttonLogin.TabIndex = 0;
               this.buttonLogin.Text = "Login";
               this.buttonLogin.UseVisualStyleBackColor = true;
               this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
               // 
               // picture_smallPictureBox
               // 
               this.picture_smallPictureBox.Location = new System.Drawing.Point(6, 35);
               this.picture_smallPictureBox.Name = "picture_smallPictureBox";
               this.picture_smallPictureBox.Size = new System.Drawing.Size(114, 108);
               this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.picture_smallPictureBox.TabIndex = 47;
               this.picture_smallPictureBox.TabStop = false;
               // 
               // tabControl1
               // 
               this.tabControl1.ContextMenuStrip = this.contextMenuStripAddChekin;
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Controls.Add(this.tabPage2);
               this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tabControl1.Location = new System.Drawing.Point(0, 0);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(745, 327);
               this.tabControl1.TabIndex = 48;
               // 
               // contextMenuStripAddChekin
               // 
               this.contextMenuStripAddChekin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChekinToolStripMenuItem,
            this.removeChekinToolStripMenuItem});
               this.contextMenuStripAddChekin.Name = "contextMenuStripAddChekin";
               this.contextMenuStripAddChekin.Size = new System.Drawing.Size(153, 48);
               // 
               // addChekinToolStripMenuItem
               // 
               this.addChekinToolStripMenuItem.Name = "addChekinToolStripMenuItem";
               this.addChekinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.addChekinToolStripMenuItem.Text = "add chekin";
               this.addChekinToolStripMenuItem.Click += new System.EventHandler(this.addChekinToolStripMenuItem_Click);
               // 
               // removeChekinToolStripMenuItem
               // 
               this.removeChekinToolStripMenuItem.Enabled = false;
               this.removeChekinToolStripMenuItem.Name = "removeChekinToolStripMenuItem";
               this.removeChekinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
               this.removeChekinToolStripMenuItem.Text = "remove chekin";
               this.removeChekinToolStripMenuItem.Click += new System.EventHandler(this.removeChekinToolStripMenuItem_Click);
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.textBoxNoRateParametersSelected);
               this.tabPage1.Controls.Add(this.buttonRate);
               this.tabPage1.Controls.Add(this.checkedListBoxParametersToRateFriends);
               this.tabPage1.Controls.Add(this.textBoxChooseParametersToRate);
               this.tabPage1.Controls.Add(this.pictureBox4);
               this.tabPage1.Controls.Add(this.pictureBox3);
               this.tabPage1.Controls.Add(this.pictureBox2);
               this.tabPage1.Controls.Add(this.pictureBox1);
               this.tabPage1.Controls.Add(this.buttonLogin);
               this.tabPage1.Controls.Add(this.picture_smallPictureBox);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(737, 301);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "Rate Your Friends";
               this.tabPage1.UseVisualStyleBackColor = true;
               this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
               // 
               // buttonRate
               // 
               this.buttonRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
               this.buttonRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.buttonRate.Location = new System.Drawing.Point(654, 34);
               this.buttonRate.Name = "buttonRate";
               this.buttonRate.Size = new System.Drawing.Size(75, 23);
               this.buttonRate.TabIndex = 54;
               this.buttonRate.Text = "Rate!";
               this.buttonRate.UseVisualStyleBackColor = false;
               this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
               // 
               // checkedListBoxParametersToRateFriends
               // 
               this.checkedListBoxParametersToRateFriends.CheckOnClick = true;
               this.checkedListBoxParametersToRateFriends.FormattingEnabled = true;
               this.checkedListBoxParametersToRateFriends.Items.AddRange(new object[] {
            "Shared Photos",
            "Shared Events",
            "Shared Check-Ins",
            "Shared Liked Pages",
            "Liked My Photos",
            "Commented On My Photos",
            "Liked My Posts",
            "Commented On My Posts"});
               this.checkedListBoxParametersToRateFriends.Location = new System.Drawing.Point(468, 35);
               this.checkedListBoxParametersToRateFriends.Name = "checkedListBoxParametersToRateFriends";
               this.checkedListBoxParametersToRateFriends.Size = new System.Drawing.Size(170, 94);
               this.checkedListBoxParametersToRateFriends.TabIndex = 53;
               // 
               // textBoxChooseParametersToRate
               // 
               this.textBoxChooseParametersToRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxChooseParametersToRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.textBoxChooseParametersToRate.Location = new System.Drawing.Point(184, 35);
               this.textBoxChooseParametersToRate.Name = "textBoxChooseParametersToRate";
               this.textBoxChooseParametersToRate.Size = new System.Drawing.Size(265, 22);
               this.textBoxChooseParametersToRate.TabIndex = 52;
               this.textBoxChooseParametersToRate.Text = "Choose Parameters To Rate Your Friends:";
               this.textBoxChooseParametersToRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // pictureBox4
               // 
               this.pictureBox4.Location = new System.Drawing.Point(533, 212);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(72, 59);
               this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox4.TabIndex = 51;
               this.pictureBox4.TabStop = false;
               // 
               // pictureBox3
               // 
               this.pictureBox3.Location = new System.Drawing.Point(432, 197);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(84, 74);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox3.TabIndex = 50;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.Location = new System.Drawing.Point(316, 177);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(100, 94);
               this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox2.TabIndex = 49;
               this.pictureBox2.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(184, 163);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(114, 108);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 48;
               this.pictureBox1.TabStop = false;
               // 
               // tabPage2
               // 
               this.tabPage2.Controls.Add(this.splitContainer1);
               this.tabPage2.Location = new System.Drawing.Point(4, 22);
               this.tabPage2.Name = "tabPage2";
               this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage2.Size = new System.Drawing.Size(737, 301);
               this.tabPage2.TabIndex = 1;
               this.tabPage2.Text = "Show Check-Ins";
               this.tabPage2.UseVisualStyleBackColor = true;
               // 
               // splitContainer1
               // 
               this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer1.Location = new System.Drawing.Point(3, 3);
               this.splitContainer1.Name = "splitContainer1";
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.Controls.Add(this.buttonMinusZoom);
               this.splitContainer1.Panel1.Controls.Add(this.buttonPlusZoom);
               this.splitContainer1.Panel1.Controls.Add(this.gmap);
               // 
               // splitContainer1.Panel2
               // 
               this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
               this.splitContainer1.Size = new System.Drawing.Size(731, 295);
               this.splitContainer1.SplitterDistance = 484;
               this.splitContainer1.TabIndex = 1;
               // 
               // buttonMinusZoom
               // 
               this.buttonMinusZoom.Location = new System.Drawing.Point(0, 29);
               this.buttonMinusZoom.Name = "buttonMinusZoom";
               this.buttonMinusZoom.Size = new System.Drawing.Size(42, 23);
               this.buttonMinusZoom.TabIndex = 2;
               this.buttonMinusZoom.Text = "-";
               this.buttonMinusZoom.UseVisualStyleBackColor = true;
               this.buttonMinusZoom.Click += new System.EventHandler(this.buttonMinusZoom_Click);
               // 
               // buttonPlusZoom
               // 
               this.buttonPlusZoom.Location = new System.Drawing.Point(0, 0);
               this.buttonPlusZoom.Name = "buttonPlusZoom";
               this.buttonPlusZoom.Size = new System.Drawing.Size(42, 23);
               this.buttonPlusZoom.TabIndex = 1;
               this.buttonPlusZoom.Text = "+";
               this.buttonPlusZoom.UseVisualStyleBackColor = true;
               this.buttonPlusZoom.Click += new System.EventHandler(this.buttonPlusZoom_Click);
               // 
               // gmap
               // 
               this.gmap.Bearing = 0F;
               this.gmap.CanDragMap = true;
               this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
               this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
               this.gmap.GrayScaleMode = false;
               this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
               this.gmap.LevelsKeepInMemmory = 5;
               this.gmap.Location = new System.Drawing.Point(0, 0);
               this.gmap.MarkersEnabled = true;
               this.gmap.MaxZoom = 18;
               this.gmap.MinZoom = 2;
               this.gmap.MouseWheelZoomEnabled = true;
               this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
               this.gmap.Name = "gmap";
               this.gmap.NegativeMode = false;
               this.gmap.PolygonsEnabled = true;
               this.gmap.RetryLoadTile = 0;
               this.gmap.RoutesEnabled = true;
               this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
               this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
               this.gmap.ShowTileGridLines = false;
               this.gmap.Size = new System.Drawing.Size(484, 295);
               this.gmap.TabIndex = 0;
               this.gmap.Zoom = 2D;
               this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
               this.gmap.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gmap_OnMarkerEnter);
               this.gmap.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gmap_OnMarkerLeave);
               this.gmap.Load += new System.EventHandler(this.gmap_Load);
               this.gmap.MouseHover += new System.EventHandler(this.gmap_MouseHover);
               // 
               // splitContainer2
               // 
               this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer2.Location = new System.Drawing.Point(0, 0);
               this.splitContainer2.Name = "splitContainer2";
               this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
               // 
               // splitContainer2.Panel1
               // 
               this.splitContainer2.Panel1.Controls.Add(this.webBrowser1);
               this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
               // 
               // splitContainer2.Panel2
               // 
               this.splitContainer2.Panel2.Controls.Add(this.webBrowser2);
               this.splitContainer2.Size = new System.Drawing.Size(243, 295);
               this.splitContainer2.SplitterDistance = 100;
               this.splitContainer2.TabIndex = 0;
               // 
               // webBrowser1
               // 
               this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser1.Location = new System.Drawing.Point(0, 0);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(243, 100);
               this.webBrowser1.TabIndex = 0;
               // 
               // webBrowser2
               // 
               this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser2.Location = new System.Drawing.Point(0, 0);
               this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser2.Name = "webBrowser2";
               this.webBrowser2.ScriptErrorsSuppressed = true;
               this.webBrowser2.Size = new System.Drawing.Size(243, 191);
               this.webBrowser2.TabIndex = 0;
               // 
               // errorProvider1
               // 
               this.errorProvider1.ContainerControl = this;
               // 
               // textBoxNoRateParametersSelected
               // 
               this.textBoxNoRateParametersSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.textBoxNoRateParametersSelected.ForeColor = System.Drawing.Color.Red;
               this.textBoxNoRateParametersSelected.Location = new System.Drawing.Point(288, 78);
               this.textBoxNoRateParametersSelected.Name = "textBoxNoRateParametersSelected";
               this.textBoxNoRateParametersSelected.ReadOnly = true;
               this.textBoxNoRateParametersSelected.Size = new System.Drawing.Size(174, 20);
               this.textBoxNoRateParametersSelected.TabIndex = 55;
               this.textBoxNoRateParametersSelected.Text = "Please select parameters ->";
               this.textBoxNoRateParametersSelected.Visible = false;
               this.textBoxNoRateParametersSelected.TextChanged += new System.EventHandler(this.textBoxNoRateParametersSelected_TextChanged);
               // 
               // Facebook
               // 
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(745, 327);
               this.Controls.Add(this.tabControl1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Name = "Facebook";
               this.Text = "Facebook Desktop App";
               ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
               this.tabControl1.ResumeLayout(false);
               this.contextMenuStripAddChekin.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.tabPage1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.tabPage2.ResumeLayout(false);
               this.splitContainer1.Panel1.ResumeLayout(false);
               this.splitContainer1.Panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
               this.splitContainer1.ResumeLayout(false);
               this.splitContainer2.Panel1.ResumeLayout(false);
               this.splitContainer2.Panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
               this.splitContainer2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxChooseParametersToRate;
        private System.Windows.Forms.CheckedListBox checkedListBoxParametersToRateFriends;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Button buttonMinusZoom;
        private System.Windows.Forms.Button buttonPlusZoom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAddChekin;
        private System.Windows.Forms.ToolStripMenuItem addChekinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeChekinToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxNoRateParametersSelected;
    }
}
