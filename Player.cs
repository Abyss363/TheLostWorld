namespace TheLostWorld;

[Serializable]
public class Player
{
    //Core
    public string? name;
    public string? race;
    public string? _class;
    public string? origin;
    public int id;
    public int level;
    public int exp;
    public int maxExp;
    public int attributePoints;
    
    //Attributes
    public int vitality;
    public int dexterity;
    public int agility;
    public int strength;
    public int mind;
    public int intelligence;
    
    //Stats
    public int maxHealth;
    public int health;
    public int mana;
    public int maxMana;
    public int stamina;
    public int defence;
    public int finalDefence;
    public int attack;
    public int magicAttack;
    public int finalMagicDamage;
    public int finalDamage;

    //Afinities
    public int fire;
    public int solar;
    public int wind;
    public int hurricane;
    public int water;
    public int ice;
    public int earth;
    public int metal;
    public int gravity;
    public int lightning;
    public int plasma;
    public int sound;
    public int psychic;
    public int light;
    public int holy;
    public int shadow;
    public int dark;
    public int space;
    public int _void;
    public int time;
    public int domain;
    public int spaceTime;

    //ClassExps
    public int fighter;//advances to warrior
    public int fighterLevel;
    public int fighterMaxExp;

    public int mage;//advances to sorceror
    public int mageLevel;
    public int mageMaxExp;

    public int marksman;//advances to ranger
    public int marksmanLevel;
    public int marksmanMaxExp;

    public int rogue;//advances to assasin
    public int rogueLevel;
    public int rogueMaxExp;

    public int tank;//advances to berserker
    public int tankLevel;
    public int tankMaxExp;

    public int invoker;//advances to necromancer
    public int invokerLevel;
    public int invokerMaxExp;
    //General
    public int gold = 0;


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
