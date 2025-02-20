using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager MainGame;

    public CharaController MainCharacter;

    void Awake()
    {
        MainGame = this;
    }
}
