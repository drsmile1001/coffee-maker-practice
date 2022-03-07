namespace CoffeeMaker;

public enum WarmerPlateStatus
{
    WARMER_EMPTY,
    POT_EMPTY,
    POT_NOT_EMPTY,
}

public enum BoilerStatus
{
    EMPTY, NOT_EMPTY
}

public enum BrewButtonStatus
{
    PUSHED, NOT_PUSHED
}

public enum BoilerState
{
    ON, OFF
}

public enum WarmerState
{
    ON, OFF
}

public enum IndicatorState
{
    ON, OFF
}

public enum ReliefValveState
{
    OPEN, CLOSED
}

public interface CoffeeMakerAPI
{
    WarmerPlateStatus GetWarmerPlateStatus();

    BoilerStatus GetBoilerStatus();

    /// <summary>
    /// 呼叫時可以得到是否有按過按鈕。呼叫後再次呼叫會變成未按過
    /// </summary>
    /// <returns></returns>
    BrewButtonStatus GetBrewButtonStatus();

    /// <summary>
    /// 設定加熱器
    /// </summary>
    /// <param name="s"></param>
    void SetBoilerState(BoilerState s);

    /// <summary>
    /// 設定保溫盤
    /// </summary>
    /// <param name="s"></param>
    void SetWarmerState(WarmerState s);

    /// <summary>
    /// 設定指示燈狀態，運作中應爲off，沖泡完成應爲on
    /// </summary>
    /// <param name="s"></param>
    void SetIndicatorState(IndicatorState s);

    /// <summary>
    /// 設定減壓閥 關的時候熱水噴到濾水器，開的時候釋放到外部
    /// </summary>
    /// <param name="s"></param>
    void SetReliefVavleState(ReliefValveState s);
}