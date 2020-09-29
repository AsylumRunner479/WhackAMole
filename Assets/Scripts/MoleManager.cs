using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    public GameObject[] holes;
    public GameObject mole;
    private float Spawn;
    private int rando;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Spawn += Time.deltaTime;
        if (Spawn >= 0)
        {
            rando = Random.Range(0, holes.Length - 1);
            Instantiate(mole, holes[rando].transform.position, Quaternion.identity);
            Spawn = -1;
        }
    }
}
