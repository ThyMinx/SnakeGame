using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool paused = false;
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (paused)
            {
                pauseMenu.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                paused = true;
                Time.timeScale = 0;
            }
        }
    }

}
