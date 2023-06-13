
using AreaCalculator;

double area = 0;
Console.WriteLine("Введите тип фигуры (0-треугольник, 1 - круг)");
switch (Convert.ToInt32(Console.ReadLine())) {
    case 0:
        Triangle triangle = new Triangle();
        Console.WriteLine("Введите первую сторону: ");
        triangle.line1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите вторую сторону: ");
        triangle.line2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите третью сторону: ");
        triangle.line3 = Convert.ToDouble(Console.ReadLine());

        area = triangle.CalculateArea();
        break;
    case 1:
        Round round = new Round();
        Console.WriteLine("Введите радиус: ");
        round.radius = Convert.ToDouble(Console.ReadLine());

        area = round.CalculateArea();
        break;
}


Console.WriteLine($"Площадь равна: {area}");
Console.ReadLine();

//SELECT Products.Name, Categories.Name
//FROM Products
//LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
//LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.Id
//ORDER BY Products.Name, Categories.Name