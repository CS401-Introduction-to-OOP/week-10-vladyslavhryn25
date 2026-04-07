namespace Week10Character;

public class GameEvent
{
    public int TurnNumber { get; set; }
    public string Description { get; set; }
    public EventType Type { get; set; }
    public int StatChange { get; set; }

    public override string ToString() => 
        $"Хід {TurnNumber}: [{Type}] {Description} (Зміна статів: {StatChange})";
}