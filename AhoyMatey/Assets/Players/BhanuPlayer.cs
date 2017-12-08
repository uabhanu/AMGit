using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class BhanuPlayer : MonoBehaviour 
{
    Vector3 m_inputValue;

	void Start() 
    {
		
	}

	void Update() 
    {
		if(Time.timeScale == 0)
            return;

            m_inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
            m_inputValue.y = 0f;
            m_inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

            transform.Translate(m_inputValue);
	}
}
