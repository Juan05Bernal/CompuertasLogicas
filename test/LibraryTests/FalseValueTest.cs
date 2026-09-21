using NUnit.Framework;
using Ucu.Poo.Exercise;
public class FalseValueTest
{
//Test True
    [Test]
    public void Value_WhenIsFalseValue()
    {
        // Arrange
        ILogicValue falseValue = new FalseValue();

        // Act
        bool result = falseValue.Value;

        // Assert
        Assert.That(result, Is.EqualTo(false));
    }
}