using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Helpers
{
    public static class UrlHelper
    {
        //API URL - WILL BE STORED IN DB
        //To Click - Share - Comment - Repost - Quote
        public static string GetArtistUrl(int artistId) => $"/artist/{artistId}";
        public static string GetAlbumUrl(int albumId) => $"/album/{albumId}";
        public static string GetSongUrl(int songId) => $"/song/{songId}";
        public static string GetGenreUrl(int genreId) => $"/genre/{genreId}";
        
        //-----------------------------------------------------------------------------------------------------------------

        //Show to users
        public static string GetArtistProfilePictureUrl(int artistId) => $"artists/{artistId}/profile.jpg";
        public static string GetArtistBannerPictureUrl(int artistId) => $"artists/{artistId}/banner.jpg";

        public static string GetAlbumCoverPictureUrl(int albumId) => $"albums/{albumId}.jpg";

        public static string GetPlaylistPictureUrl(int playlistId) => $"playlists/{playlistId}.jpg";

        public static string GetSongSoundUrl(int songId,int albumId, string bucketName) => $"https://{bucketName}.s3.amazonaws.com/songs/album_{albumId}/{songId}.mp4";
       
    }
}