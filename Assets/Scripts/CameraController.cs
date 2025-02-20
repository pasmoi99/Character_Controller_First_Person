using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    [SerializeField] private float _cameraSpeed;
    private float _cameraVerticalRotation = 0f;

    private CharaController Chara;


    void Start()
    {
        Chara = GameManager.MainGame.MainCharacter;
    }

    void FixedUpdate()
    {
        SetPosition();
        SetRotation();
    }

    private void SetPosition()
    {
        transform.position = Chara.transform.position;
    }

    private void SetRotation()
    {
        float MouseX = _cameraSpeed * Input.GetAxis("Mouse X");
        float MouseY = _cameraSpeed * Input.GetAxis("Mouse Y");

        _cameraVerticalRotation -= MouseY;
        _cameraVerticalRotation = Mathf.Clamp(_cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * _cameraVerticalRotation;

        transform.Rotate(Vector3.up * MouseX);

        //Vector3 MousePosition = Input.mousePosition;
        //Debug.Log(MousePosition);
        //transform.LookAt(MousePosition);

        //transform.Rotate(0,0,v);

    }
}
