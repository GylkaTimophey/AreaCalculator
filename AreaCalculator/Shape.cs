using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator {
    public abstract class Shape {
        public abstract double CalculateArea();
    }

    public class Triangle : Shape {
        public double line1;
        public double line2;
        public double line3;
        public override double CalculateArea() {
            if (line1 < 0 || line2 < 0 || line3 < 0) {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
            }
            if (line1 + line2 <= line3 || line1 + line3 <= line2 || line2 + line3 <= line1) {
                throw new ArgumentException("Треугольник не может быть построен на заданных сторонах");
            }
            if (IsRight()) {
                RightTriangle rt = new RightTriangle(this);
                return rt.CalculateArea();
            }
            double h = (line1 + line2 + line3) / 2;
            return Math.Sqrt(h * (h - line1) * (h - line2) * (h - line3));
        }
        public bool IsRight() {
            if (line1 > line2 && line1 > line3) {
                if (line1 * line1 == line2 * line2 + line3 * line3) {
                    return true;
                }
            }
            if (line2 > line1 && line2 > line3) {
                if (line2 * line2 == line1 * line1 + line3 * line3) {
                    return true;
                }
            }
            if (line3 > line1 && line3 > line2) {
                if (line3 * line3 == line1 * line1 + line2 * line2) {
                    return true;
                }
            }
            return false;
        }
    }

    public class RightTriangle : Triangle {
        public RightTriangle(Triangle triangle) {
            line1 = triangle.line1;
            line2 = triangle.line2;
            line3 = triangle.line3;
        }
        public override double CalculateArea() {
            if (line1 > line2 && line1 > line3) {
                return line2 * line3 / 2;
            }
            if (line2 > line1 && line2 > line3) {
                return line1 * line3 / 2;
            }
            if (line3 > line1 && line3 > line2) {
                return line1 * line2 / 2;
            }
            return 0;
        }
    }

    public class Round : Shape {
        public double radius;

        public override double CalculateArea() {
            if (radius < 0) {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }
            return Math.PI * radius * radius;
        }
    }

    //public class Square : Shape {
    //    public double side;

    //    public override double CalculateArea() {
    //        if (side < 0) {
    //            throw new ArgumentException("Стороны квадрата не могут быть отрицательными");
    //        }
    //        return side * side;
    //    }
    //}
}

