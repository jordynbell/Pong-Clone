using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainManager : MonoBehaviour
{

    public TMP_Dropdown dropdown;

    private void Start()
    {
        PlayerPrefs.DeleteKey("GameMode");
        PlayerPrefs.DeleteKey("SelectedOption");

        // Add listener to the dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        // Load the previously selected value from PlayerPrefs
        int savedIndex = PlayerPrefs.GetInt("SelectedOption", 0);
        dropdown.value = savedIndex;
    }

    void OnDropdownValueChanged(int index)
    {
        // Save the selected index to PlayerPrefs
        PlayerPrefs.SetInt("SelectedOption", index);
    }

    public void StartSinglePlayerGame()
    {
        PlayerPrefs.SetInt("GameMode", 1);
        SceneManager.LoadScene(1);
    }

    public void StartPlayerVsPlayerGame()
    {
        PlayerPrefs.SetInt("GameMode", 2);
        SceneManager.LoadScene(1);
    }

}
