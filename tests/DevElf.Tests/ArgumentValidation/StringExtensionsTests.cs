using DevElf.ArgumentValidation;

namespace DevElf.Tests.ArgumentValidation;

[TestClass]
public class StringExtensionsTests
{
	[TestMethod]
	public void ThrowIfNullOrEmpty_DoesNotThrow_ForNonEmpty()
	{
		string s = "abc";
		s.ThrowIfNullOrEmpty();
	}

	[TestMethod]
	public void ThrowIfNullOrEmpty_ThrowsArgumentNullException_ForNull()
	{
		string? s = null;
        ArgumentNullException ex = Assert.ThrowsException<ArgumentNullException>(() => s.ThrowIfNullOrEmpty());
		Assert.AreEqual(nameof(s), ex.ParamName);
	}

	[TestMethod]
	public void ThrowIfNullOrEmpty_ThrowsArgumentException_ForEmpty()
	{
		string s = string.Empty;
        ArgumentException ex = Assert.ThrowsException<ArgumentException>(() => s.ThrowIfNullOrEmpty());
		Assert.AreEqual(nameof(s), ex.ParamName);
	}
}
