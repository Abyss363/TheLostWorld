namespace TheLostWorld;

[Serializable]
public class Player
{
    //Core
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
    public int maxHealth { get; set; } = 10;
    public int health { get; set; } = 10;
    public int mana { get; set; } = 10;
    public int maxMana { get; set; } = 10;
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
}
