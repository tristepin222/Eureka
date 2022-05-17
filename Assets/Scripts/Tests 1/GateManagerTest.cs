using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GateManagerTest : MonoBehaviour
{
    private LogicGate logicGate;
    [SerializeField] private GateManager gateManager;

    public GateManagerTest()
    {
        logicGate = new LogicGate();
        gateManager = new GateManager();
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GateManagerTestBufferWithTwoTrueInputs()
    {

        logicGate.type = LogicGate.LogicGateType.Buffer;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(true);
        gateManager.ChangeInput2(true);
        
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == true, "the output is true");
    }
    [UnityTest]
    public IEnumerator GateManagerTestNotWithOneTrueInput()
    {

        logicGate.type = LogicGate.LogicGateType.NOT;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(true);
        

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == false, "the output is false");
    }
    [UnityTest]
    public IEnumerator GateManagerTestAndWithOneTrueInput()
    {

        logicGate.type = LogicGate.LogicGateType.AND;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(true);


        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == false, "the output is false");
    }
    [UnityTest]
    public IEnumerator GateManagerTestOrWithOneTrueInput()
    {

        logicGate.type = LogicGate.LogicGateType.OR;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(true);


        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == true, "the output is true");
    }
    [UnityTest]
    public IEnumerator GateManagerTestNorWithOneFalseAndOneTrueInput()
    {

        logicGate.type = LogicGate.LogicGateType.NOR;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(false);
        gateManager.ChangeInput2(true);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == false, "the output is false");
    }
    [UnityTest]
    public IEnumerator GateManagerTestNandWithOneFalseAndOneTrueInput()
    {

        logicGate.type = LogicGate.LogicGateType.NAND;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(false);
        gateManager.ChangeInput2(true);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == true, "the output is true");
    }
    [UnityTest]
    public IEnumerator GateManagerTestXorWithOneFalseAndOneTrueInput()
    {

        logicGate.type = LogicGate.LogicGateType.XOR;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(false);
        gateManager.ChangeInput2(true);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == true, "the output is true");
    }
    [UnityTest]
    public IEnumerator GateManagerTestXnorWithTwoTrueInputs()
    {

        logicGate.type = LogicGate.LogicGateType.XNOR;
        gateManager.logicGate = logicGate;

        gateManager.ChangeInput1(true);
        gateManager.ChangeInput2(true);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
        Assert.IsTrue(gateManager.output == true, "the output is true");
    }
}
