using UnityEngine;

public static class Singleton
{
    public static T MakeInstance<T>(T @this, T instance) where T : Object
    {
        if (instance != null && instance != @this)
        {
            Debug.LogWarning(@this.name + " has been deleted");
            Object.Destroy(@this);
            if(@this is MonoBehaviour)  
                Object.Destroy((@this as MonoBehaviour).gameObject);
        }
        else
        {
            instance = @this;
        }
        return instance;
    }
}