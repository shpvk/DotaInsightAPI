using DotaInsight.Domain.Shared;

namespace DotaInsight.Domain.Analytics.Scoring;

public class CounterPickCalculator
{
    private const int ReliableSampleSizeThreshold = 100;
    public static Result<CounterPickScore> Calculate(double heroBaseWinrate, double matchupWinrate, int matchupSampleSize)
    {
        if (heroBaseWinrate is < 0 or > 100)
        {
            return Result<CounterPickScore>.Failure("Hero base winrate is lower than zero or higher then 100");
        }
        
        if (matchupWinrate is < 0 or > 100)
        {
            return Result<CounterPickScore>.Failure("Matchup winrate is lower than zero or higher then 100");
        }
        
        if (matchupSampleSize is < 0)
        {
            return Result<CounterPickScore>.Failure("Matchup sample size is lower than zero");
        }
        
        double sampleSize = matchupSampleSize;
        var confidence = CalculateConfidence(1, sampleSize);
        
        var matchupImpact = matchupWinrate - heroBaseWinrate;
        
        return CounterPickScore.Create(confidence, matchupImpact);
    }

    private static double CalculateConfidence(int topLimit, double sampleSize)
    {
        var result = sampleSize / ReliableSampleSizeThreshold;

        if (result > topLimit)
        {
            return topLimit;
        }

        return result;
    }
}