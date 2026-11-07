using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    //Ta referencja jest pusta, zostaje uzupełniona podczas pierwszego HIT()
    private Rigidbody2D rb;

    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Gradient hpColor;

    [SerializeField] private float hp = 100;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    //Funkcja wywoływana przy trafieniu
    public void Hit(float dmg)
    {
        hp -= dmg; 
        sprite.color = hpColor.Evaluate(hp / 100); 
        CheckIfKill();
    }

    //Jeśli życie spadnie poniżej zera obiekt powinien zostać zniszczony
    private void CheckIfKill()
    {
        if (hp <= 0) 
        {
            Destroy(gameObject);
        }
    }

    // Funkcja zwraca największego inta z listy
    public int ReturnHighNumber(List<int> data)
    {
        return Mathf.Max(data.ToArray());
    }
  
}
