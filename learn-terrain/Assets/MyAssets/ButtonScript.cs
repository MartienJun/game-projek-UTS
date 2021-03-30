using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject ExitMenu;

    public void ExitApp() 
    { 
        Application.Quit(); 
    } 
    
    public void ChangeScreen(string scene_name) 
    { 
        SceneManager.LoadScene(scene_name); 
    } 
}
