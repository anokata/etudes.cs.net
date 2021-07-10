using System;

public class SpaceAge
{
    private int seconds;

    private const double EarthYearSeconds = 31557600; 
    private const double MercuryYearSeconds = 0.2408467 * EarthYearSeconds;
    private const double VenusYearSeconds = 0.61519726 * EarthYearSeconds;
    private const double MarsYearSeconds = 1.8808158 * EarthYearSeconds; 
    private const double JupiterYearSeconds = 11.862615 * EarthYearSeconds; 
    private const double SaturnYearSeconds = 29.447498 * EarthYearSeconds; 
    private const double UranusYearSeconds = 84.016846 * EarthYearSeconds; 
    private const double NeptuneYearSeconds = 164.79132 * EarthYearSeconds;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => seconds / EarthYearSeconds;
    public double OnMercury() => seconds / MercuryYearSeconds;
    public double OnVenus() => seconds / VenusYearSeconds;
    public double OnMars() => seconds / MarsYearSeconds;
    public double OnJupiter() => seconds / JupiterYearSeconds;
    public double OnSaturn() => seconds / SaturnYearSeconds;
    public double OnUranus() => seconds / UranusYearSeconds;
    public double OnNeptune() => seconds / NeptuneYearSeconds;
}