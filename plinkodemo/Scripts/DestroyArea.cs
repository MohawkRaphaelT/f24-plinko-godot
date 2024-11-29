using Godot;
using System;

public partial class DestroyArea : Area2D
{
    private void OnBodyEntered(Node2D body)
    {
        // Destroy object?
        body.QueueFree();
        //GD.Print($"Detroy object: {body.Name}");
    }
}
