using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BhanuHUD : MonoBehaviour
{
    NetworkManager m_networkManager;

	void Start() 
    {
		m_networkManager = GetComponent<NetworkManager>();
	}

	void Update() 
    {
		
	}

    void OnHostStarted()
    {
        Debug.Log("Host Started");
    }

    public void BhanuStartHost()
    {
        m_networkManager.StartHost();
    }
}