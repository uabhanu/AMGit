using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using UnityEngine.Networking;

public class BhanuPlayer : NetworkBehaviour
{
    AudioListener m_bhanuListener;
    Camera m_bhanuCamera;
    Rigidbody m_bhanuShipBody;
    Vector3 m_inputValue;

    [SerializeField] float  m_speed;

    void Start()
    {
        m_bhanuShipBody = GetComponent<Rigidbody>();
    }
       
	void FixedUpdate() 
    {
		if(Time.timeScale == 0)
            return;

        if(isLocalPlayer)
        {
            if(CrossPlatformInputManager.GetButton("FWD"))
            {
                transform.Translate(Vector3.forward);
            }

            if(CrossPlatformInputManager.GetButton("BWD"))
            {
                transform.Translate(-Vector3.forward);
            }

            float mouseInput = CrossPlatformInputManager.GetAxis("Mouse X");
            Vector3 rotationWithMouse = new Vector3(0f , mouseInput , 0f);
            transform.Rotate(rotationWithMouse);
        }
	}

    public override void OnStartLocalPlayer()
    {
        m_bhanuListener = GetComponentInChildren<AudioListener>();
        m_bhanuCamera = GetComponentInChildren<Camera>();

        m_bhanuListener.enabled = true;
        m_bhanuCamera.enabled = true;
    }
}