using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    [SerializeField]
    GameObject[] prefabs;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
        GameObject newShape = Instantiate(prefab, new Vector3(Random.Range(-9, 9), 7, 0), Quaternion.identity);

        newShape.transform.localScale = Vector3.one * Random.Range(1f, 10f);

        Debug.Log(collision.gameObject.name);

    }
}
