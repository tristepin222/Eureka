using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class GateManager : MonoBehaviour
{
    //the output of the current gate
    public bool output;
    //the current logic gate
    [SerializeField] public LogicGate logicGate;
    //if it's an end gate, a text is attached to, showing FALSE or TRUE
    [SerializeField] private Text text;
    //List of avialables gate sprites
    [SerializeField] private List<Sprite> GateSprites = new List<Sprite>();
    //List of avialables gate inverted sprites
    [SerializeField] private List<Sprite> InversedGateSprites = new List<Sprite>();
    //the current colorState, green for TRUE, red for FALSE
    [SerializeField] private List<Sprite> ColorState = new List<Sprite>();
    //the current imageInversed attached to the gate
    [SerializeField] private Image ImageInversed;
    //the current sprite Gate attached to the gate
    [SerializeField] private Image CurrentState;
    //curent inputs, depending on the gate, only one input is used;
    private bool input1;
    private bool input2;
    //current image
    private Image Image;
   

    private void Start()
    {
        //get the current spriteRenderer
        Image = this.gameObject.GetComponent<Image>();
        //depending on the logicGate's type, the gate's sprite and inverted sprite will change
        switch (logicGate.type)
        {
            case LogicGate.LogicGateType.Buffer:
                Image.sprite = GateSprites[0];
                ImageInversed.sprite = InversedGateSprites[0];
                break;
            case LogicGate.LogicGateType.NOT:
                Image.sprite = GateSprites[1];
                ImageInversed.sprite = InversedGateSprites[1];
                break;
            case LogicGate.LogicGateType.AND:
                Image.sprite = GateSprites[2];
                ImageInversed.sprite = InversedGateSprites[2];
                break;
            case LogicGate.LogicGateType.NAND:
                Image.sprite = GateSprites[3];
                ImageInversed.sprite = InversedGateSprites[3];
                break;
            case LogicGate.LogicGateType.OR:
                Image.sprite = GateSprites[4];
                ImageInversed.sprite = InversedGateSprites[4];
                break;
            case LogicGate.LogicGateType.NOR:
                Image.sprite = GateSprites[5];
                ImageInversed.sprite = InversedGateSprites[5];
                break;
            case LogicGate.LogicGateType.XOR:
                Image.sprite = GateSprites[6];
                ImageInversed.sprite = InversedGateSprites[6];
                break;
            case LogicGate.LogicGateType.XNOR:
                Image.sprite = GateSprites[7];
                ImageInversed.sprite = InversedGateSprites[7];
                break;
        }
    }

    //change the first input
    public void ChangeInput1(bool value)
    {
        input1 = value;
        changeOuput();
    }
    //change the second input, if applicable (some gates only have 1 input)
    public void ChangeInput2(bool value)
    {
        input2 = value;
        changeOuput();
    }
    
    //change the output, depending from the input and the logic gate
    private void changeOuput()
    {
        //check the current logic gate state, and depending on the type, output will change from input
        switch (logicGate.type)
        {
            case LogicGate.LogicGateType.Buffer:
                output = input1;
                break;
            case LogicGate.LogicGateType.NOT:
                output = !input1;
                break;
            case LogicGate.LogicGateType.AND:
                if(((input1 == true) && (input2 == true)))
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
                break;
            case LogicGate.LogicGateType.NAND:

                if (((input1 == false) && (input2 == false)))
                {
                    output = true;
                }
                else if(((input1 == true) && (input2 == true)))
                {
                    output = false;
                }
                else
                {
                    output = true;
                }
                break;
            case LogicGate.LogicGateType.OR:

                if (((input1 == true) && (input2 == true)))
                {
                    output = true;
                }
                else if ((input1 || input2))
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
                break;
            case LogicGate.LogicGateType.NOR:
                if (((input1 == false) && (input2 == false)))
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
                break;
            case LogicGate.LogicGateType.XOR:
                if (((input1 == true) && (input2 == false)) || ((input1 == false) && (input2 == true)))
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
                break;
            case LogicGate.LogicGateType.XNOR:
                if (((input1 == true) && (input2 == true)) || ((input1 == false) && (input2 == false)))
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
                break;
        }

        //change the color to green if output is true and red if output is false
        if (!output)
        {
            CurrentState.sprite = ColorState[0];
        }
        else
        {
            CurrentState.sprite = ColorState[1];
        }
        //invoke the event with the output as a value
        OnValueChange.Invoke(output);
        //if text isn't null, mean it shows the output on text on the map
        if(text != null)
        {
            if (output)
            {
                text.text = "TRUE";
            }
            else
            {
                text.text = "FALSE";
            }
        }
    }
   
    //this part is an event when the value, meaning the output of the current gate changed, affecting whatever is set in the input on the editor tab
    [Serializable]
    public class ValueChangedEvent : UnityEvent <bool> {}
    [FormerlySerializedAs("onValueChange")]
    [SerializeField]
    private ValueChangedEvent OnValueChange = new ValueChangedEvent();
    
    public ValueChangedEvent onValueChanged
    {
        get { return OnValueChange; }
        set { OnValueChange = value; }
    }
}
