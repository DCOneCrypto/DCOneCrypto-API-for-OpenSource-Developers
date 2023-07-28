namespace DCOneCrypto.Common.Services;

public class HeartBeatService
{
    private readonly QueryService _queryService;

    public HeartBeatService(QueryService queryService)
    {
        _queryService = queryService;
    }

    public ulong LatestBlockNo { get; set; }

    public ulong LatestSlotNo { get; set; }

    public event EventHandler? Hearbeat;

    public void TriggerHeartBeat()
    {
        _queryService.Invalidate();
        Hearbeat?.Invoke(this, EventArgs.Empty);
    }
}