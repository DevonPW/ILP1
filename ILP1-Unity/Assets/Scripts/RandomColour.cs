using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    // Start is called before the first frame update
    void Awake()
    {
        randomizeColour();
    }

    void randomizeColour()
    {
        sprite.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        randomizeColour();
    }
}
