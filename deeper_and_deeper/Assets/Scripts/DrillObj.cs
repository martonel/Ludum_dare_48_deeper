using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillObj : MonoBehaviour
{
    private bool isTrue;
    public GameObject particle;
    private void Start()
    {
        isTrue = true;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.tag == "coin" || other.gameObject.tag == "groundBrush") && isTrue == true)
        {
            StartCoroutine(WaitTime());
            isTrue = false;
        }
    }
    IEnumerator WaitTime()
    {
        Instantiate(particle, this.gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        isTrue = true;
    }
}
