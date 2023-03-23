using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] puzzle;
    [SerializeField] private GameObject PipesHolder;
    
    [SerializeField] private int totalPipes = 0;

    public static int correctPipes = 0;
    


    private void Start()
    {


        puzzle = new GameObject[totalPipes];

        for (int i = 0; i < puzzle.Length; i++)
        {
            puzzle[i] = PipesHolder.transform.GetChild(i).gameObject;
        }

        
    }
    



    public void CorrectMove()
    {
        correctPipes += 1;

        if (correctPipes == totalPipes)
        {
            Debug.Log("YOU WON");
        }
    }
    public void WrongMove()
    {
        correctPipes -= 1;
        Debug.Log("Wrong MOVE");
    }
}