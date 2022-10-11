using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemGenerator
{
  private RandomGaussianGeneratorProperties starNumberGeneratorProperties;
  private RandomGaussianGeneratorProperties planetNumberGeneratorProperties;

  public SolarSystem GenerateSolarSystem()
  {
    SolarSystem solarSystem = new SolarSystem();

    int numStars = (int)Mathf.Floor(GaussianRandom.NextGaussian(starNumberGeneratorProperties));
    int numPlanets = (int)Mathf.Floor(GaussianRandom.NextGaussian(planetNumberGeneratorProperties));

    return solarSystem;
  }
}
