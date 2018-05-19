using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

using iTunesLib;

namespace IceManager
{
    public class iTunesController
    {
        
        #region iTunesController メンバ

        private iTunesApp iTunes { get; set; } = new iTunesApp();
        
        public string AlbumName { get; set; }
        public string Artist { get; set; } 
        public string TrackInfo { get; set; } 
        public string TrackName { get; set; }

        #endregion

        #region コンストラクタ
            
        public iTunesController() => RegistarEvent();
        
        #endregion 

        //再生イベント時に呼び出されるメソッド
        private void iTunesOnPlayerPlayEvent(object iTrack)
        {
            //再生中のトラック情報を取得
            var track = iTrack as IITTrack;

            if (track != null)
            {
                //ラベル用テキストを設定
                this.AlbumName = track.Album;
                this.TrackInfo = track.TrackNumber + " / " + track.TrackCount;
                this.Artist = track.Artist;
                this.TrackName = track.Name;
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
                this.AlbumName = track.Album;
                this.TrackInfo = track.TrackNumber + " / " + track.TrackCount;
                this.Artist = track.Artist;
                this.TrackName = track.Name;
            }
        }

        /// <summary>
        /// iTunes 終了時に呼ばれます。 
        /// </summary>
        private void iTunes_OnAboutToPromptUserToQuitEvent() => ReleaseCOM();
        
        /// <summary>
        /// iTunes イベントハンドラ登録
        /// </summary>
        private void RegistarEvent()
        {
            iTunes.OnAboutToPromptUserToQuitEvent += iTunes_OnAboutToPromptUserToQuitEvent;
            iTunes.OnPlayerPlayEvent += iTunesOnPlayerPlayEvent;
        }
        
        //iTunes COM SDKを解放
        private void ReleaseCOM()
        {
            iTunes.OnPlayerPlayEvent -= iTunes_OnPlayerPlayEvent;
            iTunes.OnAboutToPromptUserToQuitEvent -= iTunes_OnAboutToPromptUserToQuitEvent;

            Marshal.ReleaseComObject(iTunes);
            iTunes = null;
        }
        
        /// <summary>
        /// フォーム終了時もCOMの解放を行う
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => ReleaseCOM();
        
        /// <summary>
        /// 再生ボタンが押された時の処理
        /// </summary>
        public void Play() => iTunes.Play();
        
        /// <summary>
        /// 一時停止ボタンが押された時の処理
        /// </summary>
        public void Pause() => iTunes.Pause();
        
        /// <summary>
        /// 戻りボタンが押された時の処理
        /// </summary>
        public void PrevButton() => iTunes.PreviousTrack();
        
        /// <summary>
        /// Nextボタンが押された時の処理
        /// </summary>
        public void NextButton() => iTunes.NextTrack();

    }
}
