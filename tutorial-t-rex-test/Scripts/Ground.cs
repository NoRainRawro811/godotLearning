using Godot;
using System;

public partial class Ground : Node2D
{
    [Export]
    private float _speed = -125.0f;

    private StaticBody2D _staticBody2D;
    private StaticBody2D _staticBody2D2;
    private int _textureWidth;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _staticBody2D = GetNode<StaticBody2D>("Ground_1");
        _staticBody2D2 = GetNode<StaticBody2D>("Ground_2");
        _textureWidth = _staticBody2D.GetNode<Sprite2D>("GroundSprite").Texture.GetWidth();

        _staticBody2D2.GlobalPosition = _staticBody2D2.GlobalPosition with { X = _staticBody2D.GlobalPosition.X + _textureWidth};
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        _staticBody2D.GlobalPosition += new Vector2(_speed * (float)delta, 0);
        _staticBody2D2.GlobalPosition += new Vector2(_speed * (float)delta, 0);

        if(_staticBody2D.GlobalPosition.X < -_textureWidth)
        {
            _staticBody2D.GlobalPosition = _staticBody2D2.GlobalPosition + new Vector2(_textureWidth, 0);
        }
        if (_staticBody2D2.GlobalPosition.X < -+_textureWidth)
        {
            _staticBody2D2.GlobalPosition = _staticBody2D.GlobalPosition + new Vector2(_textureWidth, 0);
        }
    }
}