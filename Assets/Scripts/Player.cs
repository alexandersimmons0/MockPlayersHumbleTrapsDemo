using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer {
    private CharacterController characterController;
    public int Health {get; set; }
    [SerializeField] private bool isPlayer;
    public bool IsPlayer => isPlayer;

    private void Awake(){
        characterController = GetComponent<CharacterController>();
    }
    
    private void Update(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        characterController.Move(new Vector3(horizontal,0,vertical));
    }
}
