using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UMainMenuButton : UIButton
{
    public override void Clicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
