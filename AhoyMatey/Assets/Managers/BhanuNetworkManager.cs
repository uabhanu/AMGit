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
        Debug.Log(Time.timeSinceLevelLoad + " Client Connected to IP : " + bhanuClientConnection.address);
        CancelInvoke();
    }

    public override void OnStartClient(NetworkClient bhanuClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Client Start Requested");
        InvokeRepeating("PrintDots" , 0f , 0.95f);
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Host Started");
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}