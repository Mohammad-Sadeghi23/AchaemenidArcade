using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the HubWorld scene when the player clicks "Play"
        // HubWorld is the open world where the player can explore and interact with the game
        Debug.Log("Starting Game");
        SceneManager.LoadScene("HubWorld");
    }

    public void OpenOptions()
    {
        // Placeholder for options menu functionality
        // This could be expanded to include settings for audio, graphics, controls, etc.
        Debug.Log("Options Menu - Coming Soon");
    }

    public void QuitGame()
    {
        // Quit the game when the player clicks "Quit"
        // Note: This will only work in a built application, not in the Unity Editor
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
