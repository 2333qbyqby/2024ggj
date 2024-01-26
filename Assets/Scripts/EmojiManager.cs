using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fivuvuvUtil;

public class EmojiManager :MonoSingleton<EmojiManager>
{
    public List<Sprite> sprites = new List<Sprite>();
    public Dictionary<string,Sprite> spritesDict;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        spritesDict = new Dictionary<string,Sprite>();
        foreach(Sprite sprite in sprites)
        {
            spritesDict.Add(sprite.name, sprite);//�����б�����ֵ�
        }
    }

    public void ChangeEmoji(SpriteRenderer spriteRenderer,string emojiName)//���ú������������ͼƬ�ͱ�������
    {
        spriteRenderer.sprite = spritesDict[emojiName];

    }
}
