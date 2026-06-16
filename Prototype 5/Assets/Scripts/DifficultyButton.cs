using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DifficultyButton : MonoBehaviour
{
    public int difficulty;
    private GameManager gameManager;
    private Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
