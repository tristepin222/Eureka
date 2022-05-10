using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class LogicGate 
{
   
    public enum LogicGateType
    {
        Buffer,
        NOT,
        AND,
        OR,
        NAND,
        NOR,
        XOR,
        XNOR
    }
    public LogicGateType type;
}
