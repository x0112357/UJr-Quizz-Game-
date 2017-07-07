using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryManager : MonoBehaviour
{
    public List<QuestionListWrapper> Categories;
    public static QuestionListWrapper ChoosenCategory;

    public void SelectCategory(int i)
    {
        if (i > 0 && i < Categories.Count - 1)
            ChoosenCategory = Categories[i];
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}

[System.Serializable]
public class QuestionListWrapper
{
    public List<Question> Category;
}