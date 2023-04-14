using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MathProblem : MonoBehaviour
{
    public TMP_Text firstNum;
    public TMP_Text secondNum;
    public TMP_Text firstAnswer;
    public TMP_Text secondAnswer;
    public TMP_Text thirdAnswer;
    public TMP_Text operatorProbl;
    //public List<int> easyMathList = new List<int>();

    public int randFirst;
    public int randSecond;

    private int firstNumProbl;
    private int secondNumProbl;

    private int answCorrect;
    private int answTwo;
    private int answThree;

    private int displayRandAnsw;
    private int randPlacement;
    public int currentAnsw;

    //public int[] oper = new int[] { 0, 1, 2};//generate operator like {+,-,*}

    private void Start()
    {
        DisplayMathProblem();
    }

    private int GenerateUniq(int firstNum, int secondNum)
    {
        //Generate uniq number
        return 0;
    }

    private void SetProblemNums(int firstNum, int secondNum, int oper)
    {
        if (oper == 0) // equal +
        {
            randFirst = Random.Range(-50, 50);
            randSecond = Random.Range(0, 100);

            firstNumProbl = randFirst;
            secondNumProbl = randSecond;
            return;
        } 
        else if (oper == 1) // equal -
        {
            randFirst = Random.Range(1, 150);
            randSecond = Random.Range(0, 100);

            firstNumProbl = randFirst;
            secondNumProbl = randSecond;
            return;
        } 
        else if (oper == 2) // equal *
        {
            randFirst = Random.Range(3, 10);
            randSecond = Random.Range(4, 15);

            firstNumProbl = randFirst;
            secondNumProbl = randSecond;
            return;
        }
        //Generate first and second number for our prolem
    }

    //generate random nums
    public void DisplayMathProblem()
    {
        //Random rnd = new Random();


        int rnd = Random.Range(0, 3);
        if (rnd == 0) // eq +
        {
            SetProblemNums(firstNumProbl, secondNumProbl, 0);
            answCorrect = firstNumProbl + secondNumProbl;
            operatorProbl.text = "+";
        } 
        else if (rnd == 1) // eq -
        {
            SetProblemNums(firstNumProbl, secondNumProbl, 1);
            answCorrect = firstNumProbl - secondNumProbl;
            operatorProbl.text = "-";
        } 
        else if (rnd == 2) //eq *
        {
            SetProblemNums(firstNumProbl, secondNumProbl, 2);
            answCorrect = firstNumProbl * secondNumProbl;
            operatorProbl.text = "*";
        } 
       
        //answCorrect = firstNumProbl + secondNumProbl; // create a generate func to the operator {+,-,*,/}
        answTwo = Random.Range(firstNumProbl - 40, secondNumProbl + 40); // 
        answThree = Random.Range(firstNumProbl - 45, secondNumProbl + 45);

        firstNum.text = "" + firstNumProbl;
        secondNum.text = "" + secondNumProbl;

        randPlacement = Random.Range(0, 3);
        if (randPlacement == 0)
        {
            firstAnswer.text = "" + answCorrect;
            secondAnswer.text = "" + answTwo;
            thirdAnswer.text = "" + answThree;
            currentAnsw = 0;
        } else if (randPlacement == 1) 
        {
            secondAnswer.text = "" + answCorrect;
            firstAnswer.text = "" + answTwo;
            thirdAnswer.text = "" + answThree;
            currentAnsw = 1;
        } else if (randPlacement == 2)
        {
            firstAnswer.text = "" + answTwo;
            secondAnswer.text = "" + answThree;
            thirdAnswer.text = "" + answCorrect;
            currentAnsw = 2;
        }
    }

    public void ButtonAnswer1()
    {
        if (currentAnsw == 0)
        {
            Debug.Log("You win");
        } else
        {
            Debug.Log("Try Again");
            DisplayMathProblem();
        }
    }

    public void ButtonAnswer2()
    {
        if (currentAnsw == 1)
        {
            Debug.Log("You win");
        }
        else
        {
            Debug.Log("Try Again");
            DisplayMathProblem();
        }
    }


    public void ButtonAnswer3()
    {
        if (currentAnsw == 2)
        {
            Debug.Log("You win");
        }
        else
        {
            Debug.Log("Try Again");
            DisplayMathProblem();
        }
    }
}
