using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;
    public Gradient gradient;
    
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
                Cube(objectToCheck.transform);
            }
            else if (objectToCheck.GetComponent<SpriteRenderer>())
            {
                Debug.Log("2D");
                Sprite(objectToCheck.GetComponent<SpriteRenderer>());
            }
        }
    }

    public void Sprite(SpriteRenderer sprite)
    {
        float y = Mathf.InverseLerp(1, 100, sprite.transform.position.y);
        //sprite.color = Color.Lerp(Color.blue, Color.red, y);
        
        sprite.color = gradient.Evaluate(y);

    }

    public void Cube(Transform transformCube)
    {
        float x = transformCube.position.x;
        transformCube.rotation = Quaternion.Euler(x, 0, 0);
    }
   
}
