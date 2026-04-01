using UnityEngine;
using UnityEngine.UI;

public class Tabcontroler : MonoBehaviour
{
    public Image[] tabImages;
    public GameObject[] pages;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activatetab(0);
    }

    public void activatetab(int Tabno)
    {
        for(int i =0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabImages[i].color = Color.grey;
        }
        pages[Tabno].SetActive(true);
        tabImages[Tabno].color = Color.white;
    }
}
