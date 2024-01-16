﻿namespace BowlingScoreInterface.Models;

/// <summary>
/// Class to represent the model of the game page.
/// </summary>
public class Game
{
    public List<string> PlayersNames { get; set; }
    public int NumberOfRounds { get; set; }

    public static readonly int MaxPlayers;

    public Game(Home sartingParameter)
    {
        PlayersNames = sartingParameter.Players;
        NumberOfRounds = sartingParameter.NumberOfRounds;
    }

    public Game() : this(new Home())
    {
        PlayersNames = new List<string>() {"Player 1"};
        NumberOfRounds = 1;
    }
}
