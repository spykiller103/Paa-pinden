using System;

public class Recipe : Post
{
    public string RecipeName { get; set; }
    public TimeOnly TimeUsage { get; set; }
	public string Mask { get; set; }
	public double KnittingNeedleSize { get; set; }

}
