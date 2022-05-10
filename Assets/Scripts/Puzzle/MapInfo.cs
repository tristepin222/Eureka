using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInfo : MonoBehaviour
{
    //display the list of gates from the current map, single gates only have one input, two gates have two inputs
    [SerializeField] public List<GateManager> SingleGates = new List<GateManager>();
    [SerializeField] public List<GateManager> twoGates = new List<GateManager>();
}
