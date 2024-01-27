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
            spritesDict.Add(sprite.name, sprite);//遍历列表加入字典
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    public void ChangeEmoji(SpriteRenderer spriteRenderer,string emojiName)//公用函数，传入表情图片和表情名字
    {
        spriteRenderer.sprite = spritesDict[emojiName];

    }
}
