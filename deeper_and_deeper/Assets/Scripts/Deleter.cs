using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("beleért valami");
    }
}
