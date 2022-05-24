using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInfo : MonoBehaviour
{
    /// <summary>
    /// display the list of gates from the current map, single gates only have one input, two gates have two inputs
    /// </summary>
    [SerializeField] public List<GateManager> SingleGates = new List<GateManager>();
    [SerializeField] public List<GateManager> twoGates = new List<GateManager>();
}
