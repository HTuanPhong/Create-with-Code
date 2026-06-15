using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction spawnDog;
    public float coolDown = 1.0f;
    private float lastSpawn = -10;


    void Start()
    {
        spawnDog.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        float now = Time.time;
        // On spacebar press, send dog
        if (spawnDog.triggered && (now - lastSpawn >= coolDown))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawn = now;
        }
    }
}
