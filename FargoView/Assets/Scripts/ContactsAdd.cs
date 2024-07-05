using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContactsAdd : MonoBehaviour
{
    [SerializeField] GameObject HarishButton;
    [SerializeField] GameObject VenkatButton;
    [SerializeField] GameObject RaviButton;
    [SerializeField] GameObject TracyButton;
    [SerializeField] GameObject RishikButton;
    [SerializeField] GameObject doneButton;
    [SerializeField] GameObject ContactsAddPanel;
    [SerializeField] GameObject DescPanel;

    //Panels
    [SerializeField] GameObject Panel1;
    [SerializeField] TextMeshProUGUI Panel1_Text;
    [SerializeField] Image Panel1_Image;
    [SerializeField] GameObject Panel2;
    [SerializeField] TextMeshProUGUI Panel2_Text;
    [SerializeField] Image Panel2_Image;
    [SerializeField] GameObject Panel3;
    [SerializeField] TextMeshProUGUI Panel3_Text;
    [SerializeField] Image Panel3_Image;
    [SerializeField] GameObject Panel4;
    [SerializeField] TextMeshProUGUI Panel4_Text;
    [SerializeField] Image Panel4_Image;
    [SerializeField] GameObject Panel5;
    [SerializeField] TextMeshProUGUI Panel5_Text;
    [SerializeField] Image Panel5_Image;

    [SerializeField] GameObject OnePlus;
    [SerializeField] GameObject TwoPlus;
    [SerializeField] GameObject One_X;
    [SerializeField] GameObject Two_X;
    
    //Sprites

    [SerializeField] Sprite Harish;
    [SerializeField] Sprite Venkat;
    [SerializeField] Sprite Ravi;
    [SerializeField] Sprite Tracy;
    [SerializeField] Sprite Rishik;



    public List<string> clickedContacts = new List<string>();
    public void HarishClicked()
    {
        if(!clickedContacts.Contains("Harish"))
        {
            clickedContacts.Add("Harish");
            Debug.Log(clickedContacts.Count);
            if(!Panel1.activeSelf)
            {
                Panel1.SetActive(true);
                Panel1_Text.text = "Harish";
                Panel1_Image.sprite = Harish;
            }
            else if(!Panel2.activeSelf)
            {
                Panel2.SetActive(true);
                Panel2_Text.text = "Harish";
                Panel2_Image.sprite = Harish;
            }
            else if(!Panel3.activeSelf)
            {
                Panel3.SetActive(true);
                Panel3_Text.text = "Harish";
                Panel3_Image.sprite = Harish;
            }
            else if(!OnePlus.activeSelf)
            {
                OnePlus.SetActive(true);
                Panel4_Text.text = "Harish";
                Panel4_Image.sprite = Harish;
            }
            else
            {
                OnePlus.SetActive(false);
                TwoPlus.SetActive(true);
                Panel5_Text.text = "Harish";
                Panel5_Image.sprite = Harish;
            }
        }
    }

    public void VVClicked()
    {
        if(!clickedContacts.Contains("Venkat"))
        {
            clickedContacts.Add("Venkat");
            Debug.Log(clickedContacts.Count);
            if(!Panel1.activeSelf)
            {
                Panel1.SetActive(true);
                Panel1_Text.text = "Venkat";
                Panel1_Image.sprite = Venkat;
            }
            else if(!Panel2.activeSelf)
            {
                Panel2.SetActive(true);
                Panel2_Text.text = "Venkat";
                Panel2_Image.sprite = Venkat;
            }
            else if(!Panel3.activeSelf)
            {
                Panel3.SetActive(true);
                Panel3_Text.text = "Venkat";
                Panel3_Image.sprite = Venkat;
            }
            else if(!OnePlus.activeSelf)
            {
                OnePlus.SetActive(true);
                Panel4_Text.text = "Venkat";
                Panel4_Image.sprite = Venkat;
            }
            else
            {
                OnePlus.SetActive(false);
                TwoPlus.SetActive(true);
                Panel5_Text.text = "Venkat";
                Panel5_Image.sprite = Venkat;
            }

        }
    }

    public void TracyClicked()
    {
        if(!clickedContacts.Contains("Tracy"))
        {
            clickedContacts.Add("Tracy");
            Debug.Log(clickedContacts.Count);
            if(!Panel1.activeSelf)
            {
                Panel1.SetActive(true);
                Panel1_Text.text = "Tracy";
                Panel1_Image.sprite = Tracy;
            }
            else if(!Panel2.activeSelf)
            {
                Panel2.SetActive(true);
                Panel2_Text.text = "Tracy";
                Panel2_Image.sprite = Tracy;
            }
            else if(!Panel3.activeSelf)
            {
                Panel3.SetActive(true);
                Panel3_Text.text = "Tracy";
                Panel3_Image.sprite = Tracy;
            }
            else if(!OnePlus.activeSelf)
            {
                OnePlus.SetActive(true);
                Panel4_Text.text = "Tracy";
                Panel4_Image.sprite = Tracy;
            }
            else
            {
                OnePlus.SetActive(false);
                TwoPlus.SetActive(true);
                Panel5_Text.text = "Tracy";
                Panel5_Image.sprite = Tracy;
            }
        }
        
    }

    public void RaviClicked()
    {
        if(!clickedContacts.Contains("Ravi"))
        {
            clickedContacts.Add("Ravi");
            Debug.Log(clickedContacts.Count);
            if(!Panel1.activeSelf)
            {
                Panel1.SetActive(true);
                Panel1_Text.text = "Ravi";
                Panel1_Image.sprite = Ravi;
            }
            else if(!Panel2.activeSelf)
            {
                Panel2.SetActive(true);
                Panel2_Text.text = "Ravi";
                Panel2_Image.sprite = Ravi;
            }
            else if(!Panel3.activeSelf)
            {
                Panel3.SetActive(true);
                Panel3_Text.text = "Ravi";
                Panel3_Image.sprite = Ravi;
            }
            else if(!OnePlus.activeSelf)
            {
                OnePlus.SetActive(true);
                Panel4_Text.text = "Ravi";
                Panel4_Image.sprite = Ravi;
            }
            else
            {
                OnePlus.SetActive(false);
                TwoPlus.SetActive(true);
                Panel5_Text.text = "Ravi";
                Panel5_Image.sprite = Ravi;
            }
        }
        
    }

    public void RishikClicked()
    {
        if(!clickedContacts.Contains("Rishik"))
        {
            clickedContacts.Add("Rishik");
            Debug.Log(clickedContacts.Count);
            if(!Panel1.activeSelf)
            {
                Panel1.SetActive(true);
                Panel1_Text.text = "Rishik";
                Panel1_Image.sprite = Rishik;
            }
            else if(!Panel2.activeSelf)
            {
                Panel2.SetActive(true);
                Panel2_Text.text = "Rishik";
                Panel2_Image.sprite = Rishik;
            }
            else if(!Panel3.activeSelf)
            {
                Panel3.SetActive(true);
                Panel3_Text.text = "Rishik";
                Panel3_Image.sprite = Rishik;
            }
            else if(!OnePlus.activeSelf)
            {
                OnePlus.SetActive(true);
                Panel4_Text.text = "Rishik";
                Panel4_Image.sprite = Rishik;
            }
            else
            {
                OnePlus.SetActive(false);
                TwoPlus.SetActive(true);
                Panel5_Text.text = "Rishik";
                Panel5_Image.sprite = Rishik;
            }

        }
    }


    public void OnePlusClicked()
    {
        Debug.Log("+1 Clicked");
        Panel4.SetActive(true);
        One_X.SetActive(true);
        OnePlus.SetActive(false);
    }

    public void TwoPlusClicked()
    {
        Debug.Log("+2 clicked");
        Panel4.SetActive(true);
        Panel5.SetActive(true);
        OnePlus.SetActive(false);
        One_X.SetActive(false);
        Two_X.SetActive(true);
        TwoPlus.SetActive(false);
    }

    public void One_XClicked()
    {
        Panel4.SetActive(false);
        One_X.SetActive(false);
        TwoPlus.SetActive(false);
        Two_X.SetActive(false);
        OnePlus.SetActive(true);
    }

    public void Two_XClicked()
    {
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        One_X.SetActive(false);
        OnePlus.SetActive(false);
        Two_X.SetActive(false);
        TwoPlus.SetActive(true);
    }

    public void temp()
    {
        Debug.Log("Temp");
    }


    public void DoneClicked()
    {
        PlayerPrefs.SetString("contacts", "");

        clickedContacts.Add("Rahul");

        string listString = string.Join(",", clickedContacts.ToArray());

        Debug.Log(listString);
        
        PlayerPrefs.SetString("contacts", listString);
        PlayerPrefs.Save();

        DescPanel.SetActive(true);
        ContactsAddPanel.SetActive(false);
    }


    

}
