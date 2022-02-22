using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//유니티에서 제공하는 Scene관련 패키지를 제공함

public class StartButton : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Roby");//""안에 전환하고 싶은 Scene 이름 추가
    }
}
