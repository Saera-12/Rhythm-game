using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Data",menuName="MusicData")]
public class MusicDatas : ScriptableObject
{
    public List<Music> musics = new List<Music>();
}
[System.Serializable]

public class Music
{
    public Sprite Background;
    [TextArea]
    public string MusicTitle;
    public string Composer;
    public AudioClip Clip;
}
