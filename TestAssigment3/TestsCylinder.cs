namespace TestAssigment3;
using Assigment3;

public class TestsCylinder
{
    [Test]
    public void CalculateArea_WithRadius3AndHeight7_ReturnsCorrectValue()
    {
        var cylinder = new Assigment3.TestsCylinder(3, 7);
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
    }
    
    [Test]
    public void CalculateVolume_WithRadius3AndHeight7_ReturnsCorrectValue()
    {
        var cylinder = new Assigment3.TestsCylinder(3, 7);
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }
    
    [Test]
    public void CreateInstance_WithZeroValues_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var cylinder = new Assigment3.TestsCylinder(0, 7);
        });
        Assert.Throws<ArgumentException>(() =>
        {
            var cylinder = new Assigment3.TestsCylinder(7, 0);
        });
    }
    
    [Test]
    public void CreateInstance_WithNegativeValues_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var cylinder = new Assigment3.TestsCylinder(-3, 7);
        });
        Assert.Throws<ArgumentException>(() =>
        {
            var cylinder = new Assigment3.TestsCylinder(7, -3);
        });
    }
}