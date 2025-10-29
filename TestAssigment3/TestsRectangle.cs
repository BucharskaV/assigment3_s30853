namespace TestAssigment3;
using Assigment3;

public class TestsRectangle
{
    [Test]
    public void CalculateArea_WithLength4AndWidth8_ReturnsCorrectValue()
    {
        var rectangle = new Assigment3.TestsRectangle(4, 8);
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(32.000).Within(0.001));
    }
    
    [Test]
    public void CalculateVolume_WithLength4AndWidth8_ReturnsCorrectValue()
    {
        var rectangle = new Assigment3.TestsRectangle(4, 8);
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001));
    }
    
    [Test]
    public void CreateInstance_WithZeroValues_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var rectangle = new Assigment3.TestsRectangle(0, 8);
        });
        Assert.Throws<ArgumentException>(() =>
        {
            var rectangle = new Assigment3.TestsRectangle(4, 0);
        });
    }
    
    [Test]
    public void CreateInstance_WithNegativeValues_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var rectangle = new Assigment3.TestsRectangle(-4, 8);
        });
        Assert.Throws<ArgumentException>(() =>
        {
            var rectangle = new Assigment3.TestsRectangle(4, -8);
        });
    }
}