﻿
namespace UserManagement.Models;

public class City
{
    public string Name{ get; set; }

    public City(string name)
    {
        Name = name;
    }

    public override string ToString() => $"{Name}";
}
