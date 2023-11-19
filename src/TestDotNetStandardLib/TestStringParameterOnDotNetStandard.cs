using ImGuiNET;

namespace TestDotNetStandardLib
{
	public static class TestStringParameterOnDotNetStandard
	{
		public static void Text()
		{
			ImGui.Text(".NET Standard 2.0 test!");
			ImGui.GetWindowDrawList().AddText(ImGui.GetCursorScreenPos(), uint.MaxValue, "DrawList works on .NET Standard too");
			ImGui.NewLine();
		}
	}
}
