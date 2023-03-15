using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZoneManager : MonoBehaviour
{
    //-------ZONE-4----
    public GameObject RhAwt4Panel;
    public GameObject Rh4InspectionPanel;
    public GameObject maximizeImg4;
    public GameObject minimizeImg4;
    public GameObject maximizeImg6;
    public GameObject minimizeImg6;
    //--ZOne 4-----------

    //Canopy Animation--------------
    public Animator CanopyAnimator;


    //TASK BAR ------------
    //public GameObject TaskBar4Right;
    //public GameObject TaskBar6Left;
    //TASK BAR -------------

    public void CanopyAnimationPlay()
    {
        CanopyAnimator.SetBool("CanopyAnim", !CanopyAnimator.GetBool("CanopyAnim"));
    }

    //Canopy Animation-----------
    //ZOne-4-------NAVIGATION LIGHT---
    public GameObject Lh4NavLight;
    public GameObject Lh4infoPanel;
    //ZOne-4-------NAVIGATION LIGHT---
    //ZOne-6-------NAVIGATION LIGHT---
    public GameObject Rh6NavLight;
    public GameObject Rh6infoPanel;
    //ZOne-6-------NAVIGATION LIGHT---



    //Zon-6----
    public GameObject RhAwt6Panel;
    public GameObject Rh6InspectionPanel;
    //Zone6-----------


    //Zone 4================

    //-------Show LH WING Panel-------
    public void Show4RHAwtPanel()
    {
        //TaskBar4Right.SetActive(true);
        RhAwt4Panel.SetActive(true);
       
    }

    //-----START INSPECTION PANEL-------
    public void Start4Inspection()
    {
        Rh4InspectionPanel.SetActive(true);
    }

    //---------------- CLOSE LH WING PANEL-----------------
    public void Close4RHAWTPanel()
    {
        //TaskBar4Right.SetActive(false);
        //maximizeImg4.SetActive(true);
        RhAwt4Panel.SetActive(false);
    }
    

    //CLOSE LH ZONE_4 INSPECTION PANEL---------
    public void Close4InspectionPanel()
    {
        Rh4InspectionPanel.SetActive(false);
    }

    //Zone6==========

    //SHOW  RH WING ZONE PANEL--------------
    public void Show6RHAwt6Panel()
    {
        //TaskBar6Left.SetActive(true);
        RhAwt6Panel.SetActive(true);

    }
    //------SHOW INSPECTION PANEL-----------------
    public void Start6Inspection()
    {
        Rh6InspectionPanel.SetActive(true);
    }
    // CLOSE RH WING PANEL-------
    public void Close6RHAWT6Panel()
    {
        //maximizeImg6.SetActive(true);
        //TaskBar6Left.SetActive(false);
        RhAwt6Panel.SetActive(false);
    }

    //--------CLOSE RH WING INSPECTION PANEL--
    public void Close6InspectionPanel()
    {
        Rh6InspectionPanel.SetActive(false);
    }
    //Zone6 END=====================


    //----MIRAGE SHOW Z6 NAVIGATION LIGHT------------
    public void ShowZ6NavigationLight()
    {
        Rh6NavLight.SetActive(true);
    }
    public void HideZ6NavigationLight()
    {
        Rh6NavLight.SetActive(false);    
    }
    public void StartZ6LightInfoPanel()
    {
        Rh6infoPanel.SetActive(true);
    }
    public void CloseZ6LightInfoPanel()
    {
        Rh6infoPanel.SetActive(false);
    }
    //---------HIDE Z6 NAVIGATION LIGHT PANEL------

    //------SHOW Z4 LH NAVIGATION LIGHT------
    public void ShowZ4NavigationLight()
    {
        Lh4NavLight.SetActive(true);
    }
    public void HideZ4NavigationLight()
    {
        Lh4NavLight.SetActive(false);
    }
    public void StartZ4LightInfoPanel()
    {
        Lh4infoPanel.SetActive(true);
    }
    public void CloseZ4LightInfoPanel()
    {
        Lh4infoPanel.SetActive(false);
    }
    //---------HIDE Z4 NAVIGATION LIGHT PANEL------

    public void Home()
    {
        SceneManager.LoadScene("CanopyScene");
    }


    //MINIMIZE__4
    public void Minimize4Panel()
    {

        maximizeImg4.SetActive(true);
        RhAwt4Panel.SetActive(false);
        maximizeImg4.SetActive(true);
    }
    public void MaxiMize4Panel()
    {
        Show4RHAwtPanel();
        //RhAwt4Panel.SetActive(true);
    }

    //MINIMIZE___6
    public void Minimize6Panel()
    {

        maximizeImg6.SetActive(true);
        RhAwt6Panel.SetActive(false);
        maximizeImg6.SetActive(true);
    }


    public void MaxiMize6Panel()
    {
        Show6RHAwt6Panel();
        //RhAwt6Panel.SetActive(true);
    }
}
