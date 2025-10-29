namespace TestAssigment3;
using Assigment3;

public class TestsSphere
{
    [Test]
    public void CalculateArea_WithRadius5_ReturnsCorrectValue()
    {
        var sphere = new Sphere(5);
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }
    
    [Test]
    public void CalculateVolume_WithRadius5_ReturnsCorrectValue()
    {
        var sphere = new Sphere(5);
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }
    
    [Test]
    public void CreateInstance_WithZeroRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var sphere = new Sphere(0);
        });
    }
    
    [Test]
    public void CreateInstance_WithNegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var sphere = new Sphere(-1);
        });
    }
    
}