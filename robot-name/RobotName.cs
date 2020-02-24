using System.Linq;
using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly List<string> existingNames = new List<string>();
    private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string Digits = "0123456789";

    private string name = null;
    public string Name
    {
        get
        {
            name = name?? GenerateANonExistingRobotName();
            return name;
        }
    }

    public void Reset()
    {
        existingNames.Remove(name);
        name = null;
    }

    private string GenerateANonExistingRobotName() {
         var isNonExistingNameGenerated = false;
         var robotName = "";
         while(!isNonExistingNameGenerated) {
             robotName = GenerateARobotName();
             if(!existingNames.Contains(robotName)) {
                 existingNames.Add(robotName);
                 isNonExistingNameGenerated = true;
             }
         }
         return robotName;
    }

    private string GenerateARobotName() {
        var random = new Random();
        var name = new string(Enumerable.Repeat(Characters, 2).Select(s => s[random.Next(s.Length)]).ToArray()) +
            new string(Enumerable.Repeat(Digits, 3).Select(d => d[random.Next(d.Length)]).ToArray());
        return name;
    }
}