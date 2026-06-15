using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    static public int lives = 3;
    static public int score = 0;

    public int hunger = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            lives -= 1;
            Debug.Log($"Lives = {lives}");
            if (lives <= 0)
            {
                Debug.Log("Game Over!");
                Destroy(other);
            }
        }
        else if (other.tag == "Food")
        {
            hunger -= 1;
            if (hunger <= 0)
            {
                Destroy(gameObject);
            }
            score += 1;
            Destroy(other);
            Debug.Log($"Score = {score}");
        }
    }
}
