﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Klikk : MonoBehaviour
{
    public void Byrja() // Hjalpar aðra að virka
    {
        SceneManager.LoadScene(1);
    }
}
