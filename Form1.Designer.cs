namespace TheBesterMusicApp
{
    partial class Form1
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
            this.tab_Page_Select = new System.Windows.Forms.TabControl();
            this.tp_Tracks = new System.Windows.Forms.TabPage();
            this.lv_Tracks_Track_List = new System.Windows.Forms.ListView();
            this.Tracks_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tracks_Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tracks_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tracks_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Track_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Albums = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lv_Albums_Album_List = new System.Windows.Forms.ListView();
            this.il_Album_Covers = new System.Windows.Forms.ImageList(this.components);
            this.lv_Albums_Track_List = new System.Windows.Forms.ListView();
            this.Albums_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Artists = new System.Windows.Forms.TabPage();
            this.lv_Artists_Artist_List = new System.Windows.Forms.ListView();
            this.lv_Artists_Track_List = new System.Windows.Forms.ListView();
            this.Artists_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artists_Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artists_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artists_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artists_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Playlists = new System.Windows.Forms.TabPage();
            this.pnl_Song_Control = new System.Windows.Forms.Panel();
            this.btn_Control_Mode_Change = new System.Windows.Forms.Button();
            this.btn_Control_Next_Button = new System.Windows.Forms.Button();
            this.btn_Control_Previous_Button = new System.Windows.Forms.Button();
            this.btn_Control_Play_Button = new System.Windows.Forms.Button();
            this.lbl_Control_Track_Duration = new System.Windows.Forms.Label();
            this.lbl_Control_Artist_Name = new System.Windows.Forms.Label();
            this.lbl_Control_Album_Name = new System.Windows.Forms.Label();
            this.lbl_Control_Track_Name = new System.Windows.Forms.Label();
            this.tkb_Control_Time_Bar = new System.Windows.Forms.TrackBar();
            this.pic_Control_Album_Cover = new System.Windows.Forms.PictureBox();
            this.tmr_Track_Timer = new System.Windows.Forms.Timer(this.components);
            this.tab_Page_Select.SuspendLayout();
            this.tp_Tracks.SuspendLayout();
            this.tp_Albums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tp_Artists.SuspendLayout();
            this.pnl_Song_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Control_Time_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Control_Album_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Page_Select
            // 
            this.tab_Page_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Page_Select.Controls.Add(this.tp_Tracks);
            this.tab_Page_Select.Controls.Add(this.tp_Albums);
            this.tab_Page_Select.Controls.Add(this.tp_Artists);
            this.tab_Page_Select.Controls.Add(this.tp_Playlists);
            this.tab_Page_Select.Cursor = System.Windows.Forms.Cursors.Default;
            this.tab_Page_Select.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Page_Select.Location = new System.Drawing.Point(1, 0);
            this.tab_Page_Select.Name = "tab_Page_Select";
            this.tab_Page_Select.SelectedIndex = 0;
            this.tab_Page_Select.Size = new System.Drawing.Size(858, 341);
            this.tab_Page_Select.TabIndex = 0;
            this.tab_Page_Select.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Page_Select_TabIndexChanged);
            // 
            // tp_Tracks
            // 
            this.tp_Tracks.BackColor = System.Drawing.Color.LightBlue;
            this.tp_Tracks.Controls.Add(this.lv_Tracks_Track_List);
            this.tp_Tracks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_Tracks.Location = new System.Drawing.Point(4, 26);
            this.tp_Tracks.Name = "tp_Tracks";
            this.tp_Tracks.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Tracks.Size = new System.Drawing.Size(850, 311);
            this.tp_Tracks.TabIndex = 0;
            this.tp_Tracks.Text = "Tracks";
            // 
            // lv_Tracks_Track_List
            // 
            this.lv_Tracks_Track_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Tracks_Track_List.BackColor = System.Drawing.Color.LightBlue;
            this.lv_Tracks_Track_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Tracks_Track_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tracks_No,
            this.Tracks_Track,
            this.Tracks_Album,
            this.Tracks_Artist,
            this.Track_Time});
            this.lv_Tracks_Track_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_Tracks_Track_List.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_Tracks_Track_List.FullRowSelect = true;
            this.lv_Tracks_Track_List.HideSelection = false;
            this.lv_Tracks_Track_List.Location = new System.Drawing.Point(7, 6);
            this.lv_Tracks_Track_List.MultiSelect = false;
            this.lv_Tracks_Track_List.Name = "lv_Tracks_Track_List";
            this.lv_Tracks_Track_List.Size = new System.Drawing.Size(837, 299);
            this.lv_Tracks_Track_List.TabIndex = 0;
            this.lv_Tracks_Track_List.UseCompatibleStateImageBehavior = false;
            this.lv_Tracks_Track_List.View = System.Windows.Forms.View.Details;
            this.lv_Tracks_Track_List.DoubleClick += new System.EventHandler(this.Track_List_DoubleClick);
            // 
            // Tracks_No
            // 
            this.Tracks_No.Text = "#";
            this.Tracks_No.Width = 25;
            // 
            // Tracks_Track
            // 
            this.Tracks_Track.Text = "Track";
            this.Tracks_Track.Width = 250;
            // 
            // Tracks_Album
            // 
            this.Tracks_Album.Text = "Album";
            this.Tracks_Album.Width = 150;
            // 
            // Tracks_Artist
            // 
            this.Tracks_Artist.Text = "Artist";
            this.Tracks_Artist.Width = 150;
            // 
            // Track_Time
            // 
            this.Track_Time.Text = "Length";
            this.Track_Time.Width = 61;
            // 
            // tp_Albums
            // 
            this.tp_Albums.BackColor = System.Drawing.Color.LightBlue;
            this.tp_Albums.Controls.Add(this.pictureBox1);
            this.tp_Albums.Controls.Add(this.lv_Albums_Album_List);
            this.tp_Albums.Controls.Add(this.lv_Albums_Track_List);
            this.tp_Albums.Location = new System.Drawing.Point(4, 26);
            this.tp_Albums.Name = "tp_Albums";
            this.tp_Albums.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Albums.Size = new System.Drawing.Size(850, 311);
            this.tp_Albums.TabIndex = 1;
            this.tp_Albums.Text = "Albums";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::TheBesterMusicApp.Properties.Resources.rect;
            this.pictureBox1.Location = new System.Drawing.Point(837, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lv_Albums_Album_List
            // 
            this.lv_Albums_Album_List.AutoArrange = false;
            this.lv_Albums_Album_List.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lv_Albums_Album_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Albums_Album_List.FullRowSelect = true;
            this.lv_Albums_Album_List.HideSelection = false;
            this.lv_Albums_Album_List.LargeImageList = this.il_Album_Covers;
            this.lv_Albums_Album_List.Location = new System.Drawing.Point(7, 6);
            this.lv_Albums_Album_List.Name = "lv_Albums_Album_List";
            this.lv_Albums_Album_List.Size = new System.Drawing.Size(174, 299);
            this.lv_Albums_Album_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_Albums_Album_List.TabIndex = 3;
            this.lv_Albums_Album_List.UseCompatibleStateImageBehavior = false;
            this.lv_Albums_Album_List.DoubleClick += new System.EventHandler(this.lv_Albums_Album_List_DoubleClick);
            // 
            // il_Album_Covers
            // 
            this.il_Album_Covers.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.il_Album_Covers.ImageSize = new System.Drawing.Size(100, 100);
            this.il_Album_Covers.TransparentColor = System.Drawing.Color.Black;
            // 
            // lv_Albums_Track_List
            // 
            this.lv_Albums_Track_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Albums_Track_List.BackColor = System.Drawing.Color.LightBlue;
            this.lv_Albums_Track_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Albums_Track_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Albums_No,
            this.Albums_Track,
            this.Albums_Album,
            this.Albums_Artist,
            this.Albums_Length});
            this.lv_Albums_Track_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_Albums_Track_List.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_Albums_Track_List.FullRowSelect = true;
            this.lv_Albums_Track_List.HideSelection = false;
            this.lv_Albums_Track_List.Location = new System.Drawing.Point(187, 6);
            this.lv_Albums_Track_List.MultiSelect = false;
            this.lv_Albums_Track_List.Name = "lv_Albums_Track_List";
            this.lv_Albums_Track_List.Size = new System.Drawing.Size(657, 299);
            this.lv_Albums_Track_List.TabIndex = 1;
            this.lv_Albums_Track_List.UseCompatibleStateImageBehavior = false;
            this.lv_Albums_Track_List.View = System.Windows.Forms.View.Details;
            this.lv_Albums_Track_List.DoubleClick += new System.EventHandler(this.Track_List_DoubleClick);
            // 
            // Albums_No
            // 
            this.Albums_No.Text = "#";
            this.Albums_No.Width = 25;
            // 
            // Albums_Track
            // 
            this.Albums_Track.Text = "Track";
            this.Albums_Track.Width = 291;
            // 
            // Albums_Album
            // 
            this.Albums_Album.Text = "Album";
            this.Albums_Album.Width = 0;
            // 
            // Albums_Artist
            // 
            this.Albums_Artist.Text = "Artist";
            this.Albums_Artist.Width = 150;
            // 
            // Albums_Length
            // 
            this.Albums_Length.Text = "Length";
            this.Albums_Length.Width = 75;
            // 
            // tp_Artists
            // 
            this.tp_Artists.BackColor = System.Drawing.Color.LightBlue;
            this.tp_Artists.Controls.Add(this.lv_Artists_Artist_List);
            this.tp_Artists.Controls.Add(this.lv_Artists_Track_List);
            this.tp_Artists.Location = new System.Drawing.Point(4, 26);
            this.tp_Artists.Name = "tp_Artists";
            this.tp_Artists.Size = new System.Drawing.Size(850, 311);
            this.tp_Artists.TabIndex = 3;
            this.tp_Artists.Text = "Artists";
            // 
            // lv_Artists_Artist_List
            // 
            this.lv_Artists_Artist_List.AutoArrange = false;
            this.lv_Artists_Artist_List.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lv_Artists_Artist_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Artists_Artist_List.FullRowSelect = true;
            this.lv_Artists_Artist_List.HideSelection = false;
            this.lv_Artists_Artist_List.Location = new System.Drawing.Point(7, 6);
            this.lv_Artists_Artist_List.Name = "lv_Artists_Artist_List";
            this.lv_Artists_Artist_List.Size = new System.Drawing.Size(174, 299);
            this.lv_Artists_Artist_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_Artists_Artist_List.TabIndex = 5;
            this.lv_Artists_Artist_List.UseCompatibleStateImageBehavior = false;
            this.lv_Artists_Artist_List.View = System.Windows.Forms.View.Tile;
            this.lv_Artists_Artist_List.DoubleClick += new System.EventHandler(this.lv_Artists_Artist_List_DoubleClick);
            // 
            // lv_Artists_Track_List
            // 
            this.lv_Artists_Track_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Artists_Track_List.BackColor = System.Drawing.Color.LightBlue;
            this.lv_Artists_Track_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Artists_Track_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Artists_No,
            this.Artists_Track,
            this.Artists_Album,
            this.Artists_Artist,
            this.Artists_Length});
            this.lv_Artists_Track_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_Artists_Track_List.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_Artists_Track_List.FullRowSelect = true;
            this.lv_Artists_Track_List.HideSelection = false;
            this.lv_Artists_Track_List.Location = new System.Drawing.Point(187, 6);
            this.lv_Artists_Track_List.MultiSelect = false;
            this.lv_Artists_Track_List.Name = "lv_Artists_Track_List";
            this.lv_Artists_Track_List.Size = new System.Drawing.Size(657, 299);
            this.lv_Artists_Track_List.TabIndex = 4;
            this.lv_Artists_Track_List.UseCompatibleStateImageBehavior = false;
            this.lv_Artists_Track_List.View = System.Windows.Forms.View.Details;
            this.lv_Artists_Track_List.DoubleClick += new System.EventHandler(this.Track_List_DoubleClick);
            // 
            // Artists_No
            // 
            this.Artists_No.Text = "#";
            this.Artists_No.Width = 25;
            // 
            // Artists_Track
            // 
            this.Artists_Track.Text = "Track";
            this.Artists_Track.Width = 291;
            // 
            // Artists_Album
            // 
            this.Artists_Album.Text = "Album";
            this.Artists_Album.Width = 150;
            // 
            // Artists_Artist
            // 
            this.Artists_Artist.Text = "Artist";
            this.Artists_Artist.Width = 0;
            // 
            // Artists_Length
            // 
            this.Artists_Length.Text = "Length";
            this.Artists_Length.Width = 75;
            // 
            // tp_Playlists
            // 
            this.tp_Playlists.BackColor = System.Drawing.Color.LightBlue;
            this.tp_Playlists.Location = new System.Drawing.Point(4, 26);
            this.tp_Playlists.Name = "tp_Playlists";
            this.tp_Playlists.Size = new System.Drawing.Size(850, 311);
            this.tp_Playlists.TabIndex = 2;
            this.tp_Playlists.Text = "Playlists";
            // 
            // pnl_Song_Control
            // 
            this.pnl_Song_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Song_Control.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl_Song_Control.Controls.Add(this.btn_Control_Mode_Change);
            this.pnl_Song_Control.Controls.Add(this.btn_Control_Next_Button);
            this.pnl_Song_Control.Controls.Add(this.btn_Control_Previous_Button);
            this.pnl_Song_Control.Controls.Add(this.btn_Control_Play_Button);
            this.pnl_Song_Control.Controls.Add(this.lbl_Control_Track_Duration);
            this.pnl_Song_Control.Controls.Add(this.lbl_Control_Artist_Name);
            this.pnl_Song_Control.Controls.Add(this.lbl_Control_Album_Name);
            this.pnl_Song_Control.Controls.Add(this.lbl_Control_Track_Name);
            this.pnl_Song_Control.Controls.Add(this.tkb_Control_Time_Bar);
            this.pnl_Song_Control.Controls.Add(this.pic_Control_Album_Cover);
            this.pnl_Song_Control.Location = new System.Drawing.Point(5, 347);
            this.pnl_Song_Control.Name = "pnl_Song_Control";
            this.pnl_Song_Control.Size = new System.Drawing.Size(850, 102);
            this.pnl_Song_Control.TabIndex = 1;
            // 
            // btn_Control_Mode_Change
            // 
            this.btn_Control_Mode_Change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Control_Mode_Change.BackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Mode_Change.BackgroundImage = global::TheBesterMusicApp.Properties.Resources.Circle;
            this.btn_Control_Mode_Change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Control_Mode_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Control_Mode_Change.FlatAppearance.BorderSize = 0;
            this.btn_Control_Mode_Change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Mode_Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Mode_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Control_Mode_Change.Location = new System.Drawing.Point(810, 62);
            this.btn_Control_Mode_Change.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Control_Mode_Change.Name = "btn_Control_Mode_Change";
            this.btn_Control_Mode_Change.Size = new System.Drawing.Size(35, 35);
            this.btn_Control_Mode_Change.TabIndex = 9;
            this.btn_Control_Mode_Change.UseVisualStyleBackColor = false;
            this.btn_Control_Mode_Change.Click += new System.EventHandler(this.btn_Control_Mode_Change_Click);
            // 
            // btn_Control_Next_Button
            // 
            this.btn_Control_Next_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Control_Next_Button.BackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Next_Button.BackgroundImage = global::TheBesterMusicApp.Properties.Resources.Forward;
            this.btn_Control_Next_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Control_Next_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Control_Next_Button.FlatAppearance.BorderSize = 0;
            this.btn_Control_Next_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Next_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Next_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Control_Next_Button.Location = new System.Drawing.Point(393, 62);
            this.btn_Control_Next_Button.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Control_Next_Button.Name = "btn_Control_Next_Button";
            this.btn_Control_Next_Button.Size = new System.Drawing.Size(35, 35);
            this.btn_Control_Next_Button.TabIndex = 8;
            this.btn_Control_Next_Button.UseVisualStyleBackColor = false;
            this.btn_Control_Next_Button.Click += new System.EventHandler(this.btn_Control_Next_Button_Click);
            // 
            // btn_Control_Previous_Button
            // 
            this.btn_Control_Previous_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Control_Previous_Button.BackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Previous_Button.BackgroundImage = global::TheBesterMusicApp.Properties.Resources.Backward;
            this.btn_Control_Previous_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Control_Previous_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Control_Previous_Button.FlatAppearance.BorderSize = 0;
            this.btn_Control_Previous_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Previous_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Previous_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Control_Previous_Button.Location = new System.Drawing.Point(303, 62);
            this.btn_Control_Previous_Button.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Control_Previous_Button.Name = "btn_Control_Previous_Button";
            this.btn_Control_Previous_Button.Size = new System.Drawing.Size(35, 35);
            this.btn_Control_Previous_Button.TabIndex = 7;
            this.btn_Control_Previous_Button.UseVisualStyleBackColor = false;
            this.btn_Control_Previous_Button.Click += new System.EventHandler(this.btn_Control_Previous_Button_Click);
            // 
            // btn_Control_Play_Button
            // 
            this.btn_Control_Play_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Control_Play_Button.BackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Play_Button.BackgroundImage = global::TheBesterMusicApp.Properties.Resources.Pause;
            this.btn_Control_Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Control_Play_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Control_Play_Button.FlatAppearance.BorderSize = 0;
            this.btn_Control_Play_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Play_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Control_Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Control_Play_Button.Location = new System.Drawing.Point(348, 62);
            this.btn_Control_Play_Button.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Control_Play_Button.Name = "btn_Control_Play_Button";
            this.btn_Control_Play_Button.Size = new System.Drawing.Size(35, 35);
            this.btn_Control_Play_Button.TabIndex = 6;
            this.btn_Control_Play_Button.UseVisualStyleBackColor = false;
            this.btn_Control_Play_Button.Click += new System.EventHandler(this.btn_Control_Play_Button_Click);
            // 
            // lbl_Control_Track_Duration
            // 
            this.lbl_Control_Track_Duration.AutoSize = true;
            this.lbl_Control_Track_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Control_Track_Duration.Location = new System.Drawing.Point(108, 77);
            this.lbl_Control_Track_Duration.Name = "lbl_Control_Track_Duration";
            this.lbl_Control_Track_Duration.Size = new System.Drawing.Size(83, 17);
            this.lbl_Control_Track_Duration.TabIndex = 5;
            this.lbl_Control_Track_Duration.Text = "00:00 / 00:00";
            // 
            // lbl_Control_Artist_Name
            // 
            this.lbl_Control_Artist_Name.AutoSize = true;
            this.lbl_Control_Artist_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Control_Artist_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Control_Artist_Name.Location = new System.Drawing.Point(108, 49);
            this.lbl_Control_Artist_Name.MaximumSize = new System.Drawing.Size(170, 20);
            this.lbl_Control_Artist_Name.Name = "lbl_Control_Artist_Name";
            this.lbl_Control_Artist_Name.Size = new System.Drawing.Size(0, 17);
            this.lbl_Control_Artist_Name.TabIndex = 4;
            // 
            // lbl_Control_Album_Name
            // 
            this.lbl_Control_Album_Name.AutoSize = true;
            this.lbl_Control_Album_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Control_Album_Name.Location = new System.Drawing.Point(107, 29);
            this.lbl_Control_Album_Name.MaximumSize = new System.Drawing.Size(175, 20);
            this.lbl_Control_Album_Name.Name = "lbl_Control_Album_Name";
            this.lbl_Control_Album_Name.Size = new System.Drawing.Size(0, 20);
            this.lbl_Control_Album_Name.TabIndex = 3;
            // 
            // lbl_Control_Track_Name
            // 
            this.lbl_Control_Track_Name.AutoSize = true;
            this.lbl_Control_Track_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Control_Track_Name.Location = new System.Drawing.Point(106, 4);
            this.lbl_Control_Track_Name.MaximumSize = new System.Drawing.Size(200, 25);
            this.lbl_Control_Track_Name.Name = "lbl_Control_Track_Name";
            this.lbl_Control_Track_Name.Size = new System.Drawing.Size(130, 25);
            this.lbl_Control_Track_Name.TabIndex = 2;
            this.lbl_Control_Track_Name.Text = "Select A Track";
            // 
            // tkb_Control_Time_Bar
            // 
            this.tkb_Control_Time_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkb_Control_Time_Bar.Location = new System.Drawing.Point(303, 4);
            this.tkb_Control_Time_Bar.Margin = new System.Windows.Forms.Padding(0);
            this.tkb_Control_Time_Bar.Maximum = 100;
            this.tkb_Control_Time_Bar.Name = "tkb_Control_Time_Bar";
            this.tkb_Control_Time_Bar.Size = new System.Drawing.Size(547, 45);
            this.tkb_Control_Time_Bar.TabIndex = 1;
            this.tkb_Control_Time_Bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkb_Control_Time_Bar.Scroll += new System.EventHandler(this.tkb_Control_Time_Bar_Scroll);
            // 
            // pic_Control_Album_Cover
            // 
            this.pic_Control_Album_Cover.Location = new System.Drawing.Point(3, 3);
            this.pic_Control_Album_Cover.Name = "pic_Control_Album_Cover";
            this.pic_Control_Album_Cover.Size = new System.Drawing.Size(96, 96);
            this.pic_Control_Album_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Control_Album_Cover.TabIndex = 0;
            this.pic_Control_Album_Cover.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.pnl_Song_Control);
            this.Controls.Add(this.tab_Page_Select);
            this.Name = "Form1";
            this.Text = "The Bester Music App";
            this.tab_Page_Select.ResumeLayout(false);
            this.tp_Tracks.ResumeLayout(false);
            this.tp_Albums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tp_Artists.ResumeLayout(false);
            this.pnl_Song_Control.ResumeLayout(false);
            this.pnl_Song_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_Control_Time_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Control_Album_Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Page_Select;
        private System.Windows.Forms.TabPage tp_Tracks;
        private System.Windows.Forms.TabPage tp_Albums;
        private System.Windows.Forms.TabPage tp_Playlists;
        private System.Windows.Forms.Panel pnl_Song_Control;
        private System.Windows.Forms.ListView lv_Tracks_Track_List;
        private System.Windows.Forms.ColumnHeader Tracks_No;
        private System.Windows.Forms.ColumnHeader Tracks_Track;
        private System.Windows.Forms.ColumnHeader Tracks_Album;
        private System.Windows.Forms.ColumnHeader Tracks_Artist;
        private System.Windows.Forms.ColumnHeader Track_Time;
        private System.Windows.Forms.ListView lv_Albums_Track_List;
        private System.Windows.Forms.ColumnHeader Albums_No;
        private System.Windows.Forms.ColumnHeader Albums_Track;
        private System.Windows.Forms.ColumnHeader Albums_Artist;
        private System.Windows.Forms.ColumnHeader Albums_Length;
        private System.Windows.Forms.ListView lv_Albums_Album_List;
        private System.Windows.Forms.ImageList il_Album_Covers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Albums_Album;
        private System.Windows.Forms.PictureBox pic_Control_Album_Cover;
        private System.Windows.Forms.TrackBar tkb_Control_Time_Bar;
        private System.Windows.Forms.Label lbl_Control_Track_Name;
        private System.Windows.Forms.Label lbl_Control_Album_Name;
        private System.Windows.Forms.Label lbl_Control_Artist_Name;
        private System.Windows.Forms.Label lbl_Control_Track_Duration;
        private System.Windows.Forms.Button btn_Control_Play_Button;
        private System.Windows.Forms.Button btn_Control_Next_Button;
        private System.Windows.Forms.Button btn_Control_Previous_Button;
        private System.Windows.Forms.Button btn_Control_Mode_Change;
        private System.Windows.Forms.Timer tmr_Track_Timer;
        private System.Windows.Forms.TabPage tp_Artists;
        private System.Windows.Forms.ListView lv_Artists_Artist_List;
        private System.Windows.Forms.ListView lv_Artists_Track_List;
        private System.Windows.Forms.ColumnHeader Artists_No;
        private System.Windows.Forms.ColumnHeader Artists_Track;
        private System.Windows.Forms.ColumnHeader Artists_Album;
        private System.Windows.Forms.ColumnHeader Artists_Artist;
        private System.Windows.Forms.ColumnHeader Artists_Length;
    }
}

