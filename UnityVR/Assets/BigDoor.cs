using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoor : MonoBehaviour {

    private Animator ani;
    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        ani.SetBool("character_nearby", true);
    }
}
