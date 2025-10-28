namespace TestAssigment3;
using Assigment3;

public class Tests
{
    [Test]
    public void Sphere_CalculateArea_ReturnsCorrectValue()
    {
        var sphere = new Sphere(5);
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }
    
    [Test]
    public void Sphere_CalculateVolume_ReturnsCorrectValue()
    {
        var sphere = new Sphere(5);
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(104.719).Within(0.001));
    }
    
    [Test]
    public void Sphere_CalculateArea_WithZeroRadius_ReturnsCorrectValue()
    {
        var sphere = new Sphere(0);
        Assert.That(sphere.CalculateArea(), Is.EqualTo(0));
    }

    [Test]
    public void Sphere_CalculateVolume_WithZeroRadius_ReturnsCorrectValue()
    {
        var sphere = new Sphere(0);
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void Sphere_WithNegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var sphere = new Sphere(-1);
        });
    }
    
}