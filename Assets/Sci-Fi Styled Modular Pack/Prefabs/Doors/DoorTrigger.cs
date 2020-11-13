﻿using UnityEngine;

public class DoorTrigger : MonoBehaviour {
    [SerializeField] Animator animator;

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
            animator.SetBool("character_nearby", true);
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player"))
            animator.SetBool("character_nearby", false);
    }
}
