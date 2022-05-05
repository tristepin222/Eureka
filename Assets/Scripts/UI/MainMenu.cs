using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private string VManualPuzzle;
    [SerializeField] private string VRandomPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ManualPuzzle()
    {
        //charge une sc�ne, avec en param�tre la variable VManualPuzzle  
        SceneManager.LoadScene(VManualPuzzle);
    }
    public void RandomPuzzle()
    {
        //charge une sc�ne, avec en param�tre la variable VRandomPuzzle  
        SceneManager.LoadScene(VRandomPuzzle);
    }
}
