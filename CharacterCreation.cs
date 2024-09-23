namespace TheLostWorld;

public class CharacterCreation
{
    ValidateInput validateInput = new ValidateInput();
    public CharacterCreation()
    {
        Game.lastId++;
        Game.currentPlayer.id = Game.lastId;

        Console.WriteLine("It's time to create your character");

        Console.WriteLine("Do you remember your name?");//Name Prompt
        Game.currentPlayer.name = validateInput.ValidateName();

        Console.WriteLine("What is your heritage(race)");
        Game.currentPlayer.race = validateInput.ValidateRace();

        Console.WriteLine("How did you train?");
        Game.currentPlayer.playerClass = validateInput.ValidateClass();

        Console.WriteLine("Where are you from(origin)");
        Game.currentPlayer.origin = validateInput.ValidateOrigin();

        Game.currentPlayer.health = 10;
        Game.currentPlayer.gold = 9999;

        Game.currentPlayer.CalculateStats();
        Game.currentPlayer.skills.AddSkill("heal");
        Game.currentPlayer.skills.AddSkill("fireball");

        Console.WriteLine($"Player created: {Game.currentPlayer.name}, {Game.currentPlayer.race}, {Game.currentPlayer.playerClass}");

        Game.Save();
        Game.SaveLastId();
    }
}
