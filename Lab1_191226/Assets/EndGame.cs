using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public float TotalTime = 2;
    public float timer;
    private bool gazestatus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gazestatus)
        {
            timer += Time.deltaTime;
        }
        if (timer > TotalTime)
        {
            Application.Quit();
        }
    }

    public void OnPointerEnter()
    {
        gazestatus = true;
    }

    public void OnPointerExit()
    {
        gazestatus = true;
        timer = 0;
    }
}
