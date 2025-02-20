using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager MainGame;

    public CharaController MainCharacter;
    public CameraController Camera;

    void Awake()
    {
        MainGame = this;
    }
}
