using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    private GameObject[] puzzle;
    public static bool isCorrect;


    private void Start()
    {
        puzzle = GameObject.FindGameObjectsWithTag("Puzzle");
        isCorrect = false;
    }
    private void Update()
    {
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