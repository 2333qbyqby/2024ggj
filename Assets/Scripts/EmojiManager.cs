using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;

public class EmojiManager :MonoSingleton<EmojiManager>
{
    public List<Sprite> sprites = new List<Sprite>();
    public Dictionary<string,Sprite> spritesDict;
    private void OnEnable()
    {
        spritesDict = new Dictionary<string, Sprite>();
        foreach (Sprite sprite in sprites)
        {
            spritesDict.Add(sprite.name, sprite);//�����б�����ֵ�
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    public void ChangeEmoji(SpriteRenderer spriteRenderer,string emojiName)//���ú������������ͼƬ�ͱ�������
    {
        spriteRenderer.sprite = spritesDict[emojiName];

    }
}
