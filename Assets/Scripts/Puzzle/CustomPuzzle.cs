using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CustomPuzzle : MonoBehaviour
{
    //the resolve scene
    const string RESOLVESCENE = "ResolvePuzzle";

    /// <summary>
    /// when pressing the confirm button, it will save the current puzzle's mapInfo, and load the resolve scene
    /// </summary>
    public void confirmSelction()
    {
        GlobalControl.Instance.saved = true;
        GlobalControl.Instance.mapInfo = this.gameObject.GetComponent<CheckDifficulty>().currentMap.GetComponent<MapInfo>();
        SceneManager.LoadScene(RESOLVESCENE);
    }
}
