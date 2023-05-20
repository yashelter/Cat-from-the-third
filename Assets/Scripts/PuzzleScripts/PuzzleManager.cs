using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private PuzzleRotate[] puzzles;
    public int allTiles = 6;
    public int solvedTiles = 6;
    
    private void Start()
    {
        puzzles = FindObjectsOfType<PuzzleRotate>();
    }
    public void GenerateField()
    {
        // paste your code here
    }
    public void CheckPuzzle()
    {
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
