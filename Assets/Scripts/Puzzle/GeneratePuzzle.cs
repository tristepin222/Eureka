using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GeneratePuzzle : MonoBehaviour
{
    //minimum random number
    private const int MIN = 0;
    //maximum random number for gates with one inputs
    private const int MAX_SINGLE_GATE = 1;
    //maximum random number for gates with two inputs
    private const int MAX_TWO_GATE = 5;
    //since gates are static, and there won't be more gates in the future, these are constant int
    //index for custom gates
    private int index = 0;


    /// <summary>
    /// randomize every gates given to it, changes depending the current difficulty
    /// </summary>
    /// <param name="mapInfo"></param>
    public void Randomize(MapInfo mapInfo)
    {
       
        //generate a random gate for every gates with a single input only, from mapinfo
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
        //generate a random gate for every gates with two inputs only, from mapinfo
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
    /// <summary>
    /// generate every gates with the custom puzzle, changes depending the current difficulty, the type stays the same.
    /// </summary>
    /// <param name="mapInfo"></param>
    /// <param name="mapinfoSaved"></param>
    public void CustomPuzzle(MapInfo mapInfo, MapInfo mapinfoSaved)
    {

        foreach (GateManager gateManager in mapInfo.SingleGates)
        {

            gateManager.logicGate.type = mapinfoSaved.SingleGates[index].logicGate.type;
          
            index++;
        }
        index = 0;
        foreach (GateManager gateManager in mapInfo.twoGates)
        {
            gateManager.logicGate.type = mapinfoSaved.twoGates[index].logicGate.type;
            index++;
        }
    }
}
