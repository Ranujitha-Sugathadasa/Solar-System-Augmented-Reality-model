using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiLoadScene : MonoBehaviour
{
    public string sceneSunToLoad = "Scenes/Sun"; // Scene to load for Sun object
    public string sceneMercuryToLoad = "Scenes/Mercury"; // Scene to load for Mercury object
    public string sceneVenusToLoad = "Scenes/Venus"; // Scene to load for Venus object
    public string sceneEarthToLoad = "Scenes/Earth"; // Scene to load for Earth object
    public string sceneMarsToLoad = "Scenes/Mars"; // Scene to load for Mars object
    public string sceneJupiterToLoad = "Scenes/Jupiter"; // Scene to load for Jupiter object
    public string sceneSaturnToLoad = "Scenes/Saturn"; // Scene to load for Saturn object
    public string sceneUranusToLoad = "Scenes/Uranus"; // Scene to load for Uranus object
    public string sceneNeptuneToLoad = "Scenes/Neptune"; // Scene to load for Neptune object

    public GameObject Sun; // Reference to Sun object (optional)
    public GameObject Mercury; // Reference to Mercury object (optional)
    public GameObject Venus; // Reference to Venus object (optional)
    public GameObject Earth; // Reference to Earth object (optional)
    public GameObject Mars; // Reference to Mars object (optional)
    public GameObject Jupiter; // Reference to Jupiter object (optional)
    public GameObject Saturn; // Reference to Saturn object (optional)
    public GameObject Uranus; // Reference to Uranus object (optional)
    public GameObject Neptune; // Reference to Neptune object (optional)

    void OnMouseDown()
    {
        // Check which object was clicked and load the corresponding scene
        if (this.gameObject == Sun) // Check if Sun object was clicked
        {
            SceneManager.LoadScene(sceneSunToLoad);
        }
        else if (this.gameObject == Mercury) // Check if Mercury object was clicked
        {
            SceneManager.LoadScene(sceneMercuryToLoad);
        }
        else if (this.gameObject == Venus) // Check if Venus object was clicked
        {
            SceneManager.LoadScene(sceneVenusToLoad);
        }
        else if (this.gameObject == Earth) // Check if Earth object was clicked
        {
            SceneManager.LoadScene(sceneEarthToLoad);
        }
        else if (this.gameObject == Mars) // Check if Mars object was clicked
        {
            SceneManager.LoadScene(sceneMarsToLoad);
        }
        else if (this.gameObject == Jupiter) // Check if Jupiter object was clicked
        {
            SceneManager.LoadScene(sceneJupiterToLoad);
        }
        else if (this.gameObject == Saturn) // Check if Saturn object was clicked
        {
            SceneManager.LoadScene(sceneSaturnToLoad);
        }
        else if (this.gameObject == Uranus) // Check if Uranus object was clicked
        {
            SceneManager.LoadScene(sceneUranusToLoad);
        }
        else if (this.gameObject == Neptune) // Check if Neptune object was clicked
        {
            SceneManager.LoadScene(sceneNeptuneToLoad);
        }
    }
}