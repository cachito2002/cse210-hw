using System;

public class Square : Shape
{
    private float _side;

    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    public float GetSide()
    {
        return _side;
    }

    public void SetSide(float side)
    {
        _side = side;
    }

    public override float GetArea()
    {
        return _side * _side;
    }
}