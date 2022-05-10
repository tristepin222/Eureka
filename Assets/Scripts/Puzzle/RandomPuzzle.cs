using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RandomPuzzle : MonoBehaviour
{
    private const int MIN = 0;
    private const int MAX_SINGLE_GATE = 1;
    private const int MAX_TWO_GATE = 5;
    //randomize every gates it's sees
    public void Randomize(MapInfo mapInfo)
    {
       

        foreach(GateManager gateManager in mapInfo.SingleGates)
        {
            int RandomSingleGate = Random.Range(MIN, MAX_SINGLE_GATE);
            switch (RandomSingleGate)
            {
                case 0:
                    gateManager.logicGate.type = LogicGate.LogicGateType.Buffer;
                    break;
                case 1:
                    gateManager.logicGate.type = LogicGate.LogicGateType.NOT;
                    break;
            }

        }
        foreach (GateManager gateManager in mapInfo.twoGates)
        {
            int RandomTwoGate = Random.Range(MIN, MAX_TWO_GATE);
            switch (RandomTwoGate)
            {
                case 0:
                    gateManager.logicGate.type = LogicGate.LogicGateType.AND;
                    break;
                case 1:
                    gateManager.logicGate.type = LogicGate.LogicGateType.OR;
                    break;
                case 2:
                    gateManager.logicGate.type = LogicGate.LogicGateType.NAND;
                    break;
                case 3:
                    gateManager.logicGate.type = LogicGate.LogicGateType.NOR;
                    break;
                case 4:
                    gateManager.logicGate.type = LogicGate.LogicGateType.XOR;
                    break;
                case 5:
                    gateManager.logicGate.type = LogicGate.LogicGateType.XNOR;
                    break;
            }

        }
        
    }
}
