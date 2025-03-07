using System;
using System.Collections.Generic;

public class Rectangle : Shape
{
    private float _length;
    private float _width;

    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public float GetLength()
    {
        return _length;
    }
    public float GetWidth()
    {
        return _width;
    }

    public void SetLength(float length)
    {
        _length = length;
    }

    public void SetWidth(float width)
    {
        _width = width;
    }

    public override float GetArea()
    {
        return _length * _width;
    }

    
}