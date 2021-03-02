using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        private List<Track> tracks;
        public List<Track> Tracks { get; private set; } = new List<Track>();

        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }


        public MusicCD()
        {

        }

        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
        {
            this.Artist = artist;
            this.Released = released;

        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            var playingTime = new TimeSpan();
            foreach (var track in Tracks)
            {
                playingTime += track.Length;
            }
            return playingTime;




        }
    }
}