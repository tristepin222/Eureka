using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CustomGateManager : MonoBehaviour
{
    //the dropdown attached to the customGate
    [SerializeField] private Dropdown dropdown;
    //the background image attached to the customGate
    [SerializeField] private Image background;
    //List of avialables gate sprites
    [SerializeField] private List<Sprite> GateSprites = new List<Sprite>();
    //List of avialables gate inverted sprites
    [SerializeField] private List<Sprite> InversedGateSprites = new List<Sprite>();
    //is true if the gate has one input only
    [SerializeField] public bool isSingleGate = true;
    //the GateManager attached to the customGate
    [SerializeField] private GateManager gateManager;

    //when a gate is chosen in the dropdown, it will change the sprite of the gate, depending on which gate is chosen and if the gate has one input only or not
    public void OnSelectGate(int value)
    {
        //get the current sprite, and change it
        this.GetComponent<Image>().sprite = GateSprites[value];
        //get the current background sprite, and change it
        background.sprite = InversedGateSprites[value];
        //check if it's a single input gate
        if (isSingleGate)
        {
            //change the type in gateManager depeding on the value given to the function
            switch (value)
            {
                case 0:
                    gateManager.logicGate.type = LogicGate.LogicGateType.Buffer;
                    break;
                case 1:
                    gateManager.logicGate.type = LogicGate.LogicGateType.NOT;
                    break;
            }
        }
        else
        {
            //change the type in gateManager depeding on the value given to the function
            switch (value)
            {
                case 0:
                    gateManager.logicGate.type = LogicGate.LogicGateType.AND;
                    break;
                case 1:
                    gateManager.logicGate.type = LogicGate.LogicGateType.NAND;
                    break;
                case 2:
                    gateManager.logicGate.type = LogicGate.LogicGateType.OR;
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
