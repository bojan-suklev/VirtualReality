using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
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
            SceneManager.LoadScene("SampleScene");
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
