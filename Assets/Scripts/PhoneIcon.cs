using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneIcon : MonoBehaviour
{
    public GameObject phone;
    public GameObject blur;
    public Sprite redPhone;
    public Sprite greenPhone;
    public Button phoneButton;

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
        //Phone is already open, want to close it
        if (phone.activeInHierarchy)
        {
            phoneButton.image.sprite = greenPhone;
            blur.SetActive(false);
            phone.SetActive(false);
        }

        //Open phone
        else
        {
            phoneButton.image.sprite = redPhone;
            blur.SetActive(true);
            phone.SetActive(true);
        }
    }
}
