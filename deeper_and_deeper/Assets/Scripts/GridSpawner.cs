using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject[] grids;
    private Vector3 pos;
    private int lastRand;
    public GameObject backGround;
    public GameObject col;
    // Start is called before the first frame update
    void Start()
    {
        RandSpawn(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandSpawn(bool isTrue)
    {
        int rand = Random.Range(0, 3);
        if (isTrue)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(grids[rand], pos, Quaternion.identity);
                pos += new Vector3(0, -20, 0);
                while (rand == lastRand)
                {
                    rand = Random.Range(0, 3);
                }
                lastRand = rand;
                if(i == 2)
                {
                    Instantiate(backGround, pos, Quaternion.identity);
                }
                if(i == 4)
                {
                    Instantiate(col, pos, Quaternion.identity);
                }
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(grids[rand], pos, Quaternion.identity);
                pos += new Vector3(0, -20, 0);
                while (rand == lastRand)
                {
                    rand = Random.Range(0, 3);
                }
                lastRand = rand; 
                if (i == 3)
                {
                    Instantiate(col, pos, Quaternion.identity);
                }
            }
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2.0f);

    }
}
