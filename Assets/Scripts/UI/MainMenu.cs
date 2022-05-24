using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private string VManualPuzzle;
    [SerializeField] private string VRandomPuzzle;
    [SerializeField] private Dropdown DifficultyDropdown;

    /// <summary>
    /// //load scene with var VManualPuzzle 
    /// </summary>
    public void ManualPuzzle()
    {
        ComfirmValues();
         
        SceneManager.LoadScene(VManualPuzzle);
    }
    /// <summary>
    /// load scene with var  VRandomPuzzle  
    /// </summary>
    public void RandomPuzzle()
    {
        ComfirmValues();
         
        SceneManager.LoadScene(VRandomPuzzle);
    }
    /// <summary>
    /// confirm the current chosen value, then load a scene
    /// </summary>
    private void ComfirmValues()
    {
        //save the current difficulty chosen in the instance of global control
        GlobalControl.Instance.DifficultyChoice = DifficultyDropdown.value;
    }
    /// <summary>
    ///quitte l'application
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
