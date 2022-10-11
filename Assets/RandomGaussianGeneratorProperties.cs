using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaussianDistributionPropertiesSO : ScriptableObject
{
  private float mean;
  private float stddev; // 99.9% of values are within 3.5 stddev, but we can also use a specific min/max
  private bool useMinMax;
  private float min;
  private float max;
}
