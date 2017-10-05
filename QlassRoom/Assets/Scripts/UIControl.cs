using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject activePanel;

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
        activePanel = panel;
        closeOtherPanels();
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void closeOtherPanels()
    {
        foreach (GameObject p in panels)
        {
            if(p != activePanel && p.active)
            {
                p.SetActive(false);
            }
        }
    }

}
