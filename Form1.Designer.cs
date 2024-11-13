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
            this.lv_Albums_Track_List = new System.Windows.Forms.ListView();
            this.Albums_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Playlists = new System.Windows.Forms.TabPage();
            this.pnl_Song_Control = new System.Windows.Forms.Panel();
            this.il_Album_Covers = new System.Windows.Forms.ImageList(this.components);
            this.Albums_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Page_Select.SuspendLayout();
            this.tp_Tracks.SuspendLayout();
            this.tp_Albums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Page_Select
            // 
            this.tab_Page_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Page_Select.Controls.Add(this.tp_Tracks);
            this.tab_Page_Select.Controls.Add(this.tp_Albums);
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
            this.lv_Albums_Track_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_Albums_Track_List.TabIndex = 1;
            this.lv_Albums_Track_List.UseCompatibleStateImageBehavior = false;
            this.lv_Albums_Track_List.View = System.Windows.Forms.View.Details;
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
            // Albums_Artist
            // 
            this.Albums_Artist.Text = "Artist";
            this.Albums_Artist.Width = 150;
            // 
            // Albums_Length
            // 
            this.Albums_Length.Text = "Length";
            this.Albums_Length.Width = 61;
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
            this.pnl_Song_Control.Location = new System.Drawing.Point(5, 347);
            this.pnl_Song_Control.Name = "pnl_Song_Control";
            this.pnl_Song_Control.Size = new System.Drawing.Size(850, 102);
            this.pnl_Song_Control.TabIndex = 1;
            // 
            // il_Album_Covers
            // 
            this.il_Album_Covers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_Album_Covers.ImageSize = new System.Drawing.Size(100, 100);
            this.il_Album_Covers.TransparentColor = System.Drawing.Color.Black;
            // 
            // Albums_Album
            // 
            this.Albums_Album.Text = "Album";
            this.Albums_Album.Width = 0;
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
    }
}

