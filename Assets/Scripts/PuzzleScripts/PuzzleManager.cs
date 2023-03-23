using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] puzzle;
    [SerializeField] private GameObject PipesHolder;
    [SerializeField] private PuzzleRotate[] puzzles;
    public int allTiles = 6;
    public int solvedTiles = 6;
    
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


        puzzles = FindObjectsOfType<PuzzleRotate>();









    }
    
    public void CorrectMove()
    public void GenerateField()




    {
        correctPipes++;

        if (correctPipes == totalPipes)
        {
            Debug.Log("YOU WON");
        }
        // paste your code here





    }
    public void WrongMove()
    public void CheckPuzzle()
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
        solvedTiles = 0;
        for (int i = 0; i < puzzles.Length; i++)
        {
            if (puzzles[i].isPlaced)
            {
                solvedTiles++;
            }
        }
       
        if (solvedTiles == allTiles)
        {
            // send action to other scripts
            Debug.Log("solved");
        }
        
    }
}