using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    //the script's instance, will stay throughout the scenes load, but lost at game's closure
    public static GlobalControl Instance;
    //the current difficulty choosen
    public int DifficultyChoice;
    // Start is called before the first frame update
    private void Start()
    {
        //check if instance is null or not, if instance is null, set all var as not destroy on load, else destroy vars (avoid duplicates)
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {

        }
    }
}
