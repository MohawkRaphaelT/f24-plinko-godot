using Godot;
using System;

public partial class ScoreUI : Label
{
	private int score;

	public override void _Ready()
	{
		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		Text = $"SCORE: {score}";
	}

	public void AddScore(int points)
	{
		score += points;
		UpdateDisplay();
	}

}
