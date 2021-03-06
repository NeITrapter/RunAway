﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RunButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private PlayerController _playerController;

    private void Start()
    {
        _playerController = FindObjectOfType<PlayerController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _playerController.SpeedUp();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _playerController.SpeedDown();
    }
}
