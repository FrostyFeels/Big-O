using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOpdracht2 : MonoBehaviour
{
    int[] Highscores = new int[100];
    int players = 100;
    int steps = 0;
    int dublicates = 0;
    int loops = 0;
    public int mouseclicks = 0;

    private void Start()
    {
        FillArray();
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            loops = 0;
            mouseclicks++;
            checkDuplitcates();
        }
    }

    public void checkDuplitcates()
    {
        if (loops < 100)
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
            loops++;
            ClearArray();
        }
        else
        {
            Debug.Log("Dublicates: " + dublicates);
        }
    }

    public void ClearArray()
    {
        for (int i = 0; i < players; i++)
        {
            Highscores[i] = 0;
        }
        FillArray();
    }

    public void FillArray()
    {
        for (int i = 0; i < players; i++)
        {
            Highscores[i] = Random.Range(0, 10001);
        }
        checkDuplitcates();
    }
}
