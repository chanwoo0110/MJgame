using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//����Ƽ���� �����ϴ� Scene���� ��Ű���� ������

public class ClickJuwonStart : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Juwon");//""�ȿ� ��ȯ�ϰ� ���� Scene �̸� �߰�
    }
}
