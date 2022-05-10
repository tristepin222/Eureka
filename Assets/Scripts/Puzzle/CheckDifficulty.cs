using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDifficulty : MonoBehaviour
{
    //current maps
    [SerializeField] private GameObject Easy;
    [SerializeField] private GameObject Medium;
    [SerializeField] private GameObject Hard;
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
        this.gameObject.GetComponent<RandomPuzzle>().Randomize(currentMap.GetComponent<MapInfo>());
    }
}
