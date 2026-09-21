using NUnit.Framework;
using Ucu.Poo.Exercise;
public class TrueValueTest
{
//Test True
    [Test]
    public void Value_WhenIsTrueValue()
    {
        // Arrange
        ILogicValue trueValue = new TrueValue();

        // Act
        bool result = trueValue.Value;

        // Assert
        Assert.That(result, Is.EqualTo(true));
    }
}