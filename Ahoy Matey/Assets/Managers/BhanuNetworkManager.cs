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

    public override void OnStartHost()
    {
        Debug.Log("Host Started");
    }
}