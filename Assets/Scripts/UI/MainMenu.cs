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
    

    public void ManualPuzzle()
    {
        ComfirmValues();
        //load scene with var VManualPuzzle  
        SceneManager.LoadScene(VManualPuzzle);
    }
    public void RandomPuzzle()
    {
        ComfirmValues();
        //load scene with var  VRandomPuzzle  
        SceneManager.LoadScene(VRandomPuzzle);
    }
    //confirm the current chosen value, then load a scene
    private void ComfirmValues()
    {
        //save the current difficulty chosen in the instance of global control
        GlobalControl.Instance.DifficultyChoice = DifficultyDropdown.value;
    }
    //quitte l'application
    public void Quit()
    {
        Application.Quit();
    }
}
