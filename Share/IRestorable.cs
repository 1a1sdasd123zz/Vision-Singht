namespace Share;

/// <summary>
/// 所有需要支持恢复默认布局的控件都要实现此接口
/// </summary>
public interface IRestorable
{
    /// <summary>
    /// 恢复控件到默认布局状态
    /// </summary>
    void RestoreToDefault();
}

