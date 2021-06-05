using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    Vector3 offset = new Vector3(0,2,3);

    void Start()
    {
        mainCamera=GameObject.Find("MainCamera");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = player.transform.position + offset;

    }
}
