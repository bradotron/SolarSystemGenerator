using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGaussianTester : MonoBehaviour
{
  [SerializeField] private GameObject statPlotGO;
  private StatPlot statPlot;
    // Start is called before the first frame update
    void Start()
    {
        statPlot = statPlotGO.GetComponent<StatPlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
