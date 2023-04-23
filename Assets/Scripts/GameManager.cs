using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void onGameStart()
    {
        // ��� ������ ���� ���������� - ��������
        SceneManager.LoadScene(1);
    }

    public void onGameExit()
    {
        // ����� ������� ���� ������ ����� ..
        Application.Quit();
    }
    public void toMenu()
    {
        // ��� ������ ���� ���������� - ��������
        SceneManager.LoadScene(0);
    }
    public void loadLevelByIndex(int ind)
    {
        SceneManager.LoadScene(ind);
    }
}
