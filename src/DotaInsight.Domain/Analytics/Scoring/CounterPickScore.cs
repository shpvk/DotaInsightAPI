using DotaInsight.Domain.Shared;

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
    
    public double MatchupImpact { get; private set; }
    
    public double Score { get; private set; } // score = matchupImpact * confidence

    public static Result<CounterPickScore> Create(
        double confidence, double matchupImpact)
    {
        if (confidence is < 0 or > 1)
        {
            return Result<CounterPickScore>.Failure("Confidence must be between 0 and 1.");
        }
        
        if (matchupImpact is < -100 or > 100 )
        {
            return Result<CounterPickScore>.Failure("Matchup impact must be between -100 and 100.");
        }

        var counterPickScore = new CounterPickScore(confidence, matchupImpact);

        return Result<CounterPickScore>.Success(counterPickScore);
    }
}