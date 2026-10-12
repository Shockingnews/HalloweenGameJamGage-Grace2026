using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;


public class Triva : MonoBehaviour
{
    private int count = 0;
    private int test;
    [SerializeField] private List<StringMultple> fakeAnswers;
    public List<string> questions = new List<string>();
    public List<string> answer = new List<string>();
    private List<(string, string, string, string)> playerAnswerChecker = new List<(string, string, string, string)>();
    public TMP_Text questionText;
    public TMP_Text ButtonOne;
    public TMP_Text ButtonTwo;
    public TMP_Text ButtonThree;
    public TMP_Text ButtonFour;
    public Dialogue dialogue;
    public DialogueManager manager;
    private bool cardsShuffled = false;


    private int score;
    //private int randomnum1 = new Random();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void AnswerFour()
    {
        if (playerAnswerChecker[0].Item4 == answer[test])
        {

            score += 1;
            
        }
        Debug.Log("four");
        playerAnswerChecker.Remove(playerAnswerChecker[0]);
        cardsShuffled = false;
        count += 1;
    }
    public void AnswerThree()
    {
        if (playerAnswerChecker[0].Item3 == answer[test])
        {

            score += 1;
            
        }
        Debug.Log("three");
        playerAnswerChecker.Remove(playerAnswerChecker[0]);
        cardsShuffled = false;
        count += 1;
    }
    public void AnswerTwo()
    {

        if (playerAnswerChecker[0].Item2 == answer[test])
        {
            
            score += 1;
            
        }
        Debug.Log("two");
        playerAnswerChecker.Remove(playerAnswerChecker[0]);
        cardsShuffled = false;
        count += 1;
    }
    public void AnswerOne()
    {
                if (playerAnswerChecker[0].Item1 == answer[test])
                {

                    //Console.WriteLine("Correct");
                    score += 1;
            
        }
        Debug.Log("one");
        playerAnswerChecker.Remove(playerAnswerChecker[0]);
        cardsShuffled = false;
        count += 1;
    }
    // Update is called once per frame
    void Update()
    {
        CheckStatus();
        if (manager.inText == true)
        {

            Debug.Log("true");
            manager.DisplayNextSentence();



        }
        
        for (int i = 0; i < questions.Count; i++)
        {
            
            
            if (i == count)
            {
                Debug.Log("went through");
                
                test = i;
                //count = 0;
                if (!cardsShuffled)
                {
                    shuffleAnswers();
                }
                




            }
        }
        
    }
    void CheckStatus()
    {
        if(count == 2)
        {
            if(score >= 1)
            {
                manager.StartDialogue(dialogue);
                manager.inText = true;
                Debug.Log("you win");
            }
            else
            {
                manager.StartDialogue(dialogue);
                manager.inText = true;
                Debug.Log("you lose");
            }
        }
    }
        void shuffleAnswers()
        {
        questionText.text = questions[test];
            int num = Random.Range(1, 5);
            if (num == 1)
            {
                playerAnswerChecker.Add((answer[test], fakeAnswers[test].fristString, fakeAnswers[test].secondString, fakeAnswers[test].thirdString));
                ButtonOne.text = answer[test];
                ButtonTwo.text = fakeAnswers[test].fristString;
                ButtonThree.text = fakeAnswers[test].secondString;
                ButtonFour.text = fakeAnswers[test].thirdString;
            }
            if (num == 2)
            {
                playerAnswerChecker.Add((fakeAnswers[test].secondString, answer[test], fakeAnswers[test].fristString, fakeAnswers[test].thirdString));
                ButtonOne.text = fakeAnswers[test].secondString;
                ButtonTwo.text = answer[test];
                ButtonThree.text = fakeAnswers[test].fristString;
                ButtonFour.text = fakeAnswers[test].thirdString;
            }
            if (num == 3)
            {
                playerAnswerChecker.Add((fakeAnswers[test].fristString, fakeAnswers[test].thirdString, answer[test], fakeAnswers[test].secondString));
                ButtonOne.text = fakeAnswers[test].fristString;
                ButtonTwo.text = fakeAnswers[test].thirdString;
                ButtonThree.text = answer[test];
                ButtonFour.text = fakeAnswers[test].secondString;
            }
            if (num == 4)
            {
                playerAnswerChecker.Add((fakeAnswers[test].thirdString, fakeAnswers[test].fristString, fakeAnswers[test].secondString, answer[test]));
                ButtonOne.text = fakeAnswers[test].thirdString;
                ButtonTwo.text = fakeAnswers[test].fristString;
                ButtonThree.text = fakeAnswers[test].secondString;
                ButtonFour.text = answer[test];
            }
            cardsShuffled = true;
        }


                //ConsoleKeyInfo input = Console.ReadKey(true);
                //if (input.Key == ConsoleKey.D1)
                //{

                //    if (playerAnswerChecker[0].Item1 == answer[i])
                //    {

                //        Console.WriteLine("Correct");
                //        score += 1;
                //    }
                //    if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item1)
                //    {
                //        if (fakeAnswers[i].Item1 == "11")
                //        {
                //            Console.WriteLine("Sorry lets fix that");


                //            secretScore = ($"{name}: {score}/{11}");
                //            Console.WriteLine(secretScore);
                //        }
                //        else { Console.WriteLine("Incorrect"); }

                //    }
                //    if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item2)
                //    {
                //        if (fakeAnswers[i].Item2 == "5")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{5}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item1 == fakeAnswers[i].Item3)
                //    {
                //        if (fakeAnswers[i].Item3 == "0")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{0}");
                //            Console.WriteLine(secretScore);
                //            Console.WriteLine("I guess you win");

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    playerAnswerChecker.Remove(playerAnswerChecker[0]);
                //    count = 1;
                //}
                //else if (input.Key == ConsoleKey.D2)
                //{
                //    if (playerAnswerChecker[0].Item2 == answer[i])
                //    {
                //        Console.WriteLine("Correct");
                //        score += 1;
                //    }
                //    if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item1)
                //    {
                //        if (fakeAnswers[i].Item1 == "11")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{11}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item2)
                //    {
                //        if (fakeAnswers[i].Item2 == "5")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{5}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item2 == fakeAnswers[i].Item3)
                //    {
                //        if (fakeAnswers[i].Item3 == "0")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{0}");
                //            Console.WriteLine(secretScore);
                //            Console.WriteLine("I guess you win");

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    count = 1;
                //    playerAnswerChecker.Remove(playerAnswerChecker[i]);
                //}
                //else if (input.Key == ConsoleKey.D3)
                //{
                //    if (playerAnswerChecker[0].Item3 == answer[i])
                //    {
                //        Console.WriteLine("Correct");
                //        score += 102;
                //    }
                //    if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item1)
                //    {
                //        if (fakeAnswers[i].Item1 == "11")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{11}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item2)
                //    {
                //        if (fakeAnswers[i].Item2 == "5")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{5}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item3 == fakeAnswers[i].Item3)
                //    {
                //        if (fakeAnswers[i].Item3 == "0")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{0}");
                //            Console.WriteLine(secretScore);
                //            Console.WriteLine("I guess you win");

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    count = 1;
                //    playerAnswerChecker.Remove(playerAnswerChecker[0]);
                //}
                //else if (input.Key == ConsoleKey.D4)
                //{
                //    if (playerAnswerChecker[0].Item4 == answer[i])
                //    {
                //        Console.WriteLine("Correct");
                //        score += 1;
                //    }
                //    if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item1)
                //    {
                //        if (fakeAnswers[i].Item1 == "11")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{11}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item2)
                //    {
                //        if (fakeAnswers[i].Item2 == "5")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{5}");
                //            Console.WriteLine(secretScore);

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                //    if (playerAnswerChecker[0].Item4 == fakeAnswers[i].Item3)
                //    {
                //        if (fakeAnswers[i].Item3 == "0")
                //        {
                //            Console.WriteLine("Sorry lets fix that");

                //            secretScore = ($"{name}: {score}/{0}");
                //            Console.WriteLine(secretScore);
                //            Console.WriteLine("I guess you win");

                //        }
                //        else { Console.WriteLine("Incorrect"); }
                //    }
                    //count = 1;
                    //playerAnswerChecker.Remove(playerAnswerChecker[0]);
                    //Console.ReadKey(true);
                    //Console.Clear();
                //}
                //else
                //{
                //    Console.WriteLine("try again");
                //    Console.WriteLine("press any key to continue");

                //    Console.ReadKey(true);

                //}






            
    
}
