using UnityEngine;

public class MainManu : MonoBehaviour
{
    public void GameStart() // 함수의 이름은 동사로
    {
        Debug.Log("Start Game");
    }

    public void ShowSystemPanel()
    {
        Debug.Log("System");
    }

    public void Quit()
    {
        Debug.Log("Quit Game");
    }
}
