using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void onGameStart()
    {
        // тут должна быть сохрянение - загрузка
        SceneManager.LoadScene(1);
    }

    public void onGameExit()
    {
        // можно сделать типо хотите выйти ..
        Application.Quit();
    }
    public void toMenu()
    {
        // тут должна быть сохрянение - загрузка
        SceneManager.LoadScene(0);
    }
    public void loadLevelByIndex(int ind)
    {
        SceneManager.LoadScene(ind);
    }
}
