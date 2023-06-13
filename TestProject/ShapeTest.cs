using AreaCalculator;

namespace TestProject {
    public class ShapeTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TriangleTest1() {
            try {
                Triangle triangle = new Triangle();
                triangle.line1 = 1;
                triangle.line2 = 2;
                triangle.line3 = 3;
                triangle.CalculateArea();
            }
            catch {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [Test]
        public void TriangleTest2() {
            try {
                Triangle triangle = new Triangle();
                triangle.line1 = -1;
                triangle.line2 = 5;
                triangle.line3 = 5;
                triangle.CalculateArea();
            }
            catch {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [Test]
        public void TriangleTest3() {
            Triangle triangle = new Triangle();
            triangle.line1 = 3;
            triangle.line2 = 4;
            triangle.line3 = 5;
            var answer = triangle.CalculateArea();
            Assert.IsTrue(answer == 6);
        }
        [Test]
        public void TriangleTest4() {
            Triangle triangle1 = new Triangle();
            triangle1.line1 = 7;
            triangle1.line2 = 8;
            triangle1.line3 = 9;
            Triangle triangle2 = new Triangle();
            triangle2.line1 = 9;
            triangle2.line2 = 8;
            triangle2.line3 = 7;
            Assert.IsTrue(triangle1.CalculateArea() == triangle2.CalculateArea());
        }
        [Test]
        public void RoundTest1() {
            Round round = new Round();
            round.radius = 1;
            Assert.IsTrue(round.CalculateArea() == Math.PI);
        }
        [Test]
        public void RoundTest2() {
            Round round1 = new Round();
            round1.radius = 7;
            Round round2 = new Round();
            round2.radius = 7;
            Assert.IsTrue(round1.CalculateArea() == round1.CalculateArea());
        }
        [Test]
        public void RoundTest3() {
            try {
                Round round = new Round();
                round.radius = -1;
                round.CalculateArea();
            }
            catch {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}