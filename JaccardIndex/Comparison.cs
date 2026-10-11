public class Comparison
{
    public Perfume perfume1;
    public Perfume perfume2;
    public double points;
    public double total;
    public double result;
    public string displayPercent;
    public Comparison(Perfume perfume_1, Perfume perfume_2)
    {
        perfume1 = perfume_1;
        perfume2 = perfume_2;
        points = 0;
        total = 0;
        result = 0;
        CompareAccords();
        CompareSeason();
        CompareDay();
        CompareNotes();
        CalcResult();
        //Console.WriteLine($"p: {points}");
        //Console.WriteLine($"t: {total}");
        displayPercent = $"{(result * 100 % 100).ToString("F2")} %";
    }
    public void CalcResult()
    {
        result = points / total;
    }
    private void CompareAccords()
    {
        Perfume minAccords = perfume1;
        Perfume maxAccords = perfume2;
        if (minAccords.Accords.Count > perfume2.Accords.Count)
        {
            maxAccords = perfume1;
            minAccords = perfume2;
            total += perfume2.Accords.Count;
        }
        else
        {
            total += perfume1.Accords.Count;
        }
        for (int i = 0; i < maxAccords.Accords.Count; i++)
        {
            if (minAccords.Accords.Contains(maxAccords.Accords[i]))
            {
                points++;
            }
        }
    }
    private void CompareSeason()
    {
        Perfume minSeasons = perfume1;
        Perfume maxSeasons = perfume2;
        if (minSeasons.Seasons.Count > perfume2.Seasons.Count)
        {
            maxSeasons = perfume1;
            minSeasons = perfume2;
            total += minSeasons.Seasons.Count * 2;
        }
        else
        {
            total += minSeasons.Seasons.Count * 2;
        }
        for (int i = 0; i < maxSeasons.Seasons.Count; i++)
        {
            if (minSeasons.Seasons.Contains(maxSeasons.Seasons[i]))
            {
                points += 2;
            }
        }
    }
    private void CompareDay()
    {
        total ++;
        if (perfume1.DayPeriod == perfume2.DayPeriod)
        {
            points ++;
        }
    }
    private void CompareNotes()
    {
        Perfume minNotes = perfume1;
        Perfume maxNotes = perfume2;
        if (minNotes.Notes.Count > perfume2.Notes.Count)
        {
            maxNotes = perfume1;
            minNotes = perfume2;
            total += perfume2.Notes.Count;
        }
        else
        {
            total += minNotes.Notes.Count;
        }
        for (int i = 0; i < maxNotes.Notes.Count; i++)
        {
            if (minNotes.Notes.Contains(maxNotes.Notes[i]))
            {
                points++;
            }
        }
    }
}