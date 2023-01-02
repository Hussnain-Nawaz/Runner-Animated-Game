using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarrier : MonoBehaviour
{
    public GameObject barrier;
    public PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarriers", 3,3);
    }

    // Update is called once per frame
    void Update()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void SpawnBarriers()
    {
        if(playerControllerScript.gameOver==false)
        {
            Vector3 spawnPos = new Vector3(25, 0, 0);
            Instantiate(barrier, spawnPos, barrier.transform.rotation);
        }
        
    }
}
