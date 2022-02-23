using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;

    private void Start()
    {
        print("Game Started");
    }

    void Awake()
    {
        if (GameManager.instance == null)
            Instantiate(gameManager);
    }
}
