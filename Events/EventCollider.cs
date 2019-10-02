﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class EventCollider : MonoBehaviour
{
    public GameEvent EnterEvent;
    public GameEvent ExitEvent;
    public GameEvent StayEvent;

    void OnTriggerEnter(Collider other) {
        EnterEvent?.Raise();
    }

    void OnTriggerExit(Collider other) {
        ExitEvent?.Raise();
    }

    void OnTriggerStay(Collider other) {
        StayEvent?.Raise();
    }
}
