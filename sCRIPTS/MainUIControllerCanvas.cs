using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIControllerCanvas : MonoBehaviour
{
    public GameObject welcomeScreenPanel;
    public GameObject welcomeScreenExitPanel;
    public GameObject profileSelectionPanel;


    private void Start()
    {
        ActivateMyPanel(welcomeScreenPanel.name);
    }

    public void ActivateMyPanel(string panelName)
    {
        welcomeScreenPanel.SetActive(panelName.Equals(welcomeScreenPanel.name));
        welcomeScreenExitPanel.SetActive(panelName.Equals(welcomeScreenExitPanel.name));
        profileSelectionPanel.SetActive(panelName.Equals(profileSelectionPanel.name));
    }



    #region  Main Menu UI BUtton Funtcions and Methods

    public void GoToProfileSelectionPanel()
    {
        ActivateMyPanel(profileSelectionPanel.name);
    }

    public void QuitButtonClicked()
    {
        ActivateMyPanel(welcomeScreenExitPanel.name);
    }

    public void QuitConfirmYesButtonClicked()
    {
        Application.Quit();
    }
    public void QuitConfirmNOButtonClicked()
    {
        ActivateMyPanel(welcomeScreenPanel.name);
    }

    public void AreYouTrainerClicked()
    {
        SceneManager.LoadScene("TestingScene");
    }

    public void AreYouTrainEEClicked()
    {
        SceneManager.LoadScene("TestingScene");
    }

    public void BackToHome()
    {
        ActivateMyPanel(welcomeScreenPanel.name);
    }



    #endregion




}
