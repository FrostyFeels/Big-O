using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOpdracht1 : MonoBehaviour
{
    int[] Highscores = new int[100];
    int players = 100;
    int steps = 0;
    int dublicates = 0;

    private void Start()
    {
        for (int i = 0; i < players; i++)
        {
            Highscores[i] = Random.Range(0, 10001);          
        }
        checkDuplitcates();   
    }



    public void checkDuplitcates()
    {
            for (int i = 0; i < players; i++)
            {
                for (int j = i + 1; j < players; j++)
                {
                    if (Highscores[i] == Highscores[j])
                    {
                        dublicates++;                
                    }
                    steps++;
                }
            }
        Debug.Log("Dublicates: " +dublicates);
        Debug.Log("Steps: " + steps);
    }



}
