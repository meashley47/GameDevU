using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneButton : MonoBehaviour
{
    public GameObject phone;
    public GameObject blur;
    public Sprite redPhone;
    public Sprite greenPhone;
    Button button;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject.GetComponent<Button>();
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IconClicked()
    {
        //Closing the phone UI
        if (phone.activeInHierarchy)
        {
            button.image.sprite = greenPhone;
            blur.SetActive(false);
            phone.SetActive(false);
        }

        //Opening the phone UI
        else
        {
            button.image.sprite = redPhone;
            blur.SetActive(true);
            phone.SetActive(true);
            TogglePhoneRinging(false);
        }
    }

    public void TogglePhoneRinging(bool ringing)
    {
        animator.SetBool("Ringing", ringing);
    }

    public void RingPhone()
    {
        //Only ring the phone if the phone interface isn't open
        if (button.image.sprite == greenPhone)
        {
            TogglePhoneRinging(true);
        }
    }
}
