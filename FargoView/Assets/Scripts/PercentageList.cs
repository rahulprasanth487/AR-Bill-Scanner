using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PercentageList : MonoBehaviour
{
    [System.Serializable]
    public class Profile
    {
        public string name;
        public Sprite icon;
    }

    [SerializeField] Profile[] profiles;

    public List<string> clickedContacts = new List<string>();

    [SerializeField] GameObject DonePercentageButton;
    [SerializeField] GameObject PayAgainPage;
    [SerializeField] GameObject PayAgainPageSplitOption;
    [SerializeField] GameObject PayAgainPageSplitAck;
    [SerializeField] TextMeshProUGUI SplitAck;

    
    void Start()
    {
        GameObject contentTemplate = transform.GetChild(0).gameObject;
        GameObject newOne;

        // clickedContacts.Add("Harish");
        // clickedContacts.Add("Venkat");
        // clickedContacts.Add("Rahul");

        string savedListString = PlayerPrefs.GetString("contacts", "");

        string[] loadedArray = savedListString.Split(',');
        clickedContacts = new List<string>(loadedArray);

        int N=clickedContacts.Count;

        for (int i=0;i<N;++i)
        {
            float per=100/N;
            newOne=Instantiate(contentTemplate,transform);

            for (int j=0;j<profiles.Length;++j)
            {
                if (clickedContacts[i] == profiles[j].name)
                {
                    newOne.transform.GetChild(0).GetComponent<Image>().sprite=profiles[j].icon;
                    break;
                }
            }

            newOne.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text=clickedContacts[i];

            newOne.transform.GetChild(2).GetComponent<TMP_InputField>().text=per.ToString();
        }

        Destroy(contentTemplate);


        // clickedContacts.Add("Harish");
        // clickedContacts.Add("Venkatesh");
        // clickedContacts.Add("Rahul");

        // // string savedListString = PlayerPrefs.GetString("contacts", "");

        // // string[] loadedArray = savedListString.Split(',');
        // // clickedContacts = new List<string>(loadedArray);
        
        // int N=clickedContacts.Count;

        // Debug.Log("Size of clicked contacts"+N);
        
        // float per=100/N;

        // for (int i=0;i<N;++i)
        // {
        //     newOne=Instantiate(contentTemplate,transform);
            
        //     for (int j=0;j<profiles.Length;++j)
        //     {
        //         if (profiles[j].name==clickedContacts[i])
        //         {
        //             newOne.transform.GetChild(0).GetComponent<Image>().sprite=profiles[j].icon;
        //             break;
        //         }
        //     }
        //     // newOne.transform.GetChild(0).GetComponent<Image>().sprite=profiles[i].icon;
        //     newOne.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text=clickedContacts[i];

        //     newOne.transform.GetChild(2).GetComponent<TMP_InputField>().text=per.ToString();
        // }

        // Destroy(contentTemplate);
        
    }

    public void DonePercentageClicked()
    {
        string savedListString = PlayerPrefs.GetString("contacts", "");
        string temp = savedListString.Substring(0, savedListString.Length - 6);
        Debug.Log("Split Acknowledgement: " + temp);

        DonePercentageButton.SetActive(false);
        PayAgainPage.SetActive(true);
        PayAgainPageSplitOption.SetActive(false);
        PayAgainPageSplitAck.SetActive(true);

        SplitAck.text = "Splitted with "+temp;
        PlayerPrefs.SetString("contacts", "");
    }
}
