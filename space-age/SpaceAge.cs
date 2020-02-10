using System;

public class SpaceAge
{
    private int _seconds;
    private const double OrbitalPeriodOfEarth = 365.25;
    private const double OrbitalPeriodOfEarthInSeconds = 31_557_600;

    private const double OrbitalPeriodOfMercuryInEarthYear = 0.2408467;

    private const double OrbitalPeriodOfVenusInEarthYear = 0.61519726;
    private const double OrbitalPeriodOfMarsInEarthYear = 1.8808158;
    private const double OrbitalPeriodOfJupiterInEarthYear = 11.862615;

    private const double OrbitalPeriodOfSaturnInEarthYear = 29.447498;
    private const double OrbitalPeriodOfUranusInEarthYear = 84.016846;
    private const double OrbitalPeriodOfNeptuneInEarthYear = 164.79132;
    

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds;
    }

    public double OnMercury()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfMercuryInEarthYear;
    }

    public double OnVenus()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfVenusInEarthYear;
    }

    public double OnMars()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfMarsInEarthYear;
    }

    public double OnJupiter()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfJupiterInEarthYear;
    }

    public double OnSaturn()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfSaturnInEarthYear;
    }

    public double OnUranus()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfUranusInEarthYear;
    }

    public double OnNeptune()
    {
        return _seconds/OrbitalPeriodOfEarthInSeconds/OrbitalPeriodOfNeptuneInEarthYear;
    }
}