using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public Player _Player;

    void Awake()
    {
        _Player = GameObject.Find("knight").GetComponent<Player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        _Player.anim.SetBool("Saltar", false);
        _Player.isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        _Player.anim.SetBool("Saltar", true);
        _Player.isGrounded = false;
    }

}