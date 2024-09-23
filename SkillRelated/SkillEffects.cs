namespace TheLostWorld;

public class SkillEffects
{
    public void ApplySkillEffects(string skill)
    {
        switch (skill.ToLower())
        {
            case "heal":
                Game.currentPlayer.health += 10; // Heal 10 HP
                Game.currentPlayer.mana -= 5;
                if (Game.currentPlayer.health > Game.currentPlayer.maxHealth)
                {
                    Game.currentPlayer.health = Game.currentPlayer.maxHealth;
                }
                Console.WriteLine("You feel reinvigorated. +10 Health.");
                break;

                // Add more item types and their effects here
        }
    }

    public double ApplySkillEffects(string skill, ref double eHealth)
{
    switch (skill.ToLower())
    {
        case "fireball":
            if (Game.currentPlayer.mana >= 5)
            {
                Game.currentPlayer.mana -= 5;
                eHealth -= 5;
            }
            else
            {
                Console.WriteLine("You do not have enough mana to cast the spell");
            }
            Console.WriteLine("You cast fireball on the enemy");
            break;

        // Add more skill effects here
    }
    return eHealth; // Return updated eHealth
}

}
