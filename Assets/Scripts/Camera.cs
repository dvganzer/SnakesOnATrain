using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //define player game object
    public GameObject player;

    //wait for lateupdate
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, 0f, -10f);
    }
}

