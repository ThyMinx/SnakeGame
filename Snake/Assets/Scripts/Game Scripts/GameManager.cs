using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool paused = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (paused)
            {
                paused = false;
                Time.timeScale = 1;
            }
            else
            {
                paused = true;
                Time.timeScale = 0;
            }
        }
    }

}
