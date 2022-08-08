using UnityEngine;

public class SonidosFinPartida : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip completado;
    public AudioClip gameOver;

    public void GameOver()
    {
        ReproduceSonido(gameOver);
    }

    public void NivelCompletado()
    {
        ReproduceSonido(completado);
    }

    private void ReproduceSonido(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.loop = false;
        audioSource.Play();
    }
}
