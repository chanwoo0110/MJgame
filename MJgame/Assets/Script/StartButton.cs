using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//����Ƽ���� �����ϴ� Scene���� ��Ű���� ������

public class StartButton : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Roby");//""�ȿ� ��ȯ�ϰ� ���� Scene �̸� �߰�
    }
}
