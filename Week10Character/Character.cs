namespace Week10Character;

public enum CharacterStatus {Active, Wounded, Dead}
public enum EventType {Rest, Combat, Healing, Treasure}
public class Character 
{ public string Name { get; set;} 
    public string Role { get; set;}
    public int Level { get; set; } 
    public int HP { get; set; } 
    public int Gold { get; set; }
    public CharacterStatus Status { get; set; }
    public override string ToString() => 
        $"{Name} ({Role}, Рівень: {Level}) | HP: {HP} | Золото: {Gold} | Стан: {Status}";
}