using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Data",menuName ="Music Data")]
public class MusicData : ScriptableObject
{
    public List<Music> musics = new List<Music>();
}
[System.Serializable]
public class Music
{
    public Sprite BackImage;
    public Sprite MusicImage;
    public string MusicTitle;
    public string Composer;
}