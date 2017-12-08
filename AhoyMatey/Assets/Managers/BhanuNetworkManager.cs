using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BhanuNetworkManager : NetworkManager
{   
    public void BhanuStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Host Start Requested");
        StartHost();
    }

    public override void OnClientConnect(NetworkConnection bhanuClientConnection)
    {
        Debug.Log("Client Connected to IP : " + bhanuClientConnection.address);
    }

    public override void OnStartClient(NetworkClient bhanuClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Client Start Requested");
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Host Started");
    }
}