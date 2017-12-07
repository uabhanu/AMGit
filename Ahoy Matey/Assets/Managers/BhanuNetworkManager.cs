using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BhanuNetworkManager : NetworkManager
{   
    public void BhanuStartHost()
    {
       StartHost();
    }

    public override void OnClientConnect(NetworkConnection bhanuClientConnected)
    {
        Debug.Log("Client Connected with Address : " + bhanuClientConnected.address);
    }

    public override void OnStartClient(NetworkClient bhanuClient)
    {
        Debug.Log("Client Started");
    }

    public override void OnStartHost()
    {
        Debug.Log("Host Started");
    }
}