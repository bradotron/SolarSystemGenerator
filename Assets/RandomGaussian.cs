using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class GaussianRandom
{
  public static float NextGaussian(RandomGaussianGeneratorProperties properties)
  {
    float u1 = Random.value;
    float u2 = Random.value;

    float randomStdNormal = Mathf.Sqrt(-2.0f * Mathf.Log(u1)) * Mathf.Sqrt(2.0f * Mathf.PI * u2);
    float randomNormal = properties.mean + properties.stddev * randomStdNormal;

    return properties.useMinMax ? Mathf.Clamp(randomNormal, properties.min, properties.max) : randomNormal;
  }
}
