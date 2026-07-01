namespace DotaInsight.Domain.Analytics.Scoring;

public class CounterPickScore
{
    public CounterPickScore()
    {
        // Ef core
    }

    private CounterPickScore(double confidence, double matchupImpact)
    {
        Confidence = confidence;
        MatchupImpact = matchupImpact;
        Score = matchupImpact * confidence;
    }
    
    public double Confidence { get; private set; }
    
    public double MatchupImpact { get; private set; } // matchupImpact = matchupWinrate - heroBaseWinrate
    
    public double Score { get; private set; } // score = matchupImpact * confidence

    public static (CounterPickScore? counterPickScore, string? error) Create(
        double confidence, double matchupImpact)
    {
        if (confidence is < 0 or > 1)
        {
            return (null, "Incorrect confidence value");
        }
        
        if (matchupImpact is < -1 or > 1 )
        {
            return (null, "Incorrect matchup impact value");
        }

        var counterPickScore = new CounterPickScore(confidence, matchupImpact);

        return (counterPickScore, null);
    }
}