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
using WMPLib;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TheBesterMusicApp
{
    public partial class Form1 : Form
    {
        int current_page = 0;
        List<Track> tracks = new List<Track>();
        Track[] displayed_tracks = new Track[0];
        Track[] track_queue = new Track[0];
        int current_track = 0;
        string selected_album = "";
        string selected_artist = "";

        WindowsMediaPlayer music_player = new WindowsMediaPlayer();
        int current_mode = 0; //0 Normal, 1 Shuffle, 2 Repeat;
        int volume = 100;

        public Form1()
        {
            InitializeComponent();
            GetMusicFromFiles();
        }

        /*
         * Displaying Music 
         */
        private void GetMusicFromFiles()
        {
            string[] dirs = Directory.GetFiles(Environment.ExpandEnvironmentVariables(@"C:\Users\%USERNAME%\") + @"Music", "*.mp3", SearchOption.AllDirectories);
            Console.WriteLine("Music files present: {0}", dirs.Length);
            music_player.currentPlaylist.clear();
            foreach (string dir in dirs)
            {
                TagLib.File tagFile = TagLib.File.Create(dir);

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
                    year = (int)tagFile.Tag.Year
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
            else if (tab_Page_Select.SelectedTab.Name == "tp_Artists")
            {
                current_page = 2;
                DisplayArtists();
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
                Array.Resize(ref displayed_tracks, count);
            }
            else if (current_page == 2)
            {
                track_list = lv_Artists_Track_List;
                displayed_tracks = new Track[tracks.Count];
                int count = 0;
                for (int i = 0; i < tracks.Count; i++)
                {
                    if (tracks[i].artist == selected_artist)
                    {
                        displayed_tracks[count] = tracks[i];
                        count++;
                    }
                }
                Array.Resize(ref displayed_tracks, count);
            }

            displayed_tracks = SortTracks(displayed_tracks);

            if (track_queue.Length == 0)
            {
                track_queue = displayed_tracks;
            }  

            track_list.Items.Clear();
            for (int i = 0; i < displayed_tracks.Length; i++)
            {
                Track track = displayed_tracks[i];

                string duration = ConvertToTimestamp(track.duration);
                string[] row = { track.title, track.album, track.artist, duration };
                track_list.Items.Add(track.track.ToString()).SubItems.AddRange(row);
                track_list.Items[i].Tag = track;
            }
        }
        private void DisplayAlbums()
        {
            List<Album> albums = new List<Album>(); //This one is for displaying albums.
            List<string> album_list = new List<string>(); //This one is for checkig if an album has already been added.
            Album album;
            ListViewItem item;
            if (selected_album == "")
            {
                selected_album = tracks[0].album;
            }

            foreach (Track track in tracks)
            {
                if (!album_list.Contains(track.album))
                {
                    album_list.Add(track.album);
                    album = new Album()
                    {
                        name = track.album,
                        image = track.image,
                        track_count = track.track_count,
                    };
                    albums.Add(album);
                }
            }

            lv_Albums_Album_List.Clear();
            for (int i = 0; i < albums.Count; i++)
            {
                album = albums[i];
                item = new ListViewItem();
                item.Text = album.name;
                item.ImageIndex = i;
                item.Tag = album;
                il_Album_Covers.Images.Add(album.image);
                this.lv_Albums_Album_List.Items.Add(item);
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
        private void DisplayArtists()
        {
            List<Artist> artists = new List<Artist>(); //This one is for displaying albums.
            List<string> artist_list = new List<string>(); //This one is for checkig if an album has already been added.
            Artist artist;
            ListViewItem item;
            if (selected_artist == "")
            {
                selected_artist = tracks[0].artist;
            }

            foreach (Track track in tracks)
            {
                if (!artist_list.Contains(track.artist))
                {
                    artist_list.Add(track.artist);
                    artist = new Artist()
                    {
                        name = track.artist,
                        track_count = track.track_count,
                    };
                    artists.Add(artist);
                }
            }

            lv_Artists_Artist_List.Clear();
            for (int i = 0; i < artists.Count; i++)
            {
                artist = artists[i];
                item = new ListViewItem();
                item.Text = artist.name;
                item.Tag = artist;
                this.lv_Artists_Artist_List.Items.Add(item);
            }
        }
        private void lv_Artists_Artist_List_DoubleClick(object sender, EventArgs e)
        {
            if (lv_Artists_Artist_List.SelectedItems.Count > 0)
            {
                Artist artist = (Artist)lv_Artists_Artist_List.SelectedItems[0].Tag;
                selected_artist = artist.name;
                DisplayMusic();
            }
        }
        private static Track[] SortTracks(Track[] tracks)
        {
            //Artist => Year => Album => Track No
            return tracks.OrderBy(track => track.artist).ThenByDescending(track => track.year).ThenBy(track => track.album).ThenBy(track => track.track).ToArray();
        }

        /*
         * Playing Music 
         */
        private void PlayTrack(Track track)
        {

            tmr_Track_Timer.Stop();

            music_player.URL = track.path;
            tmr_Track_Timer.Enabled = true;
            tmr_Track_Timer.Tick += new EventHandler(UpdateTime);
            tmr_Track_Timer.Interval = 1000;

            btn_Control_Play_Button.BackgroundImage = Properties.Resources.Pause;

            music_player.controls.play();
            tmr_Track_Timer.Start();

        }
        private void UpdateTime(object sender, EventArgs e)
        {
            lbl_Control_Track_Duration.Text = $"{ConvertToTimestamp(music_player.controls.currentPosition)} / {ConvertToTimestamp(music_player.currentMedia.duration)}";
            tkb_Control_Time_Bar.Value = Convert.ToInt32(music_player.controls.currentPosition / music_player.currentMedia.duration * 100);
            Console.WriteLine(music_player.playState.ToString());

            if (music_player.playState.ToString() == "wmppsStopped")
            {
                if (current_mode != 2)
                {
                    current_track++;
                    if (current_track > track_queue.Length - 1)
                    {
                        current_track = 0;
                    }
                }
                PlayTrack(track_queue[current_track]);
                DisplayTrackOnControl(track_queue[current_track]);
            }
        }
        private void DisplayTrackOnControl(Track track)
        {
            pic_Control_Album_Cover.Image = track.image;
            lbl_Control_Track_Name.Text = track.title;
            lbl_Control_Album_Name.Text = track.album;
            lbl_Control_Artist_Name.Text = track.artist;
            lbl_Control_Track_Duration.Text = $"00:00 / {ConvertToTimestamp(track.duration)}";
            tkb_Control_Time_Bar.Value = 0;
        }
        private void Track_List_DoubleClick(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;
            if (listview.SelectedItems.Count > 0)
            {
                track_queue = displayed_tracks;
                ChangeMode();

                current_track = Array.IndexOf(track_queue, (Track)listview.SelectedItems[0].Tag);
                PlayTrack(track_queue[current_track]);
                DisplayTrackOnControl(track_queue[current_track]);
            }
        }
        private static string ConvertToTimestamp(double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

        /*
         * Controlling Music 
         */
        private void btn_Control_Play_Button_Click(object sender, EventArgs e)
        {
            if (music_player.playState.ToString() == "wmppsPlaying")
            {
                tmr_Track_Timer.Enabled = false;
                btn_Control_Play_Button.BackgroundImage = Properties.Resources.Play;
                music_player.controls.pause();
            }
            else
            {
                tmr_Track_Timer.Enabled = true;
                btn_Control_Play_Button.BackgroundImage = Properties.Resources.Pause;
                music_player.controls.play();
            }
        }

        private void btn_Control_Previous_Button_Click(object sender, EventArgs e)
        {
            if (current_mode != 2)
            {
                current_track--;
                if (current_track < 0)
                {
                    current_track = track_queue.Length - 1;
                }
            }
            else
            {
                Console.WriteLine(current_track);
            }
            PlayTrack(track_queue[current_track]);
            DisplayTrackOnControl(track_queue[current_track]);
        }
        private void btn_Control_Next_Button_Click(object sender, EventArgs e)
        {
            if (current_mode != 2)
            {
                current_track++;
                if (current_track > track_queue.Length - 1)
                {
                    current_track = 0;
                }
            }
            PlayTrack(track_queue[current_track]);
            DisplayTrackOnControl(track_queue[current_track]);
        }
        private void tkb_Control_Time_Bar_Scroll(object sender, EventArgs e)
        {
            music_player.controls.currentPosition = Convert.ToDouble(tkb_Control_Time_Bar.Value * music_player.currentMedia.duration / 100);
        }

        private void btn_Control_Mode_Change_Click(object sender, EventArgs e)
        {
            if (current_mode == 2)
            {
                current_mode = 0;
                btn_Control_Mode_Change.BackgroundImage = Properties.Resources.Circle;
            }
            else if (current_mode == 0)
            {
                current_mode = 1;
                btn_Control_Mode_Change.BackgroundImage = Properties.Resources.Shuffle;
            }
            else
            {
                current_mode = 2;
                btn_Control_Mode_Change.BackgroundImage = Properties.Resources.Repeat;
            }
            ChangeMode();
        }
        private void ChangeMode()
        {
            if (current_mode == 1)
            {
                Random rng = new Random();
                track_queue = track_queue.OrderBy(track => rng.Next()).ToArray();
            }
            else
            {
                track_queue = SortTracks(track_queue);
            }
        }

        private void tkb_Control_Volume_Scroll(object sender, EventArgs e)
        {
            music_player.settings.volume = tkb_Control_Volume.Value;
        }
    }
    struct Track
    {
        public string artist;
        public string album;
        public double duration;
        public System.Drawing.Image image;
        public string path;
        public int track;
        public int track_count;
        public string title;
        public int year;
    }
    struct Album
    {
        public string name;
        public System.Drawing.Image image;
        public int track_count;
    }
    struct Artist
    {
        public string name;
        public int track_count;
    }
}
