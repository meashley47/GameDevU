using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private Manager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");

        if (other.bounds.max.x >= this.gameObject.GetComponent<Collider>().bounds.max.x)
        {
            Debug.Log("Going Left");
            manager.GoToPrevious();
        }

        else if (other.bounds.max.x <= this.gameObject.GetComponent<Collider>().bounds.max.x)
        {
            Debug.Log("Going Right");
            manager.GoToNext();
        }
    }
}
