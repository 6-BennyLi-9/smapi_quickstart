using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace smapi_quickstart
{
    /**
     * <summary>模组加载入口。</summary>
     * <summary>The mod entry point.</summary>
     */
    internal sealed class ModEntry : Mod
    {
        /**
         * <summary>模组加载入口，在模组首次加载时调用。</summary>
         * <summary>The mod entry point, called after the mod is first loaded.</summary>
         * <param name="helper">
         *     提供用于编写模组的简单的 API。
         *     Provides simplified APIs for writing mods.
         * </param>
         */
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += OnButtonPressed;
        }

        /**
         * <summary>在玩家按下键盘、鼠标等硬件时调用</summary>
         * <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
         * <param name="sender">
         *     事件发送器。
         *     The event sender.
         * </param>
         * <param name="e">
         *     事件数据。
         *     The event data.
         * </param>
         */
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // 忽略： 玩家未加载存档
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
            {
                return;
            }

            // 将按键打印到命令行
            // print button presses to the console window
            Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
        }
    }
}