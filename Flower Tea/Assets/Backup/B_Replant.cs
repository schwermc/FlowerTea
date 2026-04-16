using System.Collections.Generic;
using UnityEngine;

public class B_Replant : MonoBehaviour
{
    [SerializeField] List<Sprites> m_Sprites;
    [SerializeField] List<Flowers> m_Flowers;

    public float _Time;
    public float _Wilt;

    private void Awake()
    {
        _Time = m_Sprites[0].time;
        RandomTime();
    }

    public void Replant()
    {
        foreach(var sprite in m_Sprites)
        {
            if (sprite.isWilted())
            {
                sprite.updateSprite(m_Flowers[NewFlower()]);
                sprite.time = RandomTime(_Time);
            }
        }
    }

    void RandomTime()
    {
        foreach (var sprite in m_Sprites) { sprite.time = Random.Range(1, _Time); }
    }

    float RandomTime(float time) { return Random.Range(1, time + 1f); }
    int NewFlower() { return Random.Range(0, m_Flowers.Count); }
}
