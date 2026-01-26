public static class DictionaryHelper
{
    public static bool AreElementsVisible(Dictionary<string, bool> elements)
    {
        Dictionary<string, bool> filteredNotVisibleElements = elements.Where(x => !x.Value).ToDictionary(x => x.Key, x => x.Value);

        if (filteredNotVisibleElements.Count > 0)
        {
            GetErrorsInfoFromElements(filteredNotVisibleElements);
            return false;
        }

        return true;
    }

    public static void GetErrorsInfoFromElements(Dictionary<string, bool> elements)
    {
        Dictionary<string, bool> filteredElements = elements.Where(x => !x.Value).ToDictionary(x => x.Key, x => x.Value);

        if (filteredElements.Count == 0) return;

        foreach (var element in filteredElements)
        {
            Logger.Error($"Couldn't find: {element}");
        }
    }
}