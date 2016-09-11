using System;
using iTunesLib;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace IceManager
{
    public class iTunesController
    {
        #region iTunesController メンバ

        private iTunesApp iTunes;
        public string AlbumName, TrackInfo, Artist, TrackName;

        #endregion

        #region コンストラクタ
        public iTunesController()
        {
            //iTunes COMのセットアップ
            iTunes = new iTunesApp();
            iTunes.OnAboutToPromptUserToQuitEvent += new _IiTunesEvents_OnAboutToPromptUserToQuitEventEventHandler(iTunes_OnAboutToPromptUserToQuitEvent);
            iTunes.OnPlayerPlayEvent += new _IiTunesEvents_OnPlayerPlayEventEventHandler(iTunes_OnPlayerPlayEvent);
            //iTunes.OnPlayerPlayingTrackChangedEvent += new _IiTunesEvents_OnPlayerPlayingTrackChangedEventEventHandler(iTunes_OnPlayerPlayingTrackChangedEvent);
        }
        #endregion 

        //再生イベント時に呼び出されるメソッド
        private void iTunes_OnPlayerPlayEvent(object iTrack)
        {
            //再生中のトラック情報を取得
            var track = iTrack as IITTrack;

            if (track != null)
            {
                //ラベル用テキストを設定
                AlbumName = track.Album;
                TrackInfo = track.TrackNumber + " / " + track.TrackCount;
                Artist = track.Artist;
                TrackName = track.Name;
            }
            else
            {
                //None;
            }
        }

        /// <summary>
        /// 再生中の曲が変わった時に呼ばれるメソッド
        /// </summary>
        /// <param name="iTrack"></param>
        private void iTunes_OnPlayerPlayingTrackChangedEvent(object iTrack)
        {
            //再生中のトラック情報を取得
            var track = iTrack as IITTrack;

            if (track != null)
            {
                //ラベル用テキストを設定
                AlbumName = track.Album;
                TrackInfo = track.TrackNumber + " / " + track.TrackCount;
                Artist = track.Artist;
                TrackName = track.Name;
            }
            else
            {
                //None;
            }
        }

        /// <summary>
        /// iTunes 終了時に呼ばれます。 
        /// </summary>
        private void iTunes_OnAboutToPromptUserToQuitEvent()
        {
            // COM のリリースを行います。
            ReleaseCOM();
        }

        //iTunes COM SDKを解放
        private void ReleaseCOM()
        {
            iTunes.OnPlayerPlayEvent -= iTunes_OnPlayerPlayEvent;
            iTunes.OnAboutToPromptUserToQuitEvent -= iTunes_OnAboutToPromptUserToQuitEvent;

            Marshal.ReleaseComObject(iTunes);
            iTunes = null;
        }

        //フォーム終了時もCOMの解放を行う
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iTunes != null)
            {
                ReleaseCOM();
            }
        }
        /// <summary>
        /// 再生ボタンが押された時の処理
        /// </summary>
        public void Play()
        {
            iTunes.Play();
        }

        /// <summary>
        /// 一時停止ボタンが押された時の処理
        /// </summary>
        public void Pause()
        {
            iTunes.Pause();
        }

        /// <summary>
        /// 戻りボタンが押された時の処理
        /// </summary>
        public void PrevButton()
        {
            iTunes.PreviousTrack();
        }

        /// <summary>
        /// Nextボタンが押された時の処理
        /// </summary>
        public void NextButton()
        {
            iTunes.NextTrack();
        }
    }
}
