namespace Week10Character;

public enum CharacterStatus {Active, Wounded, Dead}
public enum EventType {Rest, Combat, Healing, Tressure}
public class Character 
{ public string Name { get; set;} 
    public string Role { get; set;}
    public int Level { get; set; } 
    public int HP { get; set; } 
    public int Gold { get; set; }
    public Character(string name, string role, int level, int hp, int gold, CharacterStatus status = CharacterStatus.Active) 
    {
        Name = name;
        Role = role; 
        Level = level; 
        HP = hp;
        Gold = gold;
        
    } 
}