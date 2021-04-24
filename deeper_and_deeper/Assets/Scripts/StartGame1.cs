using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class StartGame1 : MonoBehaviour
{
    public GameObject vcam;
    public GameObject playerObj;
    private bool isTrue = false;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(WaitTime());
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrue)
        {
            Debug.Log("alma");
            vcam.transform.position = playerObj.transform.position;
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5.1f);
        Debug.Log("megkapja");
        isTrue = true;
    }
}
