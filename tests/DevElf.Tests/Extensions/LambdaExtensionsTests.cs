using System;
using AwesomeAssertions;
using DevElf.Extensions;

namespace DevElf.Tests.Extensions;

[TestClass]
public class LambdaExtensionsTests
{
    [TestMethod]
    public void UnwrapAndReThrow_Action_throws_ArgumentNullException_when_action_is_null()
    {
        // Arrange
        Action action = null!;

        // Act
        Action act = () => action.UnwrapAndReThrow();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(action));
    }

    [TestMethod]
    public void UnwrapAndReThrow_Action_executes_without_exception_when_action_succeeds()
    {
        // Arrange
        bool called = false;
        Action action = () => called = true;

        // Act
        Action wrapped = action.UnwrapAndReThrow();
        wrapped();

        // Assert
        _ = called.Should().BeTrue();
    }

    [TestMethod]
    public void UnwrapAndReThrow_Action_re_throws_innermost_exception_preserving_stack_trace()
    {
        // Arrange
        Exception innerMost = new InvalidOperationException("inner-most");
        Exception middle = new ApplicationException("middle", innerMost);
        Action action = () => throw new Exception("top", middle);
        Action wrapped = action.UnwrapAndReThrow();

        // Act
        Action act = () => wrapped();

        // Assert
        _ = act.Should().Throw<InvalidOperationException>()
            .WithMessage("inner-most");
    }

    [TestMethod]
    public void UnwrapAndReThrow_Func_throws_ArgumentNullException_when_func_is_null()
    {
        // Arrange
        Func<int> function = null!;

        // Act
        Action act = () => function.UnwrapAndReThrow();

        // Assert
        _ = act.Should().Throw<ArgumentNullException>()
            .WithParameterName(nameof(function));
    }

    [TestMethod]
    public void UnwrapAndReThrow_Func_executes_and_returns_value_when_function_succeeds()
    {
        // Arrange
        Func<string> func = () => "OK";

        // Act
        Func<string> wrapped = func.UnwrapAndReThrow();
        string result = wrapped();

        // Assert
        _ = result.Should().Be("OK");
    }

    [TestMethod]
    public void UnwrapAndReThrow_Func_re_throws_innermost_exception_preserving_stack_trace()
    {
        // Arrange
        Exception innerMost = new ArgumentException("bad");
        Func<int> func = () => throw new Exception("top", new InvalidOperationException("mid", innerMost));
        Func<int> wrapped = func.UnwrapAndReThrow();

        // Act
        Action act = () => _ = wrapped();

        // Assert
        _ = act.Should().Throw<ArgumentException>()
            .WithMessage("bad");
    }
}
