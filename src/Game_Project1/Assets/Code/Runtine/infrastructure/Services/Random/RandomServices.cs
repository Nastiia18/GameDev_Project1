namespace Code.Runtine.infrastructure.Services.Random
{
    public class RandomServices : IRandomServices
    {
        public float Range(float minInclusive, float maxInclusive)=>
        UnityEngine.Random.Range(minInclusive, maxInclusive);
    }
}