using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private CharaController Chara;

    // Start is called before the first frame update
    void Start()
    {
        Chara = GameManager.MainGame.MainCharacter;
    }

    // Update is called once per frame
    void Update()
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
        Vector3 MousePosition = Input.mousePosition;
        transform.LookAt(MousePosition);
    }
}
