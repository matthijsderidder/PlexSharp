using System;
using System.Runtime.Serialization;

namespace PlexSharp.Webhooks
{
    [Serializable]
    public enum EventType
    {
        [EnumMember(Value = "media.play")]
        MediaPlay,

        [EnumMember(Value = "media.pause")]
        MediaPause,

        [EnumMember(Value = "media.resume")]
        MediaResume,

        [EnumMember(Value = "media.stop")]
        MediaStop,

        [EnumMember(Value = "media.scrobble")]
        MediaScrobble,

        [EnumMember(Value = "media.rate")]
        MediaRate
    }

    [Serializable]
    public enum MediaType : int
    {
        [EnumMember(Value = "movie")]
        Movie = 1,

        [EnumMember(Value = "show")]
        Show = 2,

        [EnumMember(Value = "season")]
        Season = 3,

        [EnumMember(Value = "episode")]
        Episode = 4,

        [EnumMember(Value = "trailer")]
        Trailer = 5,

        [EnumMember(Value = "comic")]
        Comic = 6,

        [EnumMember(Value = "person")]
        Person = 7,

        [EnumMember(Value = "artist")]
        Artist = 8,

        [EnumMember(Value = "album")]
        Album = 9,

        [EnumMember(Value = "track")]
        Track = 10,

        [EnumMember(Value = "photoAlbum")]
        PhotoAlbum = 11,

        [EnumMember(Value = "picture")]
        Picture = 12,

        [EnumMember(Value = "photo")]
        Photo = 13,

        [EnumMember(Value = "clip")]
        Clip = 14,

        [EnumMember(Value = "playlistItem")]
        PlaylistItem = 15,
    }

    [Serializable]
    public enum LibrarySectionType
    {
        [EnumMember(Value = "artist")]
        Artist,

        [EnumMember(Value = "audio")]
        Audio,

        [EnumMember(Value = "directory")]
        Directory,

        [EnumMember(Value = "movie")]
        Movie,

        [EnumMember(Value = "music")]
        Music,

        [EnumMember(Value = "photo")]
        Photo,

        [EnumMember(Value = "show")]
        Show,

        [EnumMember(Value = "video")]
        Video
    }
}
