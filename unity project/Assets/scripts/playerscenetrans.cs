﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerscenetrans : MonoBehaviour
{
    GameObject raycastedObj;
    ObjectInteraction referencedScript;
    public Text nextE;
    public Text endE;
    public AudioSource BeachAudio;

    [SerializeField] private int InteractionRange = 2;
    [SerializeField] private LayerMask scenetransitionLayer;

    // Update is called once per frame


    void Start()
    {
        nextE.enabled = false;
        endE.enabled = false;
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, InteractionRange, scenetransitionLayer.value))
        {
            if (hit.collider.CompareTag("next"))
            {
                nextE.enabled = true;
                raycastedObj = hit.collider.gameObject;
                referencedScript = raycastedObj.GetComponent<ObjectInteraction>();

                if (Input.GetKeyDown("e") && (referencedScript != null))
                {
                    referencedScript.interact();
                    raycastedObj = null;
                    referencedScript = null;
                    raycastedObj = null;
                }
            }
            if (hit.collider.CompareTag("end"))
            {
                endE.enabled = true;
                raycastedObj = hit.collider.gameObject;
                referencedScript = raycastedObj.GetComponent<ObjectInteraction>();

                if (Input.GetKeyDown("e") && (referencedScript != null))
                {
                    referencedScript.interact();
                    raycastedObj = null;
                    referencedScript = null;
                    raycastedObj = null;
                }
            }
            if (hit.collider.CompareTag("beach"))
            {
                BeachAudio.Play();
            }
        }
        else
        {
            nextE.enabled = false;
            endE.enabled = false;
        }

    }
}
