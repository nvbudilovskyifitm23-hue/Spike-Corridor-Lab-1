using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WinManager : MonoBehaviour
{
    [SerializeField] private float restartDelay = 3f;

    public void OnWin()
    {
        StartCoroutine(RestartAfterDelay());
    }

    private IEnumerator RestartAfterDelay()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}