using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    [Header("Player Health Initializer")] 
    public int minHealth;
    public int maxHealth;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(minHealth);
        Debug.Log(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < maxHealth; i++)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                maxHealth--;
                Debug.Log(maxHealth);
            }
        }
        
        if (maxHealth == minHealth)
        {
            Debug.Log("Game Over");
        }
    }
}
