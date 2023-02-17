namespace ZombieSurvivor.Fantasy.Core;

public sealed record Survivor(string Name)
{
    public int Wounds { get; set; }
    public bool IsDead { get; set; }

    public void TakeWounds(int v)
    {
        Wounds += v;
        IsDead = Wounds >= 2;
    }
}