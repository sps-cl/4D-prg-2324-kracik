using System;
namespace SchoolPrep{

abstract class GameObject {
    protected string name;
    public void Move() {
        
    }
}
//rozhraní se implementujou
interface IRendarable {
    void Render();
}
class Square : IRendarable {
    private int x;

    private void Render() {
        console.WriteLine("renderuju");

    }
}
class Rectangle {
    private int w;
    private int h;

    private void Render() {
        console.WriteLine("renderuju");

    }
    private void ChangeShape() {
        console.WriteLine("měním");
    }

}
class Program {
    public static void Main (string[] args) {
        Rectangle r1 = new Rectangle();
        Square s1 = new Square();
    }
}

}