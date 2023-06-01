using System.Reflection;
using System.Text.Json;

namespace INQ.Inquisitor.App.Extensions;

public static class MethodInfoExtensions
    {
        public static async Task<object?> RunMethodAsync(this MethodInfo selectedMethod, Dictionary<string, object> parameterValues)
        {
            object? result;
            if (selectedMethod.ReturnType == typeof(Task))
            {
                result = selectedMethod.Invoke(null, parameterValues.Values.ToArray());
                await ((Task)result);
            }
            else if (selectedMethod.ReturnType.IsGenericType && selectedMethod.ReturnType.GetGenericTypeDefinition() == typeof(Task<>))
            {
                var task = (Task)selectedMethod.Invoke(null, parameterValues.Values.ToArray());
                await task.ConfigureAwait(false);
                var resultProperty = task.GetType().GetProperty("Result");
                result = resultProperty.GetValue(task);
            }
            else
            {
                result = selectedMethod.Invoke(null, parameterValues.Values.ToArray());
            }

            return result;
        }
}

