using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GateManagerTest : MonoBehaviour
{
    //logicGate
    private LogicGate logicGate;
    //gateManager
    [SerializeField] private GateManager gateManager;

    //constructor that inits a new LogicGate
    public GateManagerTest()
    {
        logicGate = new LogicGate();
        gateManager = new GateManager();
    }
   

    //test with a buffer gate, with two true inputs, that has a true output, gates with one input, that have two set inputs, only take in consideration the first input
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
    //test with a NOT gate, with one true input, that has a false output
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
    //test with a AND gate, with one true input, that has a false output, gates that has two input, but only have one input set, the unset input will always be false
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
    //test with a OR gate, with one true input, that has a true output
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
    //test with a NOR gate, with one true input and one false input, that has a false output
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
    //test with a NAND gate, with one true input and one false input, that has a true output
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
    //test with a XOR gate, with one true input and one false input, that has a true output
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
    //test with a XNOR gate, with two inputs, that has a true output
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
