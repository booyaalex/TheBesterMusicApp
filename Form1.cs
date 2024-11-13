using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Aac;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheBesterMusicApp
{
    public partial class Form1 : Form
    {
        List<Track> tracks = new List<Track>();
        Track[] displayed_tracks = new Track[0];
        int current_page = 0;
        string selected_album = "";

        public Form1()
        {
            InitializeComponent();
            GetMusicFromFiles();
        }

        private void GetMusicFromFiles()
        {
            string[] dirs = Directory.GetFiles(Environment.ExpandEnvironmentVariables(@"C:\Users\%USERNAME%\") + @"Music", "*.mp3", SearchOption.AllDirectories);
            Console.WriteLine("Music files present: {0}", dirs.Length);
            foreach (string dir in dirs)
            {
                TagLib.File tagFile = TagLib.File.Create(dir);
                Console.WriteLine(tagFile.Tag);

                System.Drawing.Image image = Properties.Resources.rect;
                if (tagFile.Tag.Pictures.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(tagFile.Tag.Pictures[0].Data.Data);
                    image = System.Drawing.Image.FromStream(ms);
                }

                Track track = new Track()
                {
                    artist = tagFile.Tag.FirstPerformer,
                    album = tagFile.Tag.Album,
                    duration = tagFile.Properties.Duration.TotalSeconds,
                    image = image,
                    path = dir,
                    title = tagFile.Tag.Title,
                    track = (int)tagFile.Tag.Track,
                    track_count = (int)tagFile.Tag.TrackCount,
                };
                tracks.Add(track);
            }
            DisplayMusic();
        }
        private void tab_Page_Select_TabIndexChanged(object sender, TabControlEventArgs e)
        {
            if (tab_Page_Select.SelectedTab.Name == "tp_Tracks")
            {
                current_page = 0;
            }
            else if (tab_Page_Select.SelectedTab.Name == "tp_Albums")
            {
                current_page = 1;
                DisplayAlbums();
            }
            else if (tab_Page_Select.SelectedTab.Name == "tp_Playlists")
            {
                current_page = 2;
            }
            DisplayMusic();
        }
        private void DisplayMusic()
        {
            var track_list = new ListView();
            if (current_page == 0)
            {
                track_list = lv_Tracks_Track_List;
                displayed_tracks = new Track[tracks.Count];
                for (int i = 0; i < tracks.Count; i++)
                {
                    displayed_tracks[i] = tracks[i];
                }
            }
            else if (current_page == 1)
            {
                track_list = lv_Albums_Track_List;
                displayed_tracks = new Track[tracks.Count];
                int count = 0;
                for (int i = 0; i < tracks.Count; i++)
                {
                    if (tracks[i].album == selected_album)
                    {
                        displayed_tracks[count] = tracks[i];
                        count++;
                    }
                }
            }

            track_list.Items.Clear();
            for (int i = 0; i < displayed_tracks.Length; i++)
            {
                Track track = displayed_tracks[i];
                if(track == null)
                {
                    break;
                }
                TimeSpan seconds = TimeSpan.FromSeconds(track.duration);

                string duration = seconds.ToString(@"mm\:ss");

                string[] row = { track.title, track.album, track.artist, duration };
                track_list.Items.Add(track.track.ToString()).SubItems.AddRange(row);
                track_list.Items[i].Tag = track;
            }
        }
        private void DisplayAlbums()
        { 
            List<Album> albums = new List<Album>(); //This one is for displaying albums.
            List<string> album_list = new List<string>(); //This one is for checkig if an album has already been added.
            if(selected_album == "")
            {
                selected_album = tracks[0].album;
            }

            foreach (Track track in tracks)
            {
                if (!album_list.Contains(track.album))
                {
                    album_list.Add(track.album);
                    Album album = new Album()
                    {
                        name = track.album,
                        image = track.image,
                        track_count = track.track_count,
                    };
                    albums.Add(album);
                }
            }
            for (int i = 0; i < albums.Count; i++) 
            {
                Album album = albums[i];             
                ListViewItem item = new ListViewItem();
                item.Text = album.name;
                item.ImageIndex = i;
                il_Album_Covers.Images.Add(album.image);
                this.lv_Albums_Album_List.Items.Add(item);
                this.lv_Albums_Album_List.Items[i].Tag = album;
            }
        }

        private void lv_Albums_Album_List_DoubleClick(object sender, EventArgs e)
        {
            if (lv_Albums_Album_List.SelectedItems.Count > 0)
            {
                Album album = (Album)lv_Albums_Album_List.SelectedItems[0].Tag;
                selected_album = album.name;
                DisplayMusic();
            }
        }
    }
    public class Track
    { 
        public string artist { get; set; }
        public string album { get; set; }
        public double duration { get; set; }
        public System.Drawing.Image image { get; set; }
        public string path { get; set; }
        public int track { get; set; }
        public int track_count { get; set; }
        public string title { get; set; }
    }
    public class Album
    {
        public string name { get; set; }
        public System.Drawing.Image image { get; set; }
        public int track_count { get; set; }
    }
}
