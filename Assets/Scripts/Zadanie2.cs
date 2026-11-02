using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;
    
    void Start()
    {
        CheckDimension();
        
    }

    
    void Update()
    {
        
    }

    private void CheckDimension()
    {
        foreach(GameObject objectToCheck in objects)
        {
            if (objectToCheck.GetComponent<MeshRenderer>()) 
            {
                Debug.Log("3D");
            }
            else if (objectToCheck.GetComponent<SpriteRenderer>())
            {
                Debug.Log("2D");
            }
        }
    }
}
