using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOpdracht3 : MonoBehaviour
{
    int[] AllHighscores = new int[10000];
    int dublicates = 0;
    int steps = 0;
    int loops = 0;
    public int loopsdone = 0;
    private void Start()
    {
        for (int i = 0; i < AllHighscores.Length; i++)
        {
            AllHighscores[i] = 0;
        }

        CheckForDuplicates();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            loops = 0;

            CheckForDuplicates();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Steps: " + steps);
            Debug.Log("Dublicates: " + dublicates);
            Debug.Log("Loops done: " + loopsdone);
        }
    }

    void CheckForDuplicates()
    {
        if (loops < 100)
        {
            for (int i = 0; i < 100; i++)
            {
                int t = Random.Range(0, 10000);
                AllHighscores[t]++;
                if (AllHighscores[t] > 1)
                {
                    dublicates++;
                }
                steps++;
            }
            loops++;
            loopsdone++;
 
        }
    }

    public void ClearArray()
    {
        for (int i = 0; i < AllHighscores.Length; i++)
        {
            AllHighscores[i] = 0;
        }
        FillArray();
    }

    public void FillArray()
    {
        for (int i = 0; i < AllHighscores.Length; i++)
        {
            AllHighscores[i] = Random.Range(0, 10001);
        }
        CheckForDuplicates();
    }
}
