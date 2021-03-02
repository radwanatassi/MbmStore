﻿using System;
namespace MbmStore.Models
{
    public class Track
    {
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }


        public Track()
        {


        }
        public Track(string title, TimeSpan length)
        {
            this.Title = title;
            this.Length = length;
        }

    }
}
