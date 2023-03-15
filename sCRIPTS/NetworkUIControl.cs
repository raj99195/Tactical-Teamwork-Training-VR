using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class NetworkUIControl : MonoBehaviour
{
    
    public GameObject tempPlayer;


    public void HostBTN()
    {
        tempPlayer.SetActive(false);
        NetworkManager.Singleton.StartHost();
        
    }
    public void ClientBTN()
    {
        tempPlayer.SetActive(false);
        NetworkManager.Singleton.StartClient();

    }
    public void ServerBTN()
    {
        NetworkManager.Singleton.StartServer();

    }

    public void StartMaintenance()
    {
        SceneManager.LoadScene("CanopyScene");
    }

    public void QuitMaintenance()
    {
        SceneManager.LoadScene("MainScene");
    }

}
