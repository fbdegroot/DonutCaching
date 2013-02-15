namespace DonutCaching
{
	public interface IActionSettingsSerialiser
	{
		string Serialise(ActionSettings actionSettings);
		ActionSettings Deserialise(string serialisedActionSettings);
	}
}