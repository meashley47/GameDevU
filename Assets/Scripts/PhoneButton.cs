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

            //Temporary, just to remind us the phone can ring
            PhoneIsRinging(true);
        }

        //Opening the phone UI
        else
        {
            button.image.sprite = redPhone;
            blur.SetActive(true);
            phone.SetActive(true);
            PhoneIsRinging(false);
        }
    }

    public void PhoneIsRinging(bool ringing)
    {
        animator.SetBool("ringing", ringing);
    }
}
