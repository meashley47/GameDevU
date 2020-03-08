using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(canvas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToPrevious()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
