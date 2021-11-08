using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("SampleScene");
        } else if (Input.GetKeyDown(KeyCode.M))
        {
            Application.LoadLevel("StartScreen");
        }
    }

    public void loadGame()
    {
        //
    }
}
