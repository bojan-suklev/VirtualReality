using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkVR : MonoBehaviour
{
    public int playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
    }
}
