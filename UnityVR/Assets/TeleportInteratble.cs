using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportInteratble : MonoBehaviour {

    public Animator animatorControl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name== "HeadCollider"&& GameManager.haveKey)
        {
            animatorControl.SetBool("character_nearby", true);
        }   
    }
}
