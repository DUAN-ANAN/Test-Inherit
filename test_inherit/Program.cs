// See https://aka.ms/new-console-template for more information

/*
 * demo: virtual、abstract、override
 * 
 * virtual：用於宣告一個方法、屬性或索引器是虛擬的，允許在衍生類別中進行方法的重寫。
 * abstract：用於宣告一個方法、屬性或索引器是抽象的，必須在衍生類別中進行實作，否則衍生類別也必須是抽象的。
 * override：用於在衍生類別中重寫基底類別的虛擬方法。
 * 
 * abstract vs virtual
 *      abstract 必須被子類實現，而virtual 可以被子類覆寫，也可以不被覆寫。
 *      abstract 必須定義在抽象類別（Abstract class）中，而虛擬方法可以定義在普通類別中。
 *  請參考 abstractVSvirtual .cs
 */

/*
 * 在這個範例中，我們定義了一個抽象的 Shape 類別，
 * 其中包含了一個虛擬的 Draw 方法和一個抽象的 CalculateArea 方法。
 * 然後，我們定義了 Circle 和 Rectangle 類別，並在其中分別重寫了 Draw 和 CalculateArea 方法。
 * 
 * 最後，在 Main 方法中，我們使用基底類別 Shape 的型別來宣告 shape1 和 shape2 對象，
 * 但實際上它們分別是 Circle 和 Rectangle 類別的實例。
 * 當我們呼叫 Draw 方法時，會根據實際執行時對象的型別，動態地決定要呼叫哪個版本的方法。
 */

Shape shape1 = new Circle(5);
Shape shape2 = new Rectangle(3, 4);

shape1.Draw(); // Output: Drawing a circle...
Console.WriteLine("Area of circle: {0}", shape1.CalculateArea());

shape2.Draw(); // Output: Drawing a rectangle...
Console.WriteLine("Area of rectangle: {0}", shape2.CalculateArea());

Console.ReadKey();

abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape...");
    }

    public abstract double CalculateArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle...");
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle...");
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}