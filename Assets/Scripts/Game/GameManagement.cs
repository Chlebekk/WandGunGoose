using System;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public void Start()
    {
        StaticData.LoadGameData();
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ChangeMenu(int option) 
    {
        SceneTransition();
        switch (option)
        {
            case 0:
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameMenu");
                break;
            case 1:
                UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
                break;
            case 2:
                UnityEngine.SceneManagement.SceneManager.LoadScene("Mods");
                break;
            default:
                Debug.LogError("Invalid menu option: " + option);
                break;
        }
    }
    private void SceneTransition() 
    {
     
    }
}
