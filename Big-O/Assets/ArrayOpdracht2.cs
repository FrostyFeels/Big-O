using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOpdracht2 : MonoBehaviour
{
    int[] Highscores = new int[100];
    int players = 100;
    int steps = 0;
    float dublicates = 0;
    int loops = 0;
    public int mouseclicks = 1;

    private void Start()
    {
        FillArray();
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            loops = 0;
            mouseclicks++;
        }
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Steps: " + steps);
            Debug.Log("Dublicates: " + dublicates);
            Debug.Log("Loops: " + loops);

            Debug.Log(dublicates / 5000f);
        }

        if(loops < 200)
        {
            checkDuplitcates();
            FillArray();
        }
    }

        float checkDuplitcates()
        {
            for (int i = 0; i < players; i++)
            {
                for (int j = i + 1; j < players; j++)
                {
                    steps++;
                    if (Highscores[i] == Highscores[j])
                    {
                        dublicates++;
                        
                        i = players;
                        j = players;               
                    }
                }
            }
        loops++;
        return dublicates;
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
