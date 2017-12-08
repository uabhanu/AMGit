using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using UnityEngine.Networking;

public class BhanuPlayer : NetworkBehaviour
{
    Vector3 m_inputValue;

	void Start() 
    {
		
	}

	void Update() 
    {
		if(Time.timeScale == 0)
            return;

        if(isLocalPlayer)
        {
            m_inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
            m_inputValue.y = 0f;
            m_inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

            transform.Translate(m_inputValue);
        }
	}
}