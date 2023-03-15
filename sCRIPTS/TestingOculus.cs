using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestingOculus : MonoBehaviour
{
    public GameObject mirage;
    public GameObject canvasMain;
    public GameObject  tt;
    bool isActive;
    public GameObject AboutM;
    public GameObject ZonePanel;
    public void Activate()
    {
        Debug.Log("Clicked !");
        mirage.SetActive(true);
    }

    public void Deactivate()
    {
        mirage.SetActive(false);
    }

    public void AboutMe()
    {
        AboutM.SetActive(true);
    }

    public void CanvasMM()
    {
        canvasMain.SetActive(true);
    }

    public void Back()
    {
        if(!isActive)
        {
            tt.SetActive(true);
        }
        else
        {
            tt.SetActive(false);
        }    
    }

    public void ZoneActivatePanel()
    {
        ZonePanel.SetActive(true );
    }

    public void AllOffCanvas()
    {
        mirage.SetActive(false);
        canvasMain.SetActive(false);
        tt.SetActive(false);
        ZonePanel.SetActive(false);
    }

    public void AllOnCanvas()
    {
        mirage.SetActive(true);
        canvasMain.SetActive(true);
        tt.SetActive(true);
        ZonePanel.SetActive(true);
    }
}
