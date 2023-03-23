using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRotate : MonoBehaviour
{
    [SerializeField] private bool isPlaced;

    
    
    public float[] correctRotation;

    
    int PossibleRots = 1;
    public int sumCorrect = 0;

    //PuzzleManager puzzleManager;

    //private void Awake()
    //{
    //    puzzleManager = GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>();
    //}

    private void Start()
    {
        float[] rotate = { 0, 90, 180, 270 };

        PossibleRots = correctRotation.Length;
        int Rand = Random.Range(0, rotate.Length);
        //transform.Rotate(0, 0, rotate[Rand]);// rotate.Length)]);
        transform.eulerAngles = new Vector3(0,0, rotate[Rand]);


        if (PossibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1]) // || transform.eulerAngles.z == -correctRotation[1])
            {
                isPlaced = true;
                sumCorrect++;
                //puzzleManager.CorrectMove();
            }
        } else 
        {
            if (transform.eulerAngles.z == correctRotation[0])
            {
                isPlaced = true;
                sumCorrect++;
                //puzzleManager.CorrectMove();
            }
        }


    }
    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);

        if (PossibleRots == 2)
        {
            if ((transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] ) && isPlaced == false)
            {
                isPlaced = true;
                sumCorrect++;
                //puzzleManager.CorrectMove();
            }
            else 
            {
                isPlaced = false;
                //puzzleManager.WrongMove();
            }
        } else 
        {
            if (transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                sumCorrect++;
                //puzzleManager.CorrectMove();
            }
            else
            {
                isPlaced = false;
                //puzzleManager.WrongMove();
            }
        }
        
    }
}
