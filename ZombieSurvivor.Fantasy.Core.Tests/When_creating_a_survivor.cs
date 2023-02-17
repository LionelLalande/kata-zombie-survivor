namespace ZombieSurvivor.Fantasy.Core.Tests;

public class When_creating_a_survivor
{
    private Survivor Survivor { get; }
    private const string _survivorName = "Surviver Name";

    public When_creating_a_survivor() =>
        Survivor = new(_survivorName);

    [Fact]
    public void Then_survivor_has_a_non_empty_name()
    {
        Assert.NotEmpty(Survivor.Name);
    }
    
    [Fact]
    public void Then_survivor_has_a_right_name()
    {
        Assert.Equal(_survivorName, Survivor.Name);
    }

    [Fact]
    public void Then_survivor_has_a_zero_wounds()
    {
        Assert.Equal(0, Survivor.Wounds);
    }

    [Fact]
    public void Then_survivor_is_dead()
    {
        Survivor.TakeWounds(2);
        Assert.True(Survivor.IsDead);
    }
}