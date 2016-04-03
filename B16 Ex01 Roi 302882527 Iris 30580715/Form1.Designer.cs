using System.Windows.Forms;
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
               this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.ToolStripMenuItemshowDetails = new System.Windows.Forms.ToolStripMenuItem();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.textBoxPleaseLogin = new System.Windows.Forms.TextBox();
               this.checkBoxCheckAll = new System.Windows.Forms.CheckBox();
               this.textBoxNoRateParametersSelected = new System.Windows.Forms.TextBox();
               this.buttonRate = new System.Windows.Forms.Button();
               this.checkedListBoxParametersToRateFriends = new System.Windows.Forms.CheckedListBox();
               this.textBoxChooseParametersToRate = new System.Windows.Forms.TextBox();
               this.pictureBoxFriendNo4 = new System.Windows.Forms.PictureBox();
               this.pictureBoxFriendNo3 = new System.Windows.Forms.PictureBox();
               this.pictureBoxFriendNo2 = new System.Windows.Forms.PictureBox();
               this.pictureBoxFriendNo1 = new System.Windows.Forms.PictureBox();
               this.tabPage2 = new System.Windows.Forms.TabPage();
               this.splitContainer1 = new System.Windows.Forms.SplitContainer();
               this.buttonFriendCheckin = new System.Windows.Forms.Button();
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.labelToDate = new System.Windows.Forms.Label();
               this.labelFromDate = new System.Windows.Forms.Label();
               this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
               this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
               this.buttonMinusZoom = new System.Windows.Forms.Button();
               this.buttonPlusZoom = new System.Windows.Forms.Button();
               this.gmap = new GMap.NET.WindowsForms.GMapControl();
               this.splitContainer2 = new System.Windows.Forms.SplitContainer();
               this.webBrowserGooglecheckin = new System.Windows.Forms.WebBrowser();
               this.richTextBox1 = new System.Windows.Forms.RichTextBox();
               this.richTextBoxCheckinDetails = new System.Windows.Forms.RichTextBox();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.messageQueue1 = new System.Messaging.MessageQueue();
               this.textBoxFriendNo1 = new System.Windows.Forms.TextBox();
               this.textBoxFriendNo2 = new System.Windows.Forms.TextBox();
               this.textBoxFriendNo3 = new System.Windows.Forms.TextBox();
               this.textBoxFriendNo4 = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
               this.tabControl1.SuspendLayout();
               this.contextMenuStripMap.SuspendLayout();
               this.tabPage1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo1)).BeginInit();
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
               this.picture_smallPictureBox.Size = new System.Drawing.Size(125, 140);
               this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.picture_smallPictureBox.TabIndex = 47;
               this.picture_smallPictureBox.TabStop = false;
               // 
               // tabControl1
               // 
               this.tabControl1.ContextMenuStrip = this.contextMenuStripMap;
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Controls.Add(this.tabPage2);
               this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tabControl1.Location = new System.Drawing.Point(0, 0);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(745, 327);
               this.tabControl1.TabIndex = 48;
               this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
               // 
               // contextMenuStripMap
               // 
               this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemshowDetails});
               this.contextMenuStripMap.Name = "contextMenuStripAddChekin";
               this.contextMenuStripMap.Size = new System.Drawing.Size(140, 26);
               // 
               // ToolStripMenuItemshowDetails
               // 
               this.ToolStripMenuItemshowDetails.Name = "ToolStripMenuItemshowDetails";
               this.ToolStripMenuItemshowDetails.Size = new System.Drawing.Size(139, 22);
               this.ToolStripMenuItemshowDetails.Text = "show details";
               // 
               // tabPage1
               // 
               this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
               this.tabPage1.Controls.Add(this.textBoxFriendNo4);
               this.tabPage1.Controls.Add(this.textBoxFriendNo3);
               this.tabPage1.Controls.Add(this.textBoxFriendNo2);
               this.tabPage1.Controls.Add(this.textBoxFriendNo1);
               this.tabPage1.Controls.Add(this.textBoxPleaseLogin);
               this.tabPage1.Controls.Add(this.checkBoxCheckAll);
               this.tabPage1.Controls.Add(this.textBoxNoRateParametersSelected);
               this.tabPage1.Controls.Add(this.buttonRate);
               this.tabPage1.Controls.Add(this.checkedListBoxParametersToRateFriends);
               this.tabPage1.Controls.Add(this.textBoxChooseParametersToRate);
               this.tabPage1.Controls.Add(this.pictureBoxFriendNo4);
               this.tabPage1.Controls.Add(this.pictureBoxFriendNo3);
               this.tabPage1.Controls.Add(this.pictureBoxFriendNo2);
               this.tabPage1.Controls.Add(this.pictureBoxFriendNo1);
               this.tabPage1.Controls.Add(this.buttonLogin);
               this.tabPage1.Controls.Add(this.picture_smallPictureBox);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(737, 301);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "Rate Your Friends";
               this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
               // 
               // textBoxPleaseLogin
               // 
               this.textBoxPleaseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxPleaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.textBoxPleaseLogin.ForeColor = System.Drawing.Color.Black;
               this.textBoxPleaseLogin.Location = new System.Drawing.Point(94, 8);
               this.textBoxPleaseLogin.Name = "textBoxPleaseLogin";
               this.textBoxPleaseLogin.ReadOnly = true;
               this.textBoxPleaseLogin.Size = new System.Drawing.Size(133, 22);
               this.textBoxPleaseLogin.TabIndex = 57;
               this.textBoxPleaseLogin.Text = "<- Please login first";
               this.textBoxPleaseLogin.Visible = false;
               // 
               // checkBoxCheckAll
               // 
               this.checkBoxCheckAll.AutoSize = true;
               this.checkBoxCheckAll.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.checkBoxCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.checkBoxCheckAll.Location = new System.Drawing.Point(470, 15);
               this.checkBoxCheckAll.Name = "checkBoxCheckAll";
               this.checkBoxCheckAll.Size = new System.Drawing.Size(80, 17);
               this.checkBoxCheckAll.TabIndex = 56;
               this.checkBoxCheckAll.Text = "Check All";
               this.checkBoxCheckAll.UseVisualStyleBackColor = true;
               this.checkBoxCheckAll.CheckedChanged += new System.EventHandler(this.checkBoxCheckAll_CheckedChanged);
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
               this.textBoxChooseParametersToRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxChooseParametersToRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.textBoxChooseParametersToRate.Location = new System.Drawing.Point(184, 35);
               this.textBoxChooseParametersToRate.Name = "textBoxChooseParametersToRate";
               this.textBoxChooseParametersToRate.Size = new System.Drawing.Size(265, 22);
               this.textBoxChooseParametersToRate.TabIndex = 52;
               this.textBoxChooseParametersToRate.Text = "Choose Parameters To Rate Your Friends:";
               this.textBoxChooseParametersToRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // pictureBoxFriendNo4
               // 
               this.pictureBoxFriendNo4.Location = new System.Drawing.Point(602, 226);
               this.pictureBoxFriendNo4.Name = "pictureBoxFriendNo4";
               this.pictureBoxFriendNo4.Size = new System.Drawing.Size(72, 59);
               this.pictureBoxFriendNo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxFriendNo4.TabIndex = 51;
               this.pictureBoxFriendNo4.TabStop = false;
               this.pictureBoxFriendNo4.Click += new System.EventHandler(this.pictureBox4_Click);
               // 
               // pictureBoxFriendNo3
               // 
               this.pictureBoxFriendNo3.Location = new System.Drawing.Point(470, 211);
               this.pictureBoxFriendNo3.Name = "pictureBoxFriendNo3";
               this.pictureBoxFriendNo3.Size = new System.Drawing.Size(84, 74);
               this.pictureBoxFriendNo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxFriendNo3.TabIndex = 50;
               this.pictureBoxFriendNo3.TabStop = false;
               // 
               // pictureBoxFriendNo2
               // 
               this.pictureBoxFriendNo2.Location = new System.Drawing.Point(334, 191);
               this.pictureBoxFriendNo2.Name = "pictureBoxFriendNo2";
               this.pictureBoxFriendNo2.Size = new System.Drawing.Size(100, 94);
               this.pictureBoxFriendNo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxFriendNo2.TabIndex = 49;
               this.pictureBoxFriendNo2.TabStop = false;
               // 
               // pictureBoxFriendNo1
               // 
               this.pictureBoxFriendNo1.Location = new System.Drawing.Point(184, 177);
               this.pictureBoxFriendNo1.Name = "pictureBoxFriendNo1";
               this.pictureBoxFriendNo1.Size = new System.Drawing.Size(114, 108);
               this.pictureBoxFriendNo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxFriendNo1.TabIndex = 48;
               this.pictureBoxFriendNo1.TabStop = false;
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
               this.splitContainer1.Panel1.Controls.Add(this.buttonFriendCheckin);
               this.splitContainer1.Panel1.Controls.Add(this.listBoxFriends);
               this.splitContainer1.Panel1.Controls.Add(this.labelToDate);
               this.splitContainer1.Panel1.Controls.Add(this.labelFromDate);
               this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerTo);
               this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerFrom);
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
               // buttonFriendCheckin
               // 
               this.buttonFriendCheckin.Location = new System.Drawing.Point(0, 147);
               this.buttonFriendCheckin.Name = "buttonFriendCheckin";
               this.buttonFriendCheckin.Size = new System.Drawing.Size(110, 23);
               this.buttonFriendCheckin.TabIndex = 7;
               this.buttonFriendCheckin.Text = "friend checkin";
               this.buttonFriendCheckin.UseVisualStyleBackColor = true;
               this.buttonFriendCheckin.Click += new System.EventHandler(this.buttonFriendCheckin_Click);
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.FormattingEnabled = true;
               this.listBoxFriends.Location = new System.Drawing.Point(0, 107);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.ScrollAlwaysVisible = true;
               this.listBoxFriends.Size = new System.Drawing.Size(110, 30);
               this.listBoxFriends.TabIndex = 2;
               // 
               // labelToDate
               // 
               this.labelToDate.AutoSize = true;
               this.labelToDate.Location = new System.Drawing.Point(-3, 79);
               this.labelToDate.Name = "labelToDate";
               this.labelToDate.Size = new System.Drawing.Size(26, 13);
               this.labelToDate.TabIndex = 6;
               this.labelToDate.Text = "To: ";
               // 
               // labelFromDate
               // 
               this.labelFromDate.AutoSize = true;
               this.labelFromDate.Location = new System.Drawing.Point(0, 55);
               this.labelFromDate.Name = "labelFromDate";
               this.labelFromDate.Size = new System.Drawing.Size(33, 13);
               this.labelFromDate.TabIndex = 5;
               this.labelFromDate.Text = "From:";
               // 
               // dateTimePickerTo
               // 
               this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dateTimePickerTo.Location = new System.Drawing.Point(30, 81);
               this.dateTimePickerTo.Name = "dateTimePickerTo";
               this.dateTimePickerTo.Size = new System.Drawing.Size(80, 20);
               this.dateTimePickerTo.TabIndex = 4;
               this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
               // 
               // dateTimePickerFrom
               // 
               this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dateTimePickerFrom.Location = new System.Drawing.Point(30, 55);
               this.dateTimePickerFrom.Name = "dateTimePickerFrom";
               this.dateTimePickerFrom.Size = new System.Drawing.Size(80, 20);
               this.dateTimePickerFrom.TabIndex = 3;
               this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
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
               this.splitContainer2.Panel1.Controls.Add(this.webBrowserGooglecheckin);
               this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
               // 
               // splitContainer2.Panel2
               // 
               this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
               this.splitContainer2.Panel2.Controls.Add(this.richTextBoxCheckinDetails);
               this.splitContainer2.Size = new System.Drawing.Size(243, 295);
               this.splitContainer2.SplitterDistance = 171;
               this.splitContainer2.TabIndex = 0;
               // 
               // webBrowserGooglecheckin
               // 
               this.webBrowserGooglecheckin.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowserGooglecheckin.Location = new System.Drawing.Point(0, 0);
               this.webBrowserGooglecheckin.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowserGooglecheckin.Name = "webBrowserGooglecheckin";
               this.webBrowserGooglecheckin.Size = new System.Drawing.Size(243, 171);
               this.webBrowserGooglecheckin.TabIndex = 0;
               // 
               // richTextBox1
               // 
               this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.richTextBox1.Location = new System.Drawing.Point(0, 3);
               this.richTextBox1.Name = "richTextBox1";
               this.richTextBox1.Size = new System.Drawing.Size(243, 66);
               this.richTextBox1.TabIndex = 1;
               this.richTextBox1.Text = "";
               // 
               // richTextBoxCheckinDetails
               // 
               this.richTextBoxCheckinDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.richTextBoxCheckinDetails.Location = new System.Drawing.Point(0, 66);
               this.richTextBoxCheckinDetails.Name = "richTextBoxCheckinDetails";
               this.richTextBoxCheckinDetails.Size = new System.Drawing.Size(243, 57);
               this.richTextBoxCheckinDetails.TabIndex = 0;
               this.richTextBoxCheckinDetails.Text = "";
               // 
               // errorProvider1
               // 
               this.errorProvider1.ContainerControl = this;
               // 
               // messageQueue1
               // 
               this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
               this.messageQueue1.SynchronizingObject = this;
               // 
               // textBoxFriendNo1
               // 
               this.textBoxFriendNo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxFriendNo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBoxFriendNo1.Location = new System.Drawing.Point(206, 272);
               this.textBoxFriendNo1.Name = "textBoxFriendNo1";
               this.textBoxFriendNo1.Size = new System.Drawing.Size(69, 23);
               this.textBoxFriendNo1.TabIndex = 58;
               this.textBoxFriendNo1.Text = "Friend #1";
               this.textBoxFriendNo1.Visible = false;
               this.textBoxFriendNo1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
               // 
               // textBoxFriendNo2
               // 
               this.textBoxFriendNo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxFriendNo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBoxFriendNo2.Location = new System.Drawing.Point(350, 270);
               this.textBoxFriendNo2.Name = "textBoxFriendNo2";
               this.textBoxFriendNo2.Size = new System.Drawing.Size(69, 23);
               this.textBoxFriendNo2.TabIndex = 59;
               this.textBoxFriendNo2.Text = "Friend #2";
               this.textBoxFriendNo2.Visible = false;
               // 
               // textBoxFriendNo3
               // 
               this.textBoxFriendNo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxFriendNo3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBoxFriendNo3.Location = new System.Drawing.Point(477, 270);
               this.textBoxFriendNo3.Name = "textBoxFriendNo3";
               this.textBoxFriendNo3.Size = new System.Drawing.Size(69, 23);
               this.textBoxFriendNo3.TabIndex = 60;
               this.textBoxFriendNo3.Text = "Friend #3";
               this.textBoxFriendNo3.Visible = false;
               // 
               // textBoxFriendNo4
               // 
               this.textBoxFriendNo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.textBoxFriendNo4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBoxFriendNo4.Location = new System.Drawing.Point(603, 270);
               this.textBoxFriendNo4.Name = "textBoxFriendNo4";
               this.textBoxFriendNo4.Size = new System.Drawing.Size(69, 23);
               this.textBoxFriendNo4.TabIndex = 61;
               this.textBoxFriendNo4.Text = "Friend #4";
               this.textBoxFriendNo4.Visible = false;
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
               this.Load += new System.EventHandler(this.Facebook_Load);
               ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
               this.tabControl1.ResumeLayout(false);
               this.contextMenuStripMap.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.tabPage1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendNo1)).EndInit();
               this.tabPage2.ResumeLayout(false);
               this.splitContainer1.Panel1.ResumeLayout(false);
               this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.WebBrowser webBrowserGooglecheckin;
        private System.Windows.Forms.PictureBox pictureBoxFriendNo3;
        private System.Windows.Forms.PictureBox pictureBoxFriendNo2;
        private System.Windows.Forms.PictureBox pictureBoxFriendNo1;
        private System.Windows.Forms.PictureBox pictureBoxFriendNo4;
        private System.Windows.Forms.TextBox textBoxChooseParametersToRate;
        private System.Windows.Forms.CheckedListBox checkedListBoxParametersToRateFriends;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Button buttonMinusZoom;
        private System.Windows.Forms.Button buttonPlusZoom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemshowDetails;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxNoRateParametersSelected;
        private RichTextBox richTextBoxCheckinDetails;
        private Label labelToDate;
        private Label labelFromDate;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private RichTextBox richTextBox1;
        private ListBox listBoxFriends;
        private Button buttonFriendCheckin;
        private CheckBox checkBoxCheckAll;
        private TextBox textBoxPleaseLogin;
        private System.Messaging.MessageQueue messageQueue1;
        private TextBox textBoxFriendNo1;
        private TextBox textBoxFriendNo4;
        private TextBox textBoxFriendNo3;
        private TextBox textBoxFriendNo2;
    }
}
