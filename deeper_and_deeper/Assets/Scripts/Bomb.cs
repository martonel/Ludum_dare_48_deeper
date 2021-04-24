using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("beleér");
        if (other.gameObject.tag == "coin")
        {
            Debug.Log("itt is");
            other.gameObject.GetComponent<SandBox>().isDead();
        }
        if (other.gameObject.tag == "groundBrush")
        {
            other.gameObject.GetComponent<SandBox>().isDead();
        }
    }
}
