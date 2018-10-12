using System;
using System.ComponentModel;

namespace mobileteam2.Enums
{
    public enum TimelineSteps
    {
        [Description("Inspection Completed")] Inspection = 1,
        [Description("Estimate Written")] EstimateWritten = 2,
        [Description("First Payment & Documents Provided")] FirstPaymentsDocsProvided = 3,
        [Description("Received Work Completed Notification")] ReceiveWorkCompNotification = 4,
        [Description("Final Payment Received")] FinalPayment = 5
    }

    internal static class TimelineStepExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();

            var name = Enum.GetName(type, value);
            if (name == null) return null;

            var field = type.GetField(name);
            if (field == null) return null;

            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr)
            {
                return attr.Description;
            }
            return null;
        }
    }
}
