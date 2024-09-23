namespace TheLostWorld;

public class EverySkill
{
    public List<string> Skills { get; set; } = new List<string>();

    // Add item or update count
    public void AddSkill(string skillName)
    {
        var skill = Skills.FirstOrDefault(i => i == skillName);
        if (skill == null)
        {
            Skills.Add(new string(skillName)); // Add new item if it doesn't exist
        }
        else
        {
            Console.WriteLine("You already have this skill");
        }
    }

    // Use an item

    // Display inventory
    public void DisplaySkills()
    {
        if (Skills.Count == 0)
        {
            Console.WriteLine("You have no skills");
        }
        else
        {
            foreach (var skill in Skills)
            {
                Console.WriteLine(skill);
            }
        }
    }

    public bool UseSkill(string skillName)
    {
        SkillEffects applyEffects = new SkillEffects();
        // Check if the player has the skill
        var skill = Game.currentPlayer.skills.Skills.FirstOrDefault(i => i == skillName);

        if (skill != null)
        {
            applyEffects.ApplySkillEffects(skill); // Apply the skill's effect, e.g., healing, mana, etc.
            return true; // Indicate the item was used successfully
        }

        return false; // Skill not found
    }

    public bool UseCombatSkill(string skillName, ref double eHealth)
    {
        SkillEffects applyEffects = new SkillEffects();
        // Check if the player has the skill
        var skill = Game.currentPlayer.skills.Skills.FirstOrDefault(i => i == skillName);

        if (skill != null)
        {
            eHealth = applyEffects.ApplySkillEffects(skill, ref eHealth); // Update eHealth after skill use
            return true; // Indicate the item was used successfully
        }

        return false; // Skill not found
    }


}
