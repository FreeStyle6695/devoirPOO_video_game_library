using devoirPOO_video_game_library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace devoirPOO_video_game_library.Classes;
public class VideoGame : IVideoGame
{
    public string Title { get; set; }
    public string Platform { get; set; }
    public string Type { get; set; }
    public int ReleaseYear { get; set; }
    public bool IsMultiplayer { get; set; }
    public bool IsFavorite { get; set; }
    public bool IsHacked { get; set; }
    public string Statut { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public VideoGame() { }
    public VideoGame(string title, string plateform, string type, int releaseYear, bool isMultiplayer, bool isFavorite, bool isHacked, string statut, string description, string imagePath)
    {
        Title = title;
        Platform = plateform;
        Type = type;
        ReleaseYear = releaseYear;
        IsMultiplayer = isMultiplayer;
        IsFavorite = isFavorite;
        IsHacked = isHacked;
        Statut = statut;
        Description = description;
        ImagePath = imagePath;
    }
}