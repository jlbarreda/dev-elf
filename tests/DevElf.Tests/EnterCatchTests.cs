using AwesomeAssertions;

namespace DevElf.Tests;

[TestClass]
public class EnterCatchTests
{
    [TestMethod]
    public void Never_returns_false_after_executing_action()
    {
        // Arrange
        bool actionExecuted = false;

        // Act
        bool result = EnterCatch.Never(() => actionExecuted = true);

        // Assert
        _ = actionExecuted.Should().BeTrue();
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void Never_throws_when_action_is_null()
    {
        // Arrange
        // Act
        var act = () => EnterCatch.Never(null!);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void Never_allows_exception_to_propagate_when_used_in_catch_filter()
    {
        // Arrange
        bool actionExecuted = false;
        bool catchBlockEntered = false;

        // Act
        var act = () =>
        {
            try
            {
                throw new InvalidOperationException("Test exception");
            }
            catch (InvalidOperationException) when (EnterCatch.Never(() => actionExecuted = true))
            {
                catchBlockEntered = true;
            }
        };

        // Assert
        _ = act.Should().Throw<InvalidOperationException>();
        _ = actionExecuted.Should().BeTrue();
        _ = catchBlockEntered.Should().BeFalse();
    }

    [TestMethod]
    public void AfterAction_executes_action_and_returns_true()
    {
        // Arrange
        bool actionExecuted = false;

        // Act
        bool result = EnterCatch.AfterAction(() => actionExecuted = true);

        // Assert
        _ = actionExecuted.Should().BeTrue();
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void AfterAction_throws_when_action_is_null()
    {
        // Arrange
        // Act
        var act = () => EnterCatch.AfterAction(null!);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void AfterAction_causes_catch_block_to_execute_when_used_in_catch_filter()
    {
        // Arrange
        bool actionExecuted = false;
        bool catchBlockEntered = false;
        InvalidOperationException? caughtException = null;

        // Act
        try
        {
            throw new InvalidOperationException("Test exception");
        }
        catch (InvalidOperationException ex) when (EnterCatch.AfterAction(() => actionExecuted = true))
        {
            catchBlockEntered = true;
            caughtException = ex;
        }

        // Assert
        _ = actionExecuted.Should().BeTrue();
        _ = catchBlockEntered.Should().BeTrue();
        _ = caughtException.Should().NotBeNull();
        _ = caughtException!.Message.Should().Be("Test exception");
    }

    [TestMethod]
    public void AfterAction_preserves_exception_context_for_logging()
    {
        // Arrange
        string? loggedMessage = null;
        string? loggedStackTrace = null;

        // Act
        try
        {
            throw new InvalidOperationException("Context preserved");
        }
        catch (InvalidOperationException ex) when (EnterCatch.AfterAction(() =>
        {
            loggedMessage = ex.Message;
            loggedStackTrace = ex.StackTrace;
        }))
        {
            // handle exception
        }

        // Assert
        _ = loggedMessage.Should().Be("Context preserved");
        _ = loggedStackTrace.Should().NotBeNull();
    }

    [TestMethod]
    public void AfterActionIf_executes_action_and_returns_condition_result_when_true()
    {
        // Arrange
        bool actionExecuted = false;

        // Act
        bool result = EnterCatch.AfterActionIf(
            () => actionExecuted = true,
            () => true);

        // Assert
        _ = actionExecuted.Should().BeTrue();
        _ = result.Should().BeTrue();
    }

    [TestMethod]
    public void AfterActionIf_executes_action_and_returns_condition_result_when_false()
    {
        // Arrange
        bool actionExecuted = false;

        // Act
        bool result = EnterCatch.AfterActionIf(
            () => actionExecuted = true,
            () => false);

        // Assert
        _ = actionExecuted.Should().BeTrue();
        _ = result.Should().BeFalse();
    }

    [TestMethod]
    public void AfterActionIf_throws_when_action_is_null()
    {
        // Arrange
        // Act
        var act = () => EnterCatch.AfterActionIf(null!, () => true);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void AfterActionIf_throws_when_condition_is_null()
    {
        // Arrange
        // Act
        var act = () => EnterCatch.AfterActionIf(() => { }, null!);

        // Assert
        _ = act.Should().Throw<ArgumentNullException>();
    }

    [TestMethod]
    public void AfterActionIf_enters_catch_block_when_condition_returns_true()
    {
        // Arrange
        bool actionExecuted = false;
        bool catchBlockEntered = false;
        int retryCount = 0;
        int maxRetries = 3;

        // Act
        try
        {
            throw new InvalidOperationException("Test exception");
        }
        catch (InvalidOperationException) when (EnterCatch.AfterActionIf(
            () => actionExecuted = true,
            () => retryCount < maxRetries))
        {
            catchBlockEntered = true;
            retryCount++;
        }

        // Assert
        _ = actionExecuted.Should().BeTrue();
        _ = catchBlockEntered.Should().BeTrue();
        _ = retryCount.Should().Be(1);
    }

    [TestMethod]
    public void AfterActionIf_does_not_enter_catch_block_when_condition_returns_false()
    {
        // Arrange
        bool actionExecuted = false;
        bool catchBlockEntered = false;
        int retryCount = 5;
        int maxRetries = 3;

        // Act
        var act = () =>
        {
            try
            {
                throw new InvalidOperationException("Test exception");
            }
            catch (InvalidOperationException) when (EnterCatch.AfterActionIf(
                () => actionExecuted = true,
                () => retryCount < maxRetries))
            {
                catchBlockEntered = true;
            }
        };

        // Assert
        _ = act.Should().Throw<InvalidOperationException>();
        _ = actionExecuted.Should().BeTrue();
        _ = catchBlockEntered.Should().BeFalse();
    }

    [TestMethod]
    public void AfterActionIf_executes_action_before_evaluating_condition()
    {
        // Arrange
        int executionOrder = 0;
        int actionExecutionOrder = 0;
        int conditionExecutionOrder = 0;

        // Act
        _ = EnterCatch.AfterActionIf(
            () => actionExecutionOrder = ++executionOrder,
            () =>
            {
                conditionExecutionOrder = ++executionOrder;

                return true;
            });

        // Assert
        _ = actionExecutionOrder.Should().Be(1);
        _ = conditionExecutionOrder.Should().Be(2);
    }

    [TestMethod]
    public void AfterActionIf_allows_condition_to_access_state_modified_by_action()
    {
        // Arrange
        int counter = 0;

        // Act
        bool result = EnterCatch.AfterActionIf(
            () => counter++,
            () => counter > 0);

        // Assert
        _ = result.Should().BeTrue();
        _ = counter.Should().Be(1);
    }
}
