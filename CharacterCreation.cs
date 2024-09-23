﻿namespace TheLostWorld;

public class CharacterCreation
{
    ValidateInput validateInput =  new ValidateInput();
    public CharacterCreation()
    {
        int countId = Game.currentPlayer.id + 1;
        Console.WriteLine("It's time to create your character");
        
        Console.WriteLine("Do you remember your name?");//Name Prompt
        Game.currentPlayer.name = validateInput.ValidateName();

        Console.WriteLine("What is your heritage(race)");
        Game.currentPlayer.race = validateInput.ValidateRace();

        Console.WriteLine("How did you train?");
        Game.currentPlayer.playerClass = validateInput.ValidateClass();

        Console.WriteLine("Where are you from(origin)");
        Game.currentPlayer.origin = validateInput.ValidateOrigin();

        Game.currentPlayer.id = countId;
        Game.currentPlayer.health = 10;
        Game.currentPlayer.gold = 10;
        
        Game.currentPlayer.CalculateStats();

        Console.WriteLine($"Player created: {Game.currentPlayer.name}, {Game.currentPlayer.race}, {Game.currentPlayer.playerClass}");

        Game.Save();
    }
}
