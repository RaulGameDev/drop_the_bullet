using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float Speed;
    public GameObject respawnPrefab;
    public GameObject[] respawns;
    //GameObject posicaoDoJogador;

    void Start()
    {
        //posicaoDoJogador = GameObject.FindGameObjectsWithTag("Player");
        //GameObject[] target = GameObject.FindGameObjectsWithTag("Human");
        if (respawns == null)
            respawns = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject respawn in respawns)
        {
           //Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
           //Debug.Log(respawn.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if(posicaoDoJogador.gameObject != null);
        {
            //transform.position = Vector2 = MoveTowards(transform.position, posicaoDoJogador.position, velocidadeDoInimigo * Time.delataTime);
            print(posicaoDoJogador);
        }*/
    }
}
