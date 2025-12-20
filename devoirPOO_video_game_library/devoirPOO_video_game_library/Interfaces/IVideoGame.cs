using System;
using System.Collections.Generic;
using System.Text;

namespace devoirPOO_video_game_library.Interfaces;
internal interface IVideoGame
{
    public string Title { get; set; }
    public string Platform { get; set; }
    public string Type { get; set; }
    public int ReleaseYear { get; set; }
    public bool IsMultiplayer { get; set; }
    public bool IsFavorite { get; set; }
    public bool IsHacked { get; set; }
    public string Statut { get; set; }
}
