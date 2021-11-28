using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour {

    GameObject player;
    Animator anim;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    void Update(){
        if(Vector3.Distance(transform.position, player.transform.position) < 4f) {
            anim.SetBool("isDekat", true);
        } else {
            anim.SetBool("isDekat", false);
        }
    }
}
