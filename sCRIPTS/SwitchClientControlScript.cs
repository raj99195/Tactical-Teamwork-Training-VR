using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.VisualScripting;
using Unity.Netcode.Components;
using Unity.Networking;
using Unity.Multiplayer.Sample.Utilities.ClientAuthority;


public class SwitchClientControlScript : NetworkBehaviour
{
    public GameObject ClientTPlayer;
    public GameObject NetworkTPlayer;
    public Transform virtualCamera;


    ClientNetworkTransform TestNetworkTransform;


    [ServerRpc]
    public void TestServerRpc()
    {
        ulong cID = NetworkManager.Singleton.LocalClientId;
        NetworkObject playerObj = NetworkManager.Singleton.ConnectedClients[cID].PlayerObject;
        playerObj.GetComponent<ClientNetworkTransform>().enabled = false;
        playerObj.GetComponent<Camera>();
        Camera cam = playerObj.GetComponent<Camera>();
        virtualCamera.transform.position = cam.transform.localScale;
        Debug.Log(cID.ToString());
        
    }


    public void switchControl()
    {

        TestServerRpc();

    }




   
}
