using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie1 : MonoBehaviour
{
    List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    List<int> jedynki = new List<int>();
    List<int> dwojki = new List<int>();
    List<int> trojki = new List<int>();

    void Start()
    {
        jedynki.Add(1);
        jedynki.Remove(1);
        Debug.Log(dane.Count);

        List<int> tempDane = new List<int>(dane);


        tempDane.ForEach((i) =>
        {
            switch (i)
            {
                case 1:
                    {
                        jedynki.Add(1);
                        dane.Remove(1);
                    }
                    break;
                case 2:
                    {
                        dwojki.Add(2);
                        dane.Remove(2);
                    }
                    break;
                case 3:
                    {
                        trojki.Add(3);
                        dane.Remove(3);
                    }
                    break;
            }
        });

        //foreach (int i in dane)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < dane.Count; i++) 
        //{
        //    Debug.Log (i);
        //}

        Debug.Log($"Dane: {dane.Count}");
        Debug.Log($"Jedynki: {string.Join(", ", jedynki)}");
        Debug.Log($"Dwojki: {string.Join(", ", dwojki)}");
        Debug.Log($"Trojki: {string.Join(", ", trojki)}");

    }
}
