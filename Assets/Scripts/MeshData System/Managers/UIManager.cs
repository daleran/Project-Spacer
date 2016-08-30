﻿using UnityEngine;

namespace ProjectSpacer
{

    public class UIManager : MonoBehaviour
    {

        HelpPanel playerControls;

        // Use this for initialization
        void Start()
        {
            playerControls = GetComponentInChildren<HelpPanel>();
        }

        void Update()
        {
            if (GameManager.inputManger.help.GetToggleState())
            {
                playerControls.gameObject.SetActive(true);
            }
            else
            {
                playerControls.gameObject.SetActive(false);
            }



        }

    }
}
