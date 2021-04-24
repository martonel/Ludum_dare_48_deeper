using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitTime());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("beleért valami");
        if (other.gameObject.tag == "coin")
        {
            other.gameObject.GetComponent<SandBox>().isDead();
        }
        if (other.gameObject.tag == "groundBrush")
        {
            Debug.Log("ez ért bele");
            other.gameObject.GetComponent<SandBox>().isDead();
        }
    }
}
