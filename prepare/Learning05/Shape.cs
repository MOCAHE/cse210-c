using System;
using System.Drawing;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor
    {
        get { return _color; }
        set { _color = value; }
    }

    public abstract double GetArea();
}

// using System;

// public class Shape
// {
//     private string _color;

//     //Default Constructor
//     public Shape()
//     { }

//     //Constructor
//     public Shape(string color)
//     {
//         _color = color;
//     }

//     //Encontré gracias CHATGPT
//     //que hay PROPIEDADES
//     //y simplifican el uso de
//     //getters and setters sin perder
//     //el encapsulamiento.
//     public string Color
//     {
//         get { return _color; }
//         set { _color = value; }
//     }

//     // //Get for _color
//     // public string GetColor()
//     // {
//     //     return _color;
//     // }

//     // //Set for _color
//     // public void SetColor(string color)
//     // {
//     //     _color = color;
//     // }

//     public virtual double GetArea()
//     {
//         return 0.0;
//     }
// }