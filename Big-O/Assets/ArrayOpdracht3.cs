using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayOpdracht3 : MonoBehaviour
{
    int[] AllHighscores = new int[10000];
    int dublicates = 0;
    int steps = 0;

    private void Start()
    {
        for (int i = 0; i < AllHighscores.Length; i++)
        {
            AllHighscores[i] = 0;
        }

        CheckForDuplicates();
    }

    void CheckForDuplicates()
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
    }
}
