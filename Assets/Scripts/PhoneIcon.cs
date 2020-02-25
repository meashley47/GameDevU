using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneIcon : MonoBehaviour
{
    public GameObject phone;
    public GameObject blur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IconClicked()
    {
        if (phone.activeInHierarchy)
        {
            blur.SetActive(false);
            phone.SetActive(false);
        }

        else
        {
            blur.SetActive(true);
            phone.SetActive(true);
        }
    }
}
