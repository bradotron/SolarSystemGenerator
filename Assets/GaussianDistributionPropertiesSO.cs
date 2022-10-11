using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGaussianGeneratorProperties : ScriptableObject
{
  public float mean;
  public float stddev; // 99.9% of values are within 3.5 stddev, but we can also use a specific min/max
  public bool useMinMax;
  public float min;
  public float max;
}
