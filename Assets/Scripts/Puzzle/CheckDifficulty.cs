using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDifficulty : MonoBehaviour
{
    //current maps
    [SerializeField] private GameObject Easy;
    [SerializeField] private GameObject Medium;
    [SerializeField] private GameObject Hard;
    [SerializeField] private bool isCustom;
    [SerializeField] public GameObject currentMap;
    
    // Start is called before the first frame update
    private void Start()
    {
        //depending on choosen difficulty, a map will be enabled while others are disabled
        switch (GlobalControl.Instance.DifficultyChoice)
        {
            case 0:
                Easy.SetActive(true);
                currentMap = Easy;
                break;
            case 1:
                Medium.SetActive(true);
                currentMap = Medium;
                break;
            case 2:
                Hard.SetActive(true);
                currentMap = Hard;
                break;
        }
        //if the map is custom, does nothing, if the var saved in the global control and custom isn't true, it will generate a random puzzle
        //if the var saved in the global control is true and custom isn't true, it will generate from the custom puzzle created by the player
        if (isCustom)
        {
            
        }
        else if(!GlobalControl.Instance.saved && !isCustom)
        {

            this.gameObject.GetComponent<GeneratePuzzle>().Randomize(currentMap.GetComponent<MapInfo>());
        }else if (GlobalControl.Instance.saved && !isCustom)
        {
            GlobalControl.Instance.saved = false;
            this.gameObject.GetComponent<GeneratePuzzle>().CustomPuzzle(currentMap.GetComponent<MapInfo>(), GlobalControl.Instance.mapInfo);
        }
    }
}
