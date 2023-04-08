using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    #region SerializedVariables

    [SerializeField] private float _walkSpeed = 7.50f;
    [SerializeField] private float _runSpeed = 11.50f;
    [SerializeField] private float _jumpSpeed = 8.00f;
    [SerializeField] private float _gravity = 20.00f;


    [SerializeField] private float _lookSpeed = 2.00f;
    [SerializeField] private float _lookXLimit = 45.00f;

    #endregion
    #region GetVariables

    public float GetGravity() => _gravity;
    public float GetJumpSpeed() => _jumpSpeed;
    public float GetLookSpeed() => _lookSpeed;
    public float GetLookXLimit() => _lookXLimit;

    #endregion
    #region Private Values

    private CharacterController _characterController;

    #endregion

    private void Awake() => _characterController = GetComponent<CharacterController>();

    public void Move(Vector3 direction) => _characterController.Move(direction * Time.deltaTime);

    public void ReturnHorizontal(bool isSprint, out float horizontalInput) => horizontalInput = isSprint ? _runSpeed : _walkSpeed;
    public void ReturnVertical(bool isSprint, out float verticalInput) => verticalInput = isSprint ? _runSpeed : _walkSpeed;

    public CharacterController GetCharacterController() => _characterController;
}