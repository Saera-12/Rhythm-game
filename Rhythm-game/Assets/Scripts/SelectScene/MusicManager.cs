using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private MusicDatas musicDatas;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Image background;
    [SerializeField] private Text musictitle;
    [SerializeField] private Text composer;

    private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        Play(currentIndex);
    }

    private void Play(int index)
    {
        currentIndex = index;
        audioSource.clip = musicDatas.musics[currentIndex].Clip;
        audioSource.Play();

        musictitle.text = musicDatas.musics[currentIndex].MusicTitle;
        composer.text = musicDatas.musics[currentIndex].Composer;
        background.sprite = musicDatas.musics[currentIndex].Background;
    }
    public void Next()
    {
        int nextIndex = (currentIndex + 1) % musicDatas.musics.Count;
        Play(nextIndex);
    }
    public void Back()
    {
        int backIndex = (currentIndex - 1+ musicDatas.musics.Count) % musicDatas.musics.Count;
        Play(backIndex);
    }
}
