using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResolvePuzzle : MonoBehaviour
{
    private const string MAIN_MENU = "MainMenu";
    /// <summary>
    /// check if the last gate is true, if true the game is won, and main menu is loaded
    /// </summary>
    /// <param name="value"></param>
    public void checkWin(bool value)
    {
        if (value)
        {
            SceneManager.LoadScene(MAIN_MENU);
        }
    }
}
