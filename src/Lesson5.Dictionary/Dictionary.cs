namespace Lesson5.Dictionary;

class Dictionary
{
    private string[] key = new string[5];
    private string[] valueEn = new string[5];
    private string[] valueUa = new string[5];

    public Dictionary()
    {
        key[0] = "книга"; valueEn[0] = "book"; valueUa[0] = "книга";
        key[1] = "ручка"; valueEn[1] = "pen"; valueUa[1] = "ручка";
        key[2] = "сонце"; valueEn[2] = "sun"; valueUa[2] = "сонце";
        key[3] = "яблуко"; valueEn[3] = "apple"; valueUa[3] = "яблуко";
        key[4] = "стіл"; valueEn[4] = "table"; valueUa[4] = "стіл";
    }

    public string this[string index]
    {
        get
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == index)
                    return $"{key[i]} - en: {valueEn[i]}, ua: {valueUa[i]}";
                if (valueEn[i] == index)
                    return $"en: {index} - ru: {key[i]}, ua: {valueUa[i]}";
                if (valueUa[i] == index)
                    return $"ua: {index} - ru: {key[i]}, en: {valueEn[i]}";
            }

            return $"{index} - немає перекладу для цього слова.";
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < key.Length)
                return $"{key[index]} - en: {valueEn[index]}, ua: {valueUa[index]}";
            else
                return "Спроба звернення за межі масиву.";
        }
    }      
}

