using Godot;
using System;

public partial class Player : CharacterBody2D
{


    [Export]
    private float _jumpVelocity = - 800.0f; 

    [Export]
    private float _gravityMultiplier = 3.0f;

    public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();


    private RectangleShape2D _defaultShape = GD.Load<RectangleShape2D>("res://CollisionShapes/dino_default.tres");
    private RectangleShape2D _crouchShape = GD.Load<RectangleShape2D>("res://CollisionShapes/dino_crouching.tres");
    public override void _PhysicsProcess(double delta)
    {
    }

}
