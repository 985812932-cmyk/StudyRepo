using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCObject : InteractableObject
{
    public string npcName;
    public string[] npcContent;
    public DialogueUI dialogueUI;
    
    public void Start()
    {
        // ✅ 如果 Inspector 中没有赋值，才使用代码中的默认值
        if (npcContent == null || npcContent.Length == 0)
        {
            npcContent = new string[]
            {
                "勇士，欢迎来到石家庄",
                "石家庄是一个美丽的城市",
                "请为我歌唱一首《杀死那个石家庄人》"
            };
        }
        
        // 同样处理 npcName
        if (string.IsNullOrEmpty(npcName))
        {
            npcName = "海格";
        }
        
        //dialogueUI = Object.FindFirstObjectByType<DialogueUI>(FindObjectsInactive.Include);
    }
    
    protected override void Interact()
    {
        DialogueUI.Instance.Show(npcName, npcContent);
    }
}
