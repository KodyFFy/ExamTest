using static SampleText.Figures;

namespace TestProject1
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void triangle_area_1()
        {
            // Arrange
            double Cathet1 = 4;
            double Cathet2 = 3;
            double Hypotenuse = 5;

            double expectedArea = 6;

            // Act
            double actualArea = SampleText.Figures.triangle(Cathet1, Cathet2, Hypotenuse);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void circle_area_1()
        {
            // Arrange
            double Radius = 3;

            double expectedArea = 28.2743;

            // Act
            double actualArea = SampleText.Figures.circle(Radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}