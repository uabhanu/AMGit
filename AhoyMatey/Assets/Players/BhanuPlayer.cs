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

            m_inputValue.x = Input.GetAxis("Horizontal");
            m_inputValue.y = 0f;
            m_inputValue.z = Input.GetAxis("Vertical");

            transform.Translate(m_inputValue);
	}
}
