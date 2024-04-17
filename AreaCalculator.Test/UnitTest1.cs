using Xunit;

public class AreaCalculatorTestCicrle
{
    [Fact]
    public void AreaCircleTest_5()
    {
        //Arrange
        IShape circle = new Circle(5);
        double expect = 78.54;
        //Act
        double actual = circle.Area();
        //Assert
        Assert.Equal(expect, actual,2);
    }
    [Fact]
    public void AreaCicrleTest_11()
    {
        //Arrange
        IShape circle = new Circle(11);
        double expect = 380.13;
        //Act
        double actual = circle.Area();
        //Assert
        Assert.Equal(expect, actual,2);
    }
}

public class AreaCalculatorTestTriangle
{
    [Fact]
    public void AreaTriangleTestIntegers()
    {
        //Arrange
        Triangle triangle = new Triangle(4,7,5);
        double expect = 9.8;
        //Act
        double actual = triangle.Area();
        //Assert
        Assert.Equal(expect, actual,2);
    }
    [Fact]
    public void AreaTriangleTestFractional()
    {
        //Arrange
        IShape triangle = new Triangle(2.6,5.2,4.1);
        double expect = 5.26;
        //Act
        double actual = triangle.Area();
        //Assert
        Assert.Equal(expect, actual,2);
    }
    [Fact]
    public void AreaTriangleTestRightAngle()
    {
        //Arrange
        Triangle triangle = new Triangle(3,4,5);
        //Act
        var result = triangle.IsRightAngled();
        //Assert
        Assert.True(result);
    }
}