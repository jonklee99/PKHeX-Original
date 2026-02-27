using System.Collections.Generic;

namespace PKHeX.Core;

/// <summary>
/// Static wrapper providing unified access to batch editing operations on <see cref="PKM"/> entities.
/// </summary>
public static class BatchEditing
{
    /// <summary>
    /// Checks if the object matches all provided <see cref="filters"/>.
    /// </summary>
    public static bool IsFilterMatch<T>(IEnumerable<StringInstruction> filters, T obj) where T : notnull
        => BatchEditingUtil.IsFilterMatch(filters, obj);

    /// <summary>
    /// Screens the string instructions for validity against known property names.
    /// </summary>
    public static void ScreenStrings(IEnumerable<StringInstruction> il)
        => EntityBatchEditor.ScreenStrings(il);

    /// <summary>
    /// Attempts to modify the <see cref="PKM"/> with the provided filters and instructions.
    /// </summary>
    /// <returns>True if the entity was successfully modified.</returns>
    public static bool TryModify(PKM pk, IEnumerable<StringInstruction> filters, IEnumerable<StringInstruction> instructions)
        => EntityBatchEditor.Instance.TryModifyIsSuccess(pk, filters, instructions);
}
