using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class StringExtensionsTests
{
	[TestMethod]
	public void IsNull_ReturnsTrue_ForNull()
	{
		string? s = null;
		Assert.IsTrue(s.IsNull());
	}

	[TestMethod]
	public void IsNull_ReturnsFalse_ForEmpty()
	{
        string s = string.Empty;
		Assert.IsFalse(s.IsNull());
	}

	[TestMethod]
	public void IsNullOrEmpty_ReturnsTrue_ForNull()
	{
		string? s = null;
		Assert.IsTrue(s.IsNullOrEmpty());
	}

	[TestMethod]
	public void IsNullOrEmpty_ReturnsTrue_ForEmpty()
	{
        string s = "";
		Assert.IsTrue(s.IsNullOrEmpty());
	}

	[TestMethod]
	public void IsNullOrEmpty_ReturnsFalse_ForNonEmpty()
	{
        string s = "abc";
		Assert.IsFalse(s.IsNullOrEmpty());
	}

	[TestMethod]
	public void IsNullOrWhiteSpace_ReturnsTrue_ForNull()
	{
		string? s = null;
		Assert.IsTrue(s.IsNullOrWhiteSpace());
	}

	[TestMethod]
	public void IsNullOrWhiteSpace_ReturnsTrue_ForWhitespace()
	{
        string s = "   \t\n";
		Assert.IsTrue(s.IsNullOrWhiteSpace());
	}

	[TestMethod]
	public void IsNullOrWhiteSpace_ReturnsFalse_ForNonWhitespace()
	{
        string s = " a ";
		Assert.IsFalse(s.IsNullOrWhiteSpace());
	}
}
