using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class StringExtensionsTests
{
	[TestMethod]
	public void IfNullOrEmpty_DoesNotThrow_ForNonEmpty()
	{
		string s = "abc";
		s.IfNullOrEmpty();
	}

	[TestMethod]
	public void IfNullOrEmpty_ThrowsArgumentNullException_ForNull()
	{
		string? s = null;
		var ex = Assert.ThrowsException<ArgumentNullException>(() => s.IfNullOrEmpty());
		Assert.AreEqual(nameof(s), ex.ParamName);
	}

	[TestMethod]
	public void IfNullOrEmpty_ThrowsArgumentException_ForEmpty()
	{
		string s = string.Empty;
        ArgumentException ex = Assert.ThrowsException<ArgumentException>(() => s.IfNullOrEmpty());
		Assert.AreEqual(nameof(s), ex.ParamName);
	}
}
