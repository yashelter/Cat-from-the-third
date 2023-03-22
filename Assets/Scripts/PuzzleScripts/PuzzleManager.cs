using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] puzzle;
    [SerializeField] private GameObject PipesHolder;
    
    [SerializeField] private int totalPipes = 0;

    int correctPipes = 0;



    private void Start()
    {
        totalPipes = PipesHolder.transform.childCount;

        puzzle = new GameObject[totalPipes];

        for (int i = 0; i < puzzle.Length; i++)
        {
            puzzle[i] = PipesHolder.transform.GetChild(i).gameObject;
        }


    }
    
    public void CorrectMove()
    {
        correctPipes++;

        if (correctPipes == totalPipes)
        {
            Debug.Log("YOU WON");
        }
    }
    public void WrongMove()
    {
        correctPipes--;
    }
}
/*
        if (PuzzleRotate.isMouse)
        {
            bool AllTrue = true;
            foreach (var item in puzzle)
            {
                if (item.transform.rotation.z < -0.01 || item.transform.rotation.z > 0.01)
                {
                    AllTrue = false;
                    break;
                }
            }
            if (AllTrue)
            {
                isCorrect = true;
                Debug.Log("YOU WON");
                
            }
            PuzzleRotate.isMouse = false;
        } 


        
        
    }
}
*/