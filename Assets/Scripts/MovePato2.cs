using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePato2 : MonoBehaviour {
    
    [SerializeField] float speed = default;
    public float vida = 100;
    public GameObject respawnPrefab;
    public GameObject[] respawns;
    void Start()
    {
        if (respawns == null)
            respawns = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject respawn in respawns)
        {
           //Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
           Debug.Log(respawn.transform.position);
        }
    }

    // Update is called once per frame
    void Update() {
            if (Input.GetKey(KeyCode.R))
            {
                Debug.Log("R");
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime,0,0), Space.World);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime,0,0), Space.World);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, speed * Time.deltaTime, 0), Space.World);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0), Space.World);
            }
    }
}