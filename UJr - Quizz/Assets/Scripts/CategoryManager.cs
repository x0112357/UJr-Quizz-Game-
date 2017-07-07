using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryManager : MonoBehaviour
{
    public List<QuestionListWrapper> Categories;
    public static QuestionListWrapper ChoosenCategory;

    public void SelectCategory(int i)
    {
        if (i < Categories.Count - 1)
        {
            ChoosenCategory = Categories[i];
        }
        Debug.Log(ChoosenCategory.categoryName);
        ButtonManager.AdvanceScene();
    }

    public void Start()
    {
        for(int i = 0; i < Categories.Count; i++)
        {
            GameObject.Find("TextForButton" + (i + 1)).GetComponent<Text>().text = Categories[i].categoryName;
        }
    }
}

[System.Serializable]
public class QuestionListWrapper
{
    public string categoryName;
    public List<Question> Category;
}