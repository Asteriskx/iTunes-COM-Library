using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

using IceManager.Enum;

namespace IceManager
{
    public partial class Form1 : Form
    {
        private iTunesController itunes;

        public Form1()
        {
            InitializeComponent();
            itunes = new iTunesController();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            var currentTrackName = $"Track : {itunes.TrackName}";
            var currentArtist = $"Artist : {itunes.Artist}";
            var currentAlbum = $"Album : {itunes.AlbumName}";

            itunes.Play();
            CurrentTrackInfo.Text = iState.Play.ExtStatus();

            Current.Text = currentTrackName;
            CurrentArtist.Text = currentArtist;
            CurrentAlbum.Text = currentAlbum;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            itunes.Pause();
            CurrentTrackInfo.Text = iState.Pause.ExtStatus();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            //var PrevTrackName = $"{itunes.TrackName}";

            itunes.PrevButton();
            CurrentTrackInfo.Text = iState.Prev.ExtStatus();

            //Current.Text = PrevTrackName;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //var NextTrackName = $"{itunes.TrackName}";

            itunes.NextButton();
            CurrentTrackInfo.Text = iState.Next.ExtStatus();

            //Current.Text = NextTrackName;
        }

        private void DefaultStatus()
        {
            //Status を待機中にする
            CurrentTrackInfo.Text = iState.Wait.ExtStatus();
        }
    }
}