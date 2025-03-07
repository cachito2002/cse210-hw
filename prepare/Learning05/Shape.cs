using System;
using System.Collections.Generic;

public class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual float GetArea()
    {
        return 0.0f;
    }
    
}

