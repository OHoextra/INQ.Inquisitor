using System.Reflection;

namespace INQ.Inquisitor.App.Extensions;

public static class MethodInfoExtensions
{
    public static MethodInfo GetByName(this IEnumerable<MethodInfo> methodInfos, string name)
        => methodInfos.Single(m => m.Name == name);

    public static async Task<object?> RunMethodAsync(this MethodInfo selectedMethod,
        Dictionary<string, object> parameterValues)
    {
        object? result = null;
        var parameterArray = parameterValues.Values.ToArray();

        if (selectedMethod.ReturnType == typeof(Task))
        {
            result = selectedMethod.Invoke(null, parameterArray);
            await ((Task)result).ConfigureAwait(false);
        }
        else if (selectedMethod.ReturnType.IsGenericType && selectedMethod.ReturnType.GetGenericTypeDefinition() == typeof(Task<>))
        {
            var task = (Task)selectedMethod.Invoke(null, parameterArray);
            await task.ConfigureAwait(false);
            var resultProperty = task.GetType().GetProperty("Result");
            result = resultProperty.GetValue(task);
        }
        else
        {
            result = selectedMethod.Invoke(null, parameterArray);
        }

        return result;
    }
}

