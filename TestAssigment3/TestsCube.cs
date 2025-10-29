namespace TestAssigment3;
using Assigment3;

public class TestsCube
{
    [Test]
    public void CalculateArea_WithSide5_ReturnsCorrectValue()
    {
        var cube = new Assigment3.TestsCube(5);
        Assert.That(cube.CalculateArea(), Is.EqualTo(150.000).Within(0.001));
    }
    
    [Test]
    public void CalculateVolume_WithSide5_ReturnsCorrectValue()
    {
        var cube = new Assigment3.TestsCube(5);
        Assert.That(cube.CalculateVolume(), Is.EqualTo(125.000).Within(0.001));
    }
    
    [Test]
    public void CreateInstance_WithZeroSide_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var cube = new Assigment3.TestsCube(0);
        });
    }
    
    [Test]
    public void CreateInstance_WithNegativeSide_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var cube = new Assigment3.TestsCube(-5);
        });
    }
}