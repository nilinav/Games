using Godot;
using System;

public partial class Ball : Node2D
{
	private CharacterBody2D BallCharacterBody2D;
	private Vector2 velocity = new Vector2(); 
	private int Speed;
	 
	public override void _Ready()
	{
		BallCharacterBody2D = GetNode<CharacterBody2D>("CharacterBody2D");
		
		velocity.X = 0;
		Speed = 200;
	}

	public override void _Process(double delta)
	{
		Movement(BallCharacterBody2D, (float)delta);
	}
	private void Movement(CharacterBody2D BallCharacterBody2D, float delta)
	{


		if (Input.IsActionJustPressed("ui_accept"))
		{

			if(velocity.X <= 0)
			{
				velocity.X = 1;
				return;
			}
			if(velocity.X > 0)
			{
				velocity.X = -1;
				return;
			}
		}


        velocity = velocity.Normalized() * Speed * delta ;
		BallCharacterBody2D.Position += velocity;
	
	}
}
