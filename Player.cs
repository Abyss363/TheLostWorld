namespace TheLostWorld;

[Serializable]
public class Player
{
    //Core
    public EveryItem inventory { get; set; } = new EveryItem(); // Add inventory
    public EverySkill skills { get; set; } = new EverySkill(); // Add Skills
    public string name { get; set; } = "";
    public string race { get; set; } = "";
    public string playerClass { get; set; } = "";
    public string origin { get; set; } = "";
    public int id { get; set; } = 0;
    public int level { get; set; } = 1;
    public int exp { get; set; } = 0;
    public int maxExp { get; set; } = 100;
    public int attributePoints { get; set; } = 0;

    //Attributes
    public int vitality { get; set; } = 1;
    public int dexterity { get; set; } = 1;
    public int agility { get; set; } = 1;
    public int strength { get; set; } = 1;
    public int mind { get; set; } = 1;
    public int intelligence { get; set; } = 1;

    //Stats
    public double maxHealth { get; set; } = 10;
    public double health { get; set; } = 10;
    public double mana { get; set; } = 10;
    public double maxMana { get; set; } = 10;
    public int stamina { get; set; } = 10;
    public int defence { get; set; } = 10;
    public int finalDefence { get; set; } = 10;
    public int attack { get; set; } = 10;
    public int magicAttack { get; set; } = 10;
    public int finalMagicDamage { get; set; } = 10;
    public int finalDamage { get; set; } = 10;

    //Afinities
    public int fire { get; set; } = 0;
    public int solar { get; set; } = 0;
    public int wind { get; set; } = 0;
    public int hurricane { get; set; } = 0;
    public int water { get; set; } = 0;
    public int ice { get; set; } = 0;
    public int earth { get; set; } = 0;
    public int metal { get; set; } = 0;
    public int gravity { get; set; } = 0;
    public int lightning { get; set; } = 0;
    public int plasma { get; set; } = 0;
    public int sound { get; set; } = 0;
    public int psychic { get; set; } = 0;
    public int light { get; set; } = 0;
    public int holy { get; set; } = 0;
    public int shadow { get; set; } = 0;
    public int dark { get; set; } = 0;
    public int space { get; set; } = 0;
    public int voidType { get; set; } = 0;
    public int time { get; set; } = 0;
    public int domain { get; set; } = 0;
    public int spaceTime { get; set; } = 0;

    //ClassExps
    public int fighter { get; set; } = 0;//advances to warrior
    public int fighterLevel { get; set; } = 1;
    public int fighterMaxExp { get; set; } = 50;

    public int mage { get; set; } = 0;//advances to sorceror
    public int mageLevel { get; set; } = 1;
    public int mageMaxExp { get; set; } = 50;

    public int marksman { get; set; } = 0;//advances to ranger
    public int marksmanLevel { get; set; } = 1;
    public int marksmanMaxExp { get; set; } = 50;

    public int rogue { get; set; } = 0;//advances to assasin
    public int rogueLevel { get; set; } = 1;
    public int rogueMaxExp { get; set; } = 50;

    public int tank { get; set; } = 0;//advances to berserker
    public int tankLevel { get; set; } = 1;
    public int tankMaxExp { get; set; } = 50;

    public int invoker { get; set; } = 0;//advances to necromancer
    public int invokerLevel { get; set; } = 1;
    public int invokerMaxExp { get; set; } = 50;

    //General
    public int gold { get; set; } = 0;
    public bool ranAway { get; set; } = false;
    public bool isInCombat = false;


    public void CalculateStats()
    {
        //race calculations come here

        //class calculations come here

        //basic calculations
        this.maxHealth = this.vitality * 5;
        this.maxMana = this.intelligence * 5;
        this.stamina = this.dexterity * 5;
        this.attack = (this.strength + this.agility) * 3;
        this.magicAttack = (this.mind * this.agility) * 3;
        this.maxExp = this.level * 100;

        fighterMaxExp = fighterLevel * 50;
        mageMaxExp = mageLevel * 50;
        marksmanMaxExp = marksmanLevel * 50;
        rogueMaxExp = rogueLevel * 50;
        tankMaxExp = tankLevel * 50;
        invokerMaxExp = invokerLevel * 50;
    }

    public void ShowInventory()
    {
        Console.WriteLine($"{name}'s Inventory:");
        inventory.DisplayInventory();
    }

    public void ShowSkills()
    {
        Console.WriteLine($"{name}'s Skills");
        skills.DisplaySkills();
    }

    public void UseItem()
    {
        bool success;
        ValidateInput validInput = new ValidateInput();

        // Display the player's inventory
        Game.currentPlayer.ShowInventory();

        Console.WriteLine("Enter the name of the item you want to use:");
        string itemName = validInput.ValidateItemName(); // Validate input

        // Try to use the item
        success = Game.currentPlayer.inventory.CombatUseItem(itemName);

        if (success)
        {
            Console.WriteLine($"You used {itemName}.");
        }
        else
        {
            Console.WriteLine($"You don't have {itemName} or cannot use it.");
        }
    }

    public void UseSkill()
    {
        ValidateInput validInput = new ValidateInput();

        // Display the player's inventory
        Game.currentPlayer.ShowSkills();

        Console.WriteLine("Enter the name of the item you want to use:");
        string skillName = validInput.ValidateItemName(); // Validate input

        // Try to use the item
        bool success = Game.currentPlayer.skills.UseSkill(skillName);

        if (success)
        {
            Console.WriteLine($"You used {skillName}.");
        }
        else
        {
            Console.WriteLine($"You don't have {skillName} or cannot use it.");
        }
    }

    public void UseSkill(ref double eHealth)
    {
        ValidateInput validInput = new ValidateInput();

        // Display the player's inventory
        Game.currentPlayer.ShowSkills();

        Console.WriteLine("Enter the name of the item you want to use:");
        string skillName = validInput.ValidateItemName(); // Validate input

        // Try to use the item
        bool success = Game.currentPlayer.skills.UseCombatSkill(skillName, ref eHealth);

        if (success)
        {
            Console.WriteLine($"You used {skillName}.");
        }
        else
        {
            Console.WriteLine($"You don't have {skillName} or cannot use it.");
        }
    }

    public void PlayerMenu()
    {
        ValidateInput validateInput = new ValidateInput();

        while (true)
        {
            Console.WriteLine($"HP: {this.health}");
            Console.WriteLine($"MP: {this.mana}");
            Console.WriteLine($"Stamina: {this.stamina}");

            Console.WriteLine("(U)se Item");
            Console.WriteLine("(I)nventory");
            Console.WriteLine("(S)how Skills");
            Console.WriteLine("(L)evels and Exp");
            Console.WriteLine("(E)xit Player Menu");

            string input = validateInput.ValidatePlayerOption();

            switch (input)
            {
                case "u":
                    UseItem();
                    break;
                case "i":
                    ShowInventory();
                    break;
                case "s":
                    UseSkill();
                    break;
                case "e":
                    return;

            }
        }
    }
}
