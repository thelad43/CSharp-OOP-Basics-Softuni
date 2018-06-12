namespace _04._Online_Radio_Database
{
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var songs = ReadSongs();
            PrintPlaylistResult(songs);
        }

        private static void PrintPlaylistResult(List<Song> songs)
        {
            Console.WriteLine($"Songs added: {songs.Count}");

            var totalSeconds = songs.Select(s => s.Seconds).Sum();
            var secondsToMinutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;
            var totalMinutes = songs.Select(s => s.Minutes).Sum() + secondsToMinutes;
            var minutesToHours = totalMinutes / 60;
            var minutes = totalMinutes % 60;
            var hours = minutesToHours;

            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }

        private static List<Song> ReadSongs()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                var songInfo = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var indexOfTimeSeparator = songInfo.LastOrDefault().IndexOf(":");

                    if (songInfo.Length < 3 || indexOfTimeSeparator < 1 || indexOfTimeSeparator > songInfo[2].Length - 2)
                    {
                        throw new InvalidSongException();
                    }

                    songInfo = string.Join(";", songInfo).Split(';', ':');

                    var artistName = songInfo[0];
                    var songName = songInfo[1];
                    var minutes = int.Parse(songInfo[2]);
                    var seconds = int.Parse(songInfo[3]);

                    songs.Add(new Song(artistName, songName, minutes, seconds));
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            return songs;
        }
    }
}